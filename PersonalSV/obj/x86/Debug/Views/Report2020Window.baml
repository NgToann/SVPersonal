   M S B A M L   `   `   `  ����E  APersonalSV, Version=1.0.0.9, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonalSV.ViewsPersonalSV.Views  5   	   '    !PersonalSV.Views.Report2020Window   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PersonalSV.Views     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5       � Title$ Report 2020��5   	   $	��450��6   $	��800��6*   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgReport��5
         AutoGenerateColumns .   �� AlternationCount$ 2��6A      AlternatingRowBackground
 �����   CanUserSortColumns .    CanUserAddRows .     SelectionUnit$
 Cell=�5   .   	   HorizontalGridLinesBrush
	 �����
   VerticalGridLinesBrush

 �����   
IsReadOnly . $��Times New Roman)�5   )   $��14(�6F      FrozenColumnCount$ 4��6T      	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6    �� Triggers 5      P� 5       P� Property �@ 
IsSelected P� Value . . �5      ��  �� Property � �� �� Value
 �   �6;   �� 5       � ��
 ��� �6;   �� 5       � ��$ Semibold"�6;   �� 5       � ��$ 0,0,0,0q�6@   5      5         ColumnHeaderStyle 5      �� 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5      ��  � ��$ Center=�6C   �� 5       � ��$ 15(�61   �� 5       � ��
 �����63   �� 5       � ��
 �����64   �� 5       � ��$ 0.5,0.5,0.5,0q�68   �� 5        � ��$ 8,5,5,8q�60   5!      5#      5$      5%      