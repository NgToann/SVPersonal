   M S B A M L   `   `   `  ����g  cMicrosoft.ReportViewer.WinForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3atSclr-namespace:Microsoft.Reporting.WinForms;assembly=Microsoft.Reportviewer.WinFormsMicrosoft.Reporting.WinForms  5   	    
PersonalSV4   .PersonalSV.Views.WorkingDaySummaryReportWindow   [rpvSclr-namespace:Microsoft.Reporting.WinForms;assembly=Microsoft.Reportviewer.WinForms  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5        $��13(�5   @     � WindowState$  	Maximized=�6e       titleWorkingDaySummaryWindow � Title# �   5   	   $	��400��6L   $	��700��6\    � WindowStartupLocation$ CenterScreen=�6k   .��5      � $��2q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5	      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   ��   GroupBoxTemplate#���  6   ��5      �� 5        Background1#���  6     BorderStyle#���  6P   ._�5      ��  & "commonGroupBoxSearchingInformation#���  6    5      .��5      �  5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$    5      �� 5      �� 5       $��5 �6'   �� 5!      �� 5"      $
��auto �6'   .+�5$      ��   commonEmployee#���  6   $��Bottom=�6P   �� 5%      -   5         ��Name$ txtEmployeeSearch��5%   ;   $��1��6   $��3��6'   
���   �$��15(�6�   $��Center=�6�   6�   �� 5'      -   5         ��Name$ 
cboSection��5'   M   $��2��6   $��3��6(   $��0,5,0,0q�6<    �� DisplayMemberPath$ DepartmentName��6a   $��Center=�6�   5(      �� 5)      -   5        $ cboDepartment��5)   M   $��3��6   $��3��6(   $��0,5,0,0q�6<   $ DepartmentFullName��6d   $��Center=�6�   �� 5+      $��4��6     commonDatePickerFrom#���  6)   $��Bottom=�6c   (  "System.Windows.Controls.DatePicker  5,      -   5          Name$ 
dpDateFrom��5,   *   $��5��6   6*   �� 5-      $��4��6   $��2��6)     commonDatePickerTo#���  69   $��0,5,0,0q�6q     5.      -   5        $ dpDateTo��5.   :   $��5��6   $��2��6*   6:   �� 5/      -   5        	 ��Name$	 
btnPreview��5/   Y   $��3��6   $��6��6)   $��5,0,0,0q�6:   $��78��6K     ButtonTemplate#���  6m   ��50      � 51       52      �� 53   "   $
��auto �60   �� 54   "   $
��auto �60   .+�56      �� $��16��6$   $��16��6/   $��/Images/update.png��6;   �� 57      $��2,0,0,0q�6(   $��1��69   $��Center=�6F    	 commonButtonPreview#��� 	 6a   58      5:      5;      5<      7  1System.Windows.Forms.Integration.WindowsFormsHost  5=   
   $��1��6   $��2��6(   $��0,5,0,0q�6<   
   Child.
 5>      /   )Microsoft.Reporting.WinForms.ReportViewer  -   5        reportViewer��   ShowFindControls .  5>   5   5?      5@      5A      