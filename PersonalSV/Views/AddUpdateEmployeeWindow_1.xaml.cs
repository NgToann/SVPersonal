using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.ComponentModel;

using PersonalSV.Controllers;
using PersonalSV.Models;
using PersonalSV.ViewModels;
using PersonalSV.Helpers;
using System.Windows.Media.Imaging;
using System.IO;
using System.Text.RegularExpressions;

namespace PersonalSV.Views
{
    /// <summary>
    /// Interaction logic for AddUpdateEmployeeWindow_1.xaml
    /// </summary>
    public partial class AddUpdateEmployeeWindow_1 : Window
    {
        BackgroundWorker bwLoad;
        BackgroundWorker bwSave;
        List<DepartmentModel> departmentList;
        List<PositionModel> positionList;
        EmployeeViewModel employeeInjectModel;
        EmployeeModel showData;

        List<EmployeeModel> employeeList;
        EmployeeFaceModel employeeFace;
        public EmployeeModel updateModelTranfer;
        public List<EmployeeModel> addEmployeeTranferList;
        EnumEditMode editMode;
        public EnumEditMode responeMode = EnumEditMode.None;

        public AddUpdateEmployeeWindow_1(EmployeeViewModel _injectModel, EnumEditMode _editMode, List<DepartmentModel> _departmentList, List<PositionModel> _positionList)
        {
            this.employeeInjectModel = _injectModel;
            this.editMode = _editMode;
            this.departmentList = _departmentList;
            this.positionList = _positionList;

            bwLoad = new BackgroundWorker();
            bwLoad.DoWork += new DoWorkEventHandler(bwLoad_DoWork);
            bwLoad.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwLoad_RunWorkerCompleted);

            bwSave = new BackgroundWorker();
            bwSave.DoWork += new DoWorkEventHandler(bwSave_DoWork);
            bwSave.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwSave_RunWorkerCompleted);

