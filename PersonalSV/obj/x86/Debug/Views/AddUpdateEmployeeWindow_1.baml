   M S B A M L   `   `   `  ����E  APersonalSV, Version=1.0.0.9, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonalSV.ViewsPersonalSV.Views  5   	   0    *PersonalSV.Views.AddUpdateEmployeeWindow_1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PersonalSV.Views     5   	   -   5        $��14(�5        � WindowStartupLocation$  CenterScreen=�6(    #  titleCreateUpdateEmployeeWindow � Title# �   5   	   $	��500��6O   $	��800��6_    � SizeToContent$ WidthAndHeight=�6n   .��5	      � -   5         �Name$ gridMain��5	      $��2q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��5 �6   �� 5      $
��Auto �6   �� 5      $��5 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��5 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��2��6     GroupBoxTemplate#���  6'   ��5      �� 5        Background1#���  6     BorderStyle#���  6P   ._�5      ��   commonGroupBoxImage#���  6    5      .��5      �  5       �� 5!      $��* �6$   �� 5"      $
��auto �6$   .+�5$      �� -   5         ��Name$ 	imgWorker��5$      $��/Images/noimage.png��6+   $	��200��6H   $	��200��6T   $
��Fill=�6a   �� 5%      $��1��6    �� Orientation$ 
Horizontal=�6*   $��Center=�6C   $��0,2,0,0q�6`   .+�5&      �� -   5         ��Name$ btnBackImage��5&      $��26��63   $��0,0,0,2q�6>   {�.  ��5'      �� 5(      $��/Images/btn_back.png��6$   $��20��6B   $��20��6M   $
��Fill=�6Y   5*      �� 5+      -   5        $ btnNextImage��5+      $��26��63   $��0,0,0,2q�6>   $��2,0,0,0q�6P   {�.  ��5,      �� 5-      $��/Images/btn_next.png��6$   $��20��6B   $��20��6M   $
��Fill=�6Y   5/      50      51      52      �� 53   
   $��3��6   $��3��6#   #���  67   ��54      �� 55      #���  6   #���  6Q   ._�56      ��  % !commonGroupBoxEmployeeInformation#���  6    57      .��59      �  5:      �� 5;      $
��auto �6$   �� 5<      $
��auto �6$   �� 5=      $
��auto �6$   �� 5>      $
��auto �6$   �� 5?      $��* �6$   �� 5@      $
��auto �6$   �� 5A      $
��auto �6$    5C      �� 5D      $��2* �6'   �� 5E      $��3* �6'   .+�5G      ��   commonEmployeeName#���  6   $��0,5,0,0q�6T   $��Center=�6e   $��SemiBold"�6�   �� 5H      -   5        	 ��Name$	 txtEmployeeName��5H      $��1��6Q   $��SemiBold"�6a   $��3,0,0,0q�6w   $��Center=�6�   ��63   �� *EmployeeName+��6�   �� 
 �� ElementName$
 cbDepartment�� �� Path$ ActualHeight�6�   �� 5J        commonEmployeeGender#���  6   $��1��6V   $��0,5,0,0q�6c   $��Center=�6t   � 5L      $��1��6   $��1��6'   $��0,5,0,0q�65    5M      �� 5N      �� 5O      .+�5Q      	� -   5         	�Name$ radWoman��5Q   "     commonEmployeeGenderWoman#���  64    	 RadioBlueStyle#��� 	 6v    	� 	GroupName$ Gender��6�   $��Center=�6�    d� 	IsChecked 6�   �� *GenderWoman+	� 5R      -   5        $ radMan��5R   "   $��1��62    
 commonEmployeeGenderMan#��� 
 6B   #��� 	 6�   $ Gender��6�   $��Center=�6�    6�   �� *	GenderMan+5S      �� 5U        commonEmployeeDayOfBirth#���  6   $��2��6Z   $��0,5,0,0q�6g   $��Center=�6x   (  "System.Windows.Controls.DatePicker  5V      -	   5          Name$ dpDayOfBirth��5V      $��2��63   $��1��6@   $��0,5,0,0q�6P   $��3,0,0,0q�6�   $��Center=�6�      SelectedDate 6a   �� *
DayOfBirth+��6�   �� $
 cbDepartment��$ ActualHeight�6�   �� 5X        commonEmployeeNationID#���  6   $��3��6X   $��0,5,0,0q�6e   $��Center=�6v   $��SemiBold"�6�   �� 5Y      -
   5        $	 txtNationID��5Y      $��3��6I   $��1��6V   $��0,5,0,0q�6f   $��3,0,0,0q�6w   $��Center=�6�   ��6/   �� *
NationID+��6�   �� $
 cbDepartment��$ ActualHeight�6�   �� 5[        commonEmployeeAddress#���  6   $��4��6W   $��0,5,0,0q�6d   $	��Top=�6u   �� 5\      -   5        $	 
txtAddress��5\      $��4��6G   $��1��6T   $��0,5,0,0q�6d    �� TextWrapping$
 Wrap=�6u   $��3,0,0,0q�6�   ��6.   �� *	Address+6�   �� 5^        commonEmployeePhoneNumber#���  6   $��5��6[   $��0,5,0,0q�6h   $��Center=�6y   �� 5_      -   5        $	 txtPhoneNumber��5_      $��5��6O   $��1��6\   $��0,5,0,0q�6l   $��3,0,0,0q�6}   $��Center=�6�   ��62   �� *PhoneNumber+��6�   �� $
 cbDepartment��$ ActualHeight�6�   �� 5a      $	��ATM��6   $��6��6'   $��0,5,0,0q�64   $��Center=�6E   �� 5b      -   5        $	 txtATM��5b      $��Center=�6~   $��6��6�   $��1��6�   $��0,5,0,0q�6�   $��3,0,0,0q�6�   ��6*   �� *ATM+��6?   �� $
 cbDepartment��$ ActualHeight�6�   5c      5d      �� 5e   
   $��2��6   $��3��6    $��3��60   #���  6D   ��5f      �� 5g      #���  6   #���  6P   ._�5h      ��  , (commonGroupBoxCardSectionLineInformation#���  6    5i      .��5k      �  5l      �� 5m      $
��auto �6$   �� 5n      $
��auto �6$   �� 5o      $
��auto �6$   �� 5p      $
��auto �6$   �� 5q      $
��auto �6$    5s      �� 5t      $��2* �6'   �� 5u      $��3* �6(   .+�5w      ��   commonEmployeeCode#���  6   $��Center=�6T   $��SemiBold"�6o   �� 5x      -   5        $	 txtEmployeeCode��5x   {   $��Center=�6Y   $��1��6�   {�.   �� 	MaxLength$ 10��6�   $��3,0,0,0q�6�   ��6   �� $
 cbDepartment��$ ActualHeight���6�   �� *EmployeeCode+6�   �� 5y        commonEmployeeID#���  6   $��1��6R   $��0,5,0,0q�6_   $��Center=�6p   $��SemiBold"�6�   �� 5z      -   5        $	 txtEmployeeID��5z   {   $��Center=�6Y   $��1��6�   $��1��6�   $��0,5,0,0q�6�   $
��Bold"�6�   
���  ��$��3,0,0,0q�6�   ��6   �� $
 cbDepartment��$ ActualHeight���6�   �� *
EmployeeID+6�   �� 5{        commonEmployeeDepartment#���  6   $��2��6Z   $��0,5,0,0q�6g   $��Center=�6x   �� 5|      -   5         ��Name$ cbDepartment��5|      $��2��61   $��1��6>   $��0,5,0,0q�6N    �� DisplayMemberPath$ DepartmentFullName��5}       �� SelectedValue$ DepartmentID��5~       �� SelectedItem 5      �� *DepartmentSelected+5�      �� 5�        commonEmployeePosition#���  6   $��3��6X   $��0,5,0,0q�6e   $��Center=�6v   �� 5�      -   5        $ 
cbPosition��5�      $��3��6/   $��1��6<   $��0,5,0,0q�6L   $ PositionName��5�      $ PositionName��5�       5�      �� *PositionSelected+5�      �� 5�        commonEmployeeJoinDate#���  6   $��4��6X   $��0,5,0,0q�6e   $��Center=�6v   $��SemiBold"�6�     5�      -   5        $ 
dpJoinDate��5�   ~   $��Center=�6\   $��4��6�   $��1��6�   $��0,5,0,0q�6�   $��3,0,0,0q�6�   ��6   �� $
 cbDepartment��$ ActualHeight� 6�   �� *
JoinDate+6�   5�      5�      �� 5�   
   $��2��6   $��2��6    #���  64   ��5�      �� 5�      #���  6   #���  6P   ._�5�      ��   commonGroupBoxOther#���  6    5�      .��5�      �  5�      �� 5�      $
��auto �6$   �� 5�      $��* �6$   .+�5�      ��   commonEmployeeRemark#���  6   $	��Top=�6V   $��Italic$�6n   
����  �6�   �� 5�      $��1��62   $
 Wrap=�6?   
����  �$��1,1,1,1q�6f   $��3,0,0,0q�6�   ��6   �� *Remark+6�   5�      5�      �� 5�   
   -   5        $ btnSave��5�      $��30��6"   $��Bottom=�6.   $��4��6I   $��5,0,0,0q�6V   $��5��6g     ButtonTemplate#���  6w   ��5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� $��16��6   $��16��6'   $��/Images/filesave.png��63   �� 5�      $��2,0,0,0q�6    $��1��61   $��Center=�6A     commonButtonSave#���  6\   5�      5�      �� 5�   
   -   5        $ 	btnDelete��5�      $��30��6$   $��Bottom=�60   $��4��6K   $��4��6X   {�.  #���  6z   ��5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� $��16��6   $��16��6'   $��/Images/edit_remove.png��63   �� 5�      $��2,0,0,0q�6    $��1��61   $��Center=�6A     commonButtonDelete#���  6\   5�      5�      5�      5�      