using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.ComponentModel;

using PersonalSV.Controllers;
using PersonalSV.Models;
using PersonalSV.ViewModels;
using PersonalSV.Helpers;

namespace PersonalSV.Views
{
    /// <summary>
    /// Interaction logic for LeaveWithSalaryWindow.xaml
    /// </summary>
    public partial class LeaveWithSalaryWindow : Window
    {
        BackgroundWorker bwLoad;
        BackgroundWorker bwTreeviewClicked;
        BackgroundWorker bwSave;
        BackgroundWorker bwDelete;
        List<EmployeeModel> employeeList;
        List<DepartmentModel> departmentList;
        bool needToProcess = false;

        public LeaveWithSalaryWindow()
        {
            bwLoad = new BackgroundWorker();
            bwLoad.DoWork += new DoWorkEventHandler(bwLoad_DoWork);
            bwLoad.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwLoad_RunWorkerCompleted);

            bwTreeviewClicked = new BackgroundWorker();
            bwTreeviewClicked.DoWork += new DoWorkEventHandler(bwTreeviewClicked_DoWork);
            bwTreeviewClicked.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwTreeviewClicked_RunWorkerCompleted);

            bwSave = new BackgroundWorker();
            bwSave.DoWork += new DoWorkEventHandler(bwSave_DoWork);
            bwSave.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwSave_RunWorkerCompleted);

            bwDelete = new BackgroundWorker();
            bwDelete.DoWork += new DoWorkEventHandler(bwDelete_DoWork);
            bwDelete.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwDelete_RunWorkerCompleted);

            departmentList = new List<DepartmentModel>();
            employeeList = new List<EmployeeModel>();
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (bwLoad.IsBusy == false)
            {
                this.Cursor = Cursors.Wait;
                bwLoad.RunWorkerAsync();
            }
        }
        private void bwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                employeeList = EmployeeController.GetAll();
                departmentList = DepartmentController.GetDepartments();
            }
            catch (Exception ex)
            {
                Dispatcher.Invoke(new Action(() =>
                {
                    MessageBox.Show(string.Format("{0} !", ex.Message), this.Title, MessageBoxButton.OK, MessageBoxImage.Warning);
                }));
            }
        }
        private void bwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // cretate treeview
            var deptParentList = departmentList.Where(w => string.IsNullOrEmpty(w.ParentID) == true).ToList();
            foreach (var departParent in deptParentList)
            {
                TreeViewItem tviParent = new TreeViewItem();

                var departmentsChild = departmentList.Where(w => w.ParentID == departParent.DepartmentID).ToList();
                foreach (var child in departmentsChild)
                {
                    TreeViewItem tviChild = new TreeViewItem();
                    tviChild.Header = child.DepartmentName;
                    tviChild.Margin = new Thickness(0, 2, 0, 2);
                    tviChild.FontWeight = FontWeights.Normal;
                    tviChild.Foreground = Brushes.Blue;
                    tviChild.Tag = child;
                    tviChild.MouseDoubleClick += new MouseButtonEventHandler(tvi_MouseDoubleClick);

                    tviParent.Items.Add(tviChild);
                }

                tviParent.Header = departParent.DepartmentName;
                if (departmentsChild.Count() > 0)
                {
                    tviParent.Header = string.Format("{0} ({1})", departParent.DepartmentName, departmentsChild.Count);
                }
                tviParent.FontWeight = FontWeights.Bold;
                tviParent.Margin = new Thickness(0, 2, 0, 2);
                tviParent.Foreground = Brushes.Black;

                tviParent.Tag = departParent;
                tviParent.MouseDoubleClick += new MouseButtonEventHandler(tvi_MouseDoubleClick);

                treeDepartments.Items.Add(tviParent);
            }

            gridOTInfor.DataContext = new OverTimeLimitModel();

            dpDateFrom.SelectedDate = DateTime.Now.Date;
            dpDateTo.SelectedDate = DateTime.Now.Date;
            this.Cursor = null;
        }

        private void tvi_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var itemClicked = sender as TreeViewItem;
            var departmentClicked = itemClicked.Tag as DepartmentModel;

            if (departmentClicked != null && bwTreeviewClicked.IsBusy == false)
            {
                // Check Is Parent Dept
                var departmentListClicked = new List<DepartmentModel>();
                var employeeSelectedList = new List<EmployeeModel>();
                //searchTitle = "";
                var childDeptList = departmentList.Where(w => w.ParentID == departmentClicked.DepartmentID).ToList();
                if (childDeptList.Count() > 0)
                {
                    //string parentID = "parentID";
                    foreach (var child in childDeptList)
                    {
                        //parentID = child.ParentID;
                        departmentListClicked.Add(child);
                        employeeSelectedList.AddRange(employeeList.Where(w => w.DepartmentName.Trim().ToUpper().ToString() == child.DepartmentFullName.Trim().ToUpper().ToString()));
                    }

                    //var parentName = departmentList.Where(w => w.DepartmentID == parentID).FirstOrDefault();
                    //if (parentName != null)
                    //    searchTitle = string.Format("{0} : {1}", LanguageHelper.GetStringFromResource("commonEmployeeSection"), parentName.DepartmentName);
                    //var parentName = departmentList.Where(w => w.DepartmentID == parentID).FirstOrDefault();
                    //var grandName = departmentList.Where(w => string.IsNullOrEmpty(w.ParentID)).ToList();
                }
                else
                {
                    departmentListClicked.Add(departmentClicked);
                    employeeSelectedList.AddRange(employeeList.Where(w => w.DepartmentName.Trim().ToUpper().ToString() == departmentClicked.DepartmentFullName.Trim().ToUpper().ToString()));
                    //searchTitle = string.Format("{0} : {1}", LanguageHelper.GetStringFromResource("commonEmployeeDepartment"), departmentClicked.DepartmentFullName);
                }

                treeDepartments.IsEnabled = false;
                bwTreeviewClicked.RunWorkerAsync(employeeSelectedList);
                this.Cursor = Cursors.Wait;
            }
        }

        private void bwTreeviewClicked_DoWork(object sender, DoWorkEventArgs e)
        {
            var employeeListPerDepartment = e.Argument as List<EmployeeModel>;
            e.Result = employeeListPerDepartment;
        }
        private void bwTreeviewClicked_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtTotal.Text = "";
            this.Cursor = null;
            treeDepartments.IsEnabled = true;
            var employeeListPerDepartment = e.Result as List<EmployeeModel>;
            if (employeeListPerDepartment.Count() > 0)
                employeeListPerDepartment = employeeListPerDepartment.OrderBy(o => o.DepartmentName).ThenBy(th => th.EmployeeID).ToList();
            dgEmployeePerDepartment.ItemsSource = employeeListPerDepartment;
            if (employeeListPerDepartment.Count > 0)
                txtTotal.Text = String.Format("{0} {1}", LanguageHelper.GetStringFromResource("commonTotalEmployee"), employeeListPerDepartment.Count);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string employeeSearch = txtEmployeeSearch.Text.Trim().ToUpper().ToString();
            var employeeSearched = employeeList.Where(w => w.EmployeeCode == employeeSearch || w.EmployeeID.Trim().ToUpper().ToString() == employeeSearch).FirstOrDefault();
            if (employeeSearched != null)
            {
                var employeeListCurrent = new List<EmployeeModel>();
                if (dgEmployeePerDepartment.ItemsSource != null)
                    employeeListCurrent = dgEmployeePerDepartment.ItemsSource.OfType<EmployeeModel>().ToList();
                if (employeeListCurrent.Where(w => w.EmployeeCode == employeeSearched.EmployeeCode).Count() == 0)
                {
                    employeeListCurrent.Add(employeeSearched);
                    dgEmployeePerDepartment.ItemsSource = employeeListCurrent;
                    dgEmployeePerDepartment.Items.Refresh();

                    Dispatcher.Invoke(new Action(() =>
                    {
                        dgEmployeePerDepartment.SelectedItem = employeeSearched;
                        dgEmployeePerDepartment.ScrollIntoView(employeeSearched);
                    }));
                    if (employeeListCurrent.Count() > 0)
                        txtTotal.Text = string.Format("{0} : {1}", LanguageHelper.GetStringFromResource("commonTextBlockFrom"), employeeListCurrent.Count());
                }
                else
                {
                    Dispatcher.Invoke(new Action(() => {
                        dgEmployeePerDepartment.SelectedItem = employeeSearched;
                        dgEmployeePerDepartment.ScrollIntoView(employeeSearched);
                    }));
                }
            }
            txtEmployeeSearch.SelectAll();
            txtEmployeeSearch.Focus();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            int percent = 0;
            Int32.TryParse(txtSalaryRate.Text, out percent);
            if (percent <= 0)
            {
                MessageBox.Show("Salary Rate Incorrect !", this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                txtSalaryRate.SelectAll();
                return;
            }
            double salaryRate = Math.Round(1 - (double)percent / 100, 2, MidpointRounding.AwayFromZero);
            if (salaryRate > 1)
                salaryRate = 1;

            if (dgEmployeePerDepartment.ItemsSource != null && bwSave.IsBusy == false)
            {
                this.Cursor = Cursors.Wait;
                var employeeList = dgEmployeePerDepartment.ItemsSource.OfType<EmployeeModel>().ToList();
                DateTime dateFrom   = dpDateFrom.SelectedDate.Value;
                DateTime dateTo     = dpDateTo.SelectedDate.Value;
                var leaveWithSalaryList = new List<LeaveWithSalaryModel>(); 
                foreach (var employee in employeeList)
                {
                    for (DateTime date = dateFrom; date <= dateTo; date = date.AddDays(1))
                    {
                    
                        leaveWithSalaryList.Add(new LeaveWithSalaryModel {
                            EmployeeCode = employee.EmployeeCode,
                            AttendanceDate = date.Date,
                            SalaryRate = salaryRate
                        });
                    }
                }

                btnSave.IsEnabled = false;
                bwSave.RunWorkerAsync(leaveWithSalaryList);
            }
        }
        private void bwSave_DoWork(object sender, DoWorkEventArgs e)
        {
            var leaveWithSalaryList = e.Argument as List<LeaveWithSalaryModel>;
            bool result = true; ;
            foreach (var insert in leaveWithSalaryList)
            {
                try
                {
                    var employeeModel = employeeList.First(f => f.EmployeeCode == insert.EmployeeCode);
                    LeaveWithSalaryController.Insert(insert);
                    Dispatcher.Invoke(new Action(() => {
                        dgEmployeePerDepartment.SelectedItem = employeeModel;
                        dgEmployeePerDepartment.ScrollIntoView(employeeModel);
                    }));
                }
                catch (Exception ex)
                {
                    Dispatcher.Invoke(new Action(() =>
                    {
                        MessageBox.Show(string.Format("{0}\nPlease Try Again !", ex.Message), this.Title, MessageBoxButton.OK, MessageBoxImage.Warning);
                    }));
                    result = false;
                }
            }
            e.Result = result;
        }
        private void bwSave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bool result = (bool)e.Result;
            if (result == true)
            {
                MessageBox.Show(string.Format("{0}", LanguageHelper.GetStringFromResource("messageAddDataSucessful")),
                                                this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
            }
            this.Cursor = null;
            btnSave.IsEnabled = true;
            needToProcess = true;
        }

        private void miRemove_Click(object sender, RoutedEventArgs e)
        {
            var itemsRemoveClicked = dgEmployeePerDepartment.SelectedItems.OfType<EmployeeModel>().ToList();
            if (itemsRemoveClicked.Count() > 0 && dgEmployeePerDepartment.ItemsSource != null)
            {
                txtTotal.Text = "";
                var employeeListCurrent = dgEmployeePerDepartment.ItemsSource.OfType<EmployeeModel>().ToList();
                employeeListCurrent.RemoveAll(r => itemsRemoveClicked.Select(s => s.EmployeeCode).Contains(r.EmployeeCode));
                dgEmployeePerDepartment.ItemsSource = employeeListCurrent;
                dgEmployeePerDepartment.Items.Refresh();
                if (employeeListCurrent.Count() > 0)
                    txtTotal.Text = string.Format("{0} : {1}", LanguageHelper.GetStringFromResource("commonTextBlockFrom"), employeeListCurrent.Count());
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string msgConfirmDelete = LanguageHelper.GetStringFromResource("messageConfirmDelete");
            if (MessageBox.Show(msgConfirmDelete, this.Title, MessageBoxButton.OKCancel, MessageBoxImage.Question) != MessageBoxResult.OK)
            {
                return;
            }
            if (dgEmployeePerDepartment.ItemsSource != null && bwDelete.IsBusy == false)
            {
                this.Cursor = Cursors.Wait;
                var employeeList = dgEmployeePerDepartment.ItemsSource.OfType<EmployeeModel>().ToList();
                DateTime dateFrom = dpDateFrom.SelectedDate.Value;
                DateTime dateTo = dpDateTo.SelectedDate.Value;
                var leaveWithSalaryDeleteList = new List<LeaveWithSalaryModel>();
                for (DateTime date = dateFrom; date <= dateTo; date = date.AddDays(1))
                {
                    foreach (var employee in employeeList)
                    {
                        leaveWithSalaryDeleteList.Add(new LeaveWithSalaryModel
                        {
                            EmployeeCode = employee.EmployeeCode,
                            AttendanceDate = date.Date,
                        });
                    }
                }
                btnDelete.IsEnabled = false;
                bwDelete.RunWorkerAsync(leaveWithSalaryDeleteList);
            }
        }
        private void bwDelete_DoWork(object sender, DoWorkEventArgs e)
        {
            var leaveWithSalaryList = e.Argument as List<LeaveWithSalaryModel>;
            bool result = true; ;
            foreach (var deleteModel in leaveWithSalaryList)
            {
                try
                {
                    var employeeModel = employeeList.First(f => f.EmployeeCode == deleteModel.EmployeeCode);
                    LeaveWithSalaryController.Delete(deleteModel);
                    Dispatcher.Invoke(new Action(() => {
                        dgEmployeePerDepartment.SelectedItem = employeeModel;
                        dgEmployeePerDepartment.ScrollIntoView(employeeModel);
                    }));
                }
                catch (Exception ex)
                {
                    Dispatcher.Invoke(new Action(() =>
                    {
                        MessageBox.Show(string.Format("{0}\nPlease Try Again !", ex.Message), this.Title, MessageBoxButton.OK, MessageBoxImage.Warning);
                    }));
                    result = false;
                }
            }
            e.Result = result;
        }
        private void bwDelete_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bool result = (bool)e.Result;
            var msgDeleted = LanguageHelper.GetStringFromResource("messageDeleteDataSucessful");
            if (result == true)
            {
                MessageBox.Show(string.Format("{0}", msgDeleted), this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
                dgEmployeePerDepartment.ItemsSource = new List<OverTimeLimitModel>();
                needToProcess = true;
            }
            this.Cursor = null;
            btnDelete.IsEnabled = true;
        }

        private void txtEmployeeSearch_PreviewGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            btnSearch.IsDefault = true;
        }
        private void txtEmployeeSearch_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            btnSearch.IsDefault = true;
        }
        private void TextBox_PreviewGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            textBox.SelectAll();
        }
        private void dgEmployeePerDepartment_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {

        }
    }
}