            addEmployeeTranferList = new List<EmployeeModel>();
            employeeFace = new EmployeeFaceModel();
            showData = new EmployeeModel();
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
                if (employeeInjectModel != null && employeeInjectModel.EmployeeID != null)
                    employeeFace = EmployeeFaceController.GetImageByID(employeeInjectModel.EmployeeID);
            }
            catch (Exception ex)
            {
                Dispatcher.Invoke(new Action(() =>
                {
                    MessageBox.Show(string.Format("{0} !", ex.Message), this.Title, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }));
            }
        }

        List<byte[]> imageFaceList = new List<byte[]>();
        private void bwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Binding to UI
            ConvertToModel(employeeInjectModel, showData);

            gridMain.DataContext = showData;
            if (editMode == EnumEditMode.Add)
            {
                txtEmployeeCode.IsEnabled = true;
            }
            // Binding Combobox
            cbDepartment.ItemsSource = departmentList;
            cbPosition.ItemsSource = positionList;

            // Show Image Worker
            //imgWorker.Source = null;
            imageFaceList = new List<byte[]>();
            if (employeeFace != null)
            {
                //if (employeeFace.Face1 != null)
                //{
                //    imageFaceList.Add(employeeFace.Face1.ToArray());
                //}
                //if (employeeFace.Face2 != null)
                //{
                //    imageFaceList.Add(employeeFace.Face2.ToArray());
                //}
                //if (employeeFace.Face3 != null)
                //{
                //    imageFaceList.Add(employeeFace.Face3.ToArray());
                //}
                //if (employeeFace.Face4 != null)
                //{
                //    imageFaceList.Add(employeeFace.Face4.ToArray());
                //}
                //if (employeeFace.Face5 != null)
                //{
                //    imageFaceList.Add(employeeFace.Face5.ToArray());
                //}

                if (employeeFace.FaceImage11 != null)
                {
                    imageFaceList.Add(employeeFace.FaceImage11.ToArray());
                }
                if (employeeFace.FaceImage21 != null)
                {
                    imageFaceList.Add(employeeFace.FaceImage21.ToArray());
                }
                if (employeeFace.FaceImage31 != null)
                {
                    imageFaceList.Add(employeeFace.FaceImage31.ToArray());
                }
                if (employeeFace.FaceImage41 != null)
                {
                    imageFaceList.Add(employeeFace.FaceImage41.ToArray());
                }
                if (employeeFace.FaceImage51 != null)
                {
                    imageFaceList.Add(employeeFace.FaceImage51.ToArray());
                }
                if (imageFaceList.Count > 0)
                {
                    imgWorker.Source = GetBitmapImageFromJPG(imageFaceList[0]);

                    btnNextImage.IsEnabled = true;
                    btnBackImage.IsEnabled = true;
                }
            }

            this.Cursor = null;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var addModel = gridMain.DataContext as EmployeeModel;
            if (addModel != null)
            {
                string msgEmptyError        = LanguageHelper.GetStringFromResource("messageDataEmpty");
                string msgExistError        = LanguageHelper.GetStringFromResource("messageDataExist");
                string msgIrregularError    = LanguageHelper.GetStringFromResource("messageDataIrRegular");

                string controlEmployeeCode  = LanguageHelper.GetStringFromResource("commonEmployeeCode");
                string controlEmployeeID    = LanguageHelper.GetStringFromResource("commonEmployeeID");
                string controlNationID      = LanguageHelper.GetStringFromResource("commonEmployeeNationID");
                string controlDayOfBirth    = LanguageHelper.GetStringFromResource("commonEmployeeDayOfBirth");
                string controlPhoneNumber   = LanguageHelper.GetStringFromResource("commonEmployeePhoneNumber");
                string controlJoinDate      = LanguageHelper.GetStringFromResource("commonEmployeeJoinDate");
                string controlPosition      = LanguageHelper.GetStringFromResource("commonEmployeePosition");
                string controlDepartment    = LanguageHelper.GetStringFromResource("commonEmployeeDepartment");

                // Check Empty
                if (String.IsNullOrEmpty(addModel.EmployeeCode))
                {
                    MessageBox.Show(string.Format("{0}\n{1}", controlEmployeeCode, msgEmptyError), this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (String.IsNullOrEmpty(addModel.EmployeeID))
                {
                    MessageBox.Show(string.Format("{0}\n{1}", controlEmployeeID, msgEmptyError), this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (String.IsNullOrEmpty(addModel.NationID))
                {
                    MessageBox.Show(string.Format("{0}\n{1}", controlNationID, msgEmptyError), this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (addModel.DepartmentSelected == null)
                {
                    MessageBox.Show(string.Format("{0}\n{1}", controlDepartment, msgEmptyError), this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (addModel.PositionSelected == null)
                {
                    MessageBox.Show(string.Format("{0}\n{1}", controlPosition, msgEmptyError), this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Check Exist
                // Add New
                if (editMode == EnumEditMode.Add)
                {
                    if (employeeList.Where(w => w.EmployeeCode.ToUpper().Trim().ToString() == addModel.EmployeeCode.ToUpper().Trim().ToString()).Count() > 0)
                    {
                        MessageBox.Show(string.Format("{0}\n{1}", controlEmployeeCode, msgExistError), this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    if (employeeList.Where(w => w.EmployeeID.ToUpper().Trim().ToString() == addModel.EmployeeID.ToUpper().Trim().ToString()).Count() > 0)
                    {
                        MessageBox.Show(string.Format("{0}\n{1}", controlEmployeeID, msgExistError), this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    if (employeeList.Where(w => w.NationID.ToUpper().Trim().ToString() == addModel.NationID.ToUpper().Trim().ToString()).Count() > 0)
                    {
                        MessageBox.Show(string.Format("{0}\n{1}", controlNationID, msgExistError), this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                // Update
                if (editMode == EnumEditMode.Update)
                {
                    var checkList = employeeList.Where(w => w.EmployeeCode != addModel.EmployeeCode).ToList();
                    if (checkList.Where(w => w.EmployeeID.ToUpper().Trim().ToString() == addModel.EmployeeID.ToUpper().Trim().ToString()).Count() > 0)
                    {
                        MessageBox.Show(string.Format("{0}\n{1}", controlEmployeeID, msgExistError), this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    if (checkList.Where(w => w.NationID.ToUpper().Trim().ToString() == addModel.NationID.ToUpper().Trim().ToString()).Count() > 0)
                    {
                        MessageBox.Show(string.Format("{0}\n{1}", controlNationID, msgExistError), this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }

                // Check regular
                var regNumber = new Regex(@"[\d]");
                var regWord = new Regex("[a-z]|[A-Z]");
                if (regWord.IsMatch(addModel.EmployeeCode) == true)
                {
                    MessageBox.Show(string.Format("{0}: {1}\n{2}", controlEmployeeCode, addModel.EmployeeCode, msgIrregularError), this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (regWord.IsMatch(addModel.EmployeeID) == false)
                {
                    MessageBox.Show(string.Format("{0}: {1}\n{2}", controlEmployeeID, addModel.EmployeeID, msgIrregularError), this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (addModel.DayOfBirth == new DateTime(01, 01, 01))
                {
                    MessageBox.Show(string.Format("{0}: {1:MM/dd/yyyy}\n{2}", controlDayOfBirth, addModel.DayOfBirth, msgIrregularError), this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (addModel.JoinDate == new DateTime(01, 01, 01))
                {
                    MessageBox.Show(string.Format("{0}: {1:MM/dd/yyyy}\n{2}", controlJoinDate, addModel.JoinDate, msgIrregularError), this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (bwSave.IsBusy == false)
                {
                    this.Cursor = Cursors.Wait;
                    btnSave.IsEnabled = false;
                    bwSave.RunWorkerAsync(addModel);
                }
            }
        }
        private void bwSave_DoWork(object sender, DoWorkEventArgs e)
        {
            bool result = false;
            var addModel = e.Argument as EmployeeModel;
            try
            {
                EmployeeController.AddOrUpdate(addModel, editMode);
                updateModelTranfer = addModel as EmployeeModel;
                responeMode = EnumEditMode.Update;
                if (editMode == EnumEditMode.Add)
                {
                    employeeList.Add(addModel);
                    addEmployeeTranferList.Add(addModel);
                    responeMode = EnumEditMode.Add;
                }
                result = true;
            }
            catch (Exception ex)
            {
                Dispatcher.Invoke(new Action(() =>
                {
                    MessageBox.Show(string.Format("{0}\nPlease Try Again !", ex.Message), this.Title, MessageBoxButton.OK, MessageBoxImage.Warning);
                    result = false;
                }));
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
                if (editMode == EnumEditMode.Add)
                {
                    var refreshModel = new EmployeeModel();
                    gridMain.DataContext = refreshModel;
                    txtEmployeeName.Focus();
                }
            }
            btnSave.IsEnabled = true;
            this.Cursor = null;
        }

        private void ConvertToModel(EmployeeViewModel viewModel, EmployeeModel model)
        {
            model.EmployeeCode  = viewModel.EmployeeCode;
            model.EmployeeID    = viewModel.EmployeeID;
            model.EmployeeName  = viewModel.EmployeeName;

            if (!string.IsNullOrEmpty(viewModel.Gender))
            {
                model.GenderWoman   = viewModel.Gender.ToUpper() == "WOMAN" ? true : false;
                model.GenderMan     = viewModel.Gender.ToUpper() == "MAN" ? true : false;
            }
            if (!string.IsNullOrEmpty(viewModel.DepartmentName))
            {
                model.DepartmentSelected    = departmentList.Where(w => w.DepartmentFullName.ToUpper().Trim().ToString() == viewModel.DepartmentName.ToUpper().Trim().ToString()).FirstOrDefault();
            }
            if (!string.IsNullOrEmpty(viewModel.PositionName))
            {
                model.PositionSelected      = positionList.Where(w => w.PositionName.ToUpper().Trim().ToString() == viewModel.PositionName.ToUpper().Trim().ToString()).FirstOrDefault();
            }

            model.JoinDate      = viewModel.JoinDate;
            model.DayOfBirth    = viewModel.DayOfBirth;
            model.NationID      = viewModel.NationID;
            model.Address       = viewModel.Address;
            model.PhoneNumber   = viewModel.PhoneNumber;
            model.Remark        = viewModel.Remark;
            //model.ATM           = viewModel.ATM;
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Close();
            }
        }

        int imageIndex = 0;
        private void btnNextImage_Click(object sender, RoutedEventArgs e)
        {
            if (imageFaceList.Count == 0)
            {
                return;
            }
            imageIndex++;
            if (imageIndex > imageFaceList.Count - 1)
            {
                imageIndex = 0;
            }
            imgWorker.Source = imgWorker.Source = GetBitmapImageFromJPG(imageFaceList[imageIndex]);
        }

        private void btnBackImage_Click(object sender, RoutedEventArgs e)
        {
            if (imageFaceList.Count == 0)
            {
                return;
            }
            imageIndex--;
            if (imageIndex < 0)
            {
                imageIndex = imageFaceList.Count - 1;
            }
            imgWorker.Source = imgWorker.Source = GetBitmapImageFromJPG(imageFaceList[imageIndex]);
        }

        public static byte[] GetJPGFromBitmapImage(BitmapImage bitmapImage)
        {
            MemoryStream memoryStream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
            encoder.Save(memoryStream);
            return memoryStream.ToArray();
        }

        public static BitmapImage GetBitmapImageFromJPG(byte[] jpg)
        {
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = new MemoryStream(jpg);
            bitmapImage.EndInit();
            bitmapImage.Freeze();
            return bitmapImage;
        }
    }
}
