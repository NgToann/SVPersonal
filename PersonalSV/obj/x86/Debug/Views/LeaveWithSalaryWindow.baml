   M S B A M L   `   `   `  ����E  APersonalSV, Version=1.0.0.9, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonalSV.ViewsPersonalSV.Views  5   	   ,    &PersonalSV.Views.LeaveWithSalaryWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PersonalSV.Views     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   6   $��13(�6[      titleLeaveWithSalaryWindow � Title# �   5   	   $	��500��6J   $	��780��6Z   .��5      � $��2q�6    � ColumnDefinitions 5	   
   �� 5
      $
��auto �6   �� 5      $��5 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��5 �6   �� 5      �� 5      $��2* �6   �� 5      $
��auto �6   .+�5   
   ��   GroupBoxTemplate#���  6   $��5��6M   ��5      �� 5        Background1#���  6     BorderStyle#���  6P   ._�5      ��   commonGroupBoxLine#���  6    5      .��5      �  5      �� 5      �� 5      $��5 �6$   �� 5      $
��Auto �6$   .+�5!      R� -   5         R�Name$ treeDepartments��5!      
������ 5"      � 5#      $��2��6    5$      �� 5%      $
��auto �6(   �� 5&       5(      �� 5)      �� 5*      $��5 �6+   �� 5+      $
��Auto �6+   .+�5-      ��   commonEmployee#���  6    �� 5.      -   5         ��Name$ txtEmployeeSearch��5.   +   $��1��6   
���   �$��18(�6�   $��3,2,2,2q�6�   $��SemiBold"�6�   $��Center=�6�   6�   �� 5/      -   5         ��Name$ 	btnSearch��5/   :   $��1��6   $��2��6*     ButtonTemplate#���  6M   ��50      �� 51      $��1��6$   $��16��64   $��16��6?   $��/Images/pointer.png��6K   53      54      55      56      �� 57   
   $��2��6   #���  6#   ��58      �� 59      #���  6   #���  6P   ._�5:      ��  , (commonGroupBoxLeaveWithSalaryInformation#���  6    5;      .��5=      � -   5         �Name$ gridOTInfor��5=       5>      �� 5?      �� 5@      $��5 �6'   �� 5A      �� 5B      $��5 �6'   �� 5C       5E      �� 5F      $
��auto �6$   �� 5G      $
��auto �6$   �� 5H      $
��auto �6$   �� 5I      $
��auto �6$   .+�5K      ��   commonDatePickerFrom#���  6   $��Bottom=�6V   (  "System.Windows.Controls.DatePicker  5L      -   5          Name$ 
dpDateFrom��5L   *   $��1��6   $��1��6>   $��0.5,0.5,0.5,0.5q�6K   �� 5N      $��2��6    	 commonDatePickerTo#��� 	 6,   $��0,5,0,0q�6d     5O      -   5        $ dpDateTo��5O   :   $��1��6   $��2��6*   $��2��6L   $��0.5,0.5,0.5,0.5q�6Y   �� 5Q      $��2��6    
 commonTextBlockSalaryRate#��� 
 6)   $��0,5,0,0q�6h   
���  ��$��SemiBold"�6�   $��Italic$�6�   �� 5R      -   5        $ txtSalaryRate��5R      $��3��61   
���   �$	��100��6R   	 �� 	MaxLength$	 3��6]   $��3��6k   $��3q�6x   $��Center=�6�   ��6�   �� 
 �� ElementName$
 
dpDateFrom�� �� Path$ ActualHeight�6�   5S      5T      &   System.Windows.Controls.DataGrid  5U   
   -	   5          Name$ dgEmployeePerDepartment��5U   A   $��2��6   $��2��6#   $��2��60      AutoGenerateColumns .   �� AlternationCount$ 2��6~      AlternatingRowBackground
 �����   CanUserAddRows .     SelectionUnit$ FullRow=�5V   .      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   RowHeaderWidth$	 NaNQ�6�      
IsReadOnly . $��Times New Roman)�5W   )   $��14(�6F   $��5��6�    � ContextMenu 5X      �� 5Y      .@�5Z      m� -
   5         m�Name$ miRemove��5Z        commonMenuItemRemove#���  61   5[      5\       � 	Resources 5^      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '        �� 5_      "  6    5`      P� 5a       �@ 
IsSelected . . �5b      ��  � ��
 ��iA�6;   �� 5c       � ��
 �����6;   5d      5f      5g         ColumnHeaderStyle 5h      �� 5i      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5j      ��  � ��$ Center=�6C   �� 5k       � ��$ 15(�61   �� 5l       � ��  DataGridRowHeaderBG# �  63   �� 5m       � ��
 �����64   �� 5n       � ��$ 0.5,0.5,0.5,0q�68   �� 5o       � ��$ 5q�60   5p          Columns  5r      4  .System.Windows.Controls.DataGridTemplateColumn  5s        commonEmployeeCode,  &System.Windows.Controls.DataGridColumn!   Header#! �  6)   "   SortMemberPath$" EmployeeCode��6c   #   ClipboardContentBinding# 6�   �� *EmployeeCode+$   CellTemplate$ 5t      �� 5u      .R�5v      �� $��3q�6F   $��Center=�6Q   $��Center=�6l   ��6(   �� *EmployeeCode+6l   5w      5y        5z        commonEmployeeID#! �  6)   $" 
EmployeeID��6a   # 6}   �� *
EmployeeID+$ 5{      �� 5|      .R�5}      �� $��3q�6D   $��Center=�6O   $��Center=�6j   ��6(   �� *
EmployeeID+6j   5~      5�        5�        commonEmployeeName#! �  6)   $" EmployeeName��6c   # 6�   �� *EmployeeName+$ 5�      �� 5�      .R�5�      �� $��3q�6F   $��Center=�6Q   % �� Padding$% 3,0,0,0q�6l   ��6(   �� *EmployeeName+6l   5�      5�        5�        commonEmployeeDepartment#! �  6)   $" DepartmentName��6i   # 6�   �� *DepartmentName+$ 5�      �� 5�      .R�5�      �� $��3q�6H   $��Center=�6S   $% 3,0,0,0q�6n   ��6(   �� *DepartmentName+6n   5�      5�      5�      � 5�   
   $��4��6   $��4��6   $��0,5,0,0q�6,    5�      �� 5�      $��2* �6#   �� 5�      �� 5�      $��10 �6#   �� 5�      .+�5�      �� -   5        & ��Name$& txtTotal��5�      $	��Top=�6*   
����  �$��Italic$�6T   �� 5�      -   5        $ 	btnDelete��5�      $��8��6(   $��1��65   #���  6E   ��5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� $��16��6    $��16��6+   $��/Images/edit_remove.png��67   �� 5�      $��2,0,0,0q�6$   $��1��65   $��Center=�6E     commonButtonDelete#���  6`   5�      5�      �� 5�      -   5        $ btnSave��5�      $��8��6&   $��3��63   #���  6C   ��5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� $��16��6    $��16��6+   $��/Images/filesave.png��67   �� 5�      $��2,0,0,0q�6$   $��1��65   $��Center=�6E     commonButtonSave#���  6`   5�      5�      5�      5�      5�      