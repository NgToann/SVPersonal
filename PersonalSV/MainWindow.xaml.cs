﻿using System;
using System.Windows;
using System.Windows.Threading;

using PersonalSV.Helpers;
using PersonalSV.Views;
using PersonalSV.Models;

namespace PersonalSV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer clock;
        AccountModel account;
        public MainWindow(AccountModel account)
        {
            this.account = account;
            clock = new DispatcherTimer();
            clock.Tick += Clock_Tick;
            clock.Start();

            InitializeComponent();
            lblUserName.Text = string.Format("User: {0}", account.FullName);
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            Dispatcher.Invoke(new Action(() => {
                lblTimer.Text = string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            }));
        }

        private void miAddUpdateEmployee_Click(object sender, RoutedEventArgs e)
        {
            //AddUpdateEmployeeWindow window = new AddUpdateEmployeeWindow();
            //window.Show();
        }

        private void miSettingsLanguage_Click(object sender, RoutedEventArgs e)
        {
            SettingLanguageWindow window = new SettingLanguageWindow();
            window.ShowDialog();
        }

        private void miChangeCard_Click(object sender, RoutedEventArgs e)
        {
            ChangeEmployeeCodeWindow_1 window = new ChangeEmployeeCodeWindow_1();
            window.ShowDialog();
        }

        private void miCheckingRecordTime_Click(object sender, RoutedEventArgs e)
        {
            AttendanceRecordDetailWindow window = new AttendanceRecordDetailWindow();
            window.Show();
        }

        private void miAddRecordTime_Click(object sender, RoutedEventArgs e)
        {
            AddRecordTimeWindow window = new AddRecordTimeWindow();
            window.Show();
        }

        private void miArrangeWorkingShift_Click(object sender, RoutedEventArgs e)
        {
            ArrangeWorkingShiftWindow window = new ArrangeWorkingShiftWindow();
            window.Show();
        }

        private void miExcuteDataSalary_Click(object sender, RoutedEventArgs e)
        {
            ExecuteDataSalaryWindow window = new ExecuteDataSalaryWindow();
            window.ShowDialog();
        }

        private void miOverTimeLimit_Click(object sender, RoutedEventArgs e)
        {
            LeavWithSalaryWindow window = new LeavWithSalaryWindow();
            window.Show();
        }

        private void MiAttendanceDetail_Click(object sender, RoutedEventArgs e)
        {
            AttendanceRecordDetailWindow window = new AttendanceRecordDetailWindow();
            window.Show();
        }

        private void miWorkingTime_Click(object sender, RoutedEventArgs e)
        {
            AddRecordTimeWindow window = new AddRecordTimeWindow();
            window.Show();
        }

        private void miWorkingShiftList_Click(object sender, RoutedEventArgs e)
        {
            WorkingShiftListWindow window = new WorkingShiftListWindow();
            window.Show();
        }

        private void miEmployeeList_Click(object sender, RoutedEventArgs e)
        {
            EmployeeListWindow window = new EmployeeListWindow();
            window.Show();
        }

        private void miDailyReport_Click(object sender, RoutedEventArgs e)
        {
            DailyReportWindow window = new DailyReportWindow();
            window.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            //Application.Current.Shutdown();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show(string.Format("{0}", LanguageHelper.GetStringFromResource("messageConfirmClosing")), this.Title, MessageBoxButton.OKCancel, MessageBoxImage.Question) != MessageBoxResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void miSalarySummaryReport_Click(object sender, RoutedEventArgs e)
        {
            WorkingDaySummaryReportWindow window = new WorkingDaySummaryReportWindow();
            window.Show();
        }

        private void miAboutMe_Click(object sender, RoutedEventArgs e)
        {
            AboutMeWindow window = new AboutMeWindow();
            window.Show();
        }

        private void miLine_Click(object sender, RoutedEventArgs e)
        {
            LineListWindow window = new LineListWindow();
            window.Show();
        }

        private void miReport2020_Click(object sender, RoutedEventArgs e)
        {
            Report2020Window window = new Report2020Window();
            window.Show();
        }

        private void miLeaveWithSalary_Click(object sender, RoutedEventArgs e)
        {
            LeaveWithSalaryWindow window = new LeaveWithSalaryWindow();
            window.Show();
        }
    }
}
