   M S B A M L   `   `   `  ����G  CКурсач, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:КурсачКурсач  5   	       Курсач.AdminGostWin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Курсач     5   	     � Title$  AdminGostWin��5   	   $	��450��6   $	��800��6+    � WindowStartupLocation$ CenterScreen=�67    � Icon$ Image/икона.PNG��6\    � 	Resources 5	       �� 
TargetType   bt1 �� Property �� Value��%�  &	        '�� `    �� 5
   
   " ��6   .�5      ��  � �� �#FFFF6+   �� 5       � ��$ 	Tw Cen MT)�6+   �� 5       � ��$ 19(�6)   �� 5       � ��$ 30��6'   �� 5       � ��$	 250��6&   �� 5       � �� �	#FFB2B6DC6+   �� 5       � �� �	#FFB2B6DC6,   �� 5       � ��$ 15q�6'   5      �� 5   
   " ��6   .�5      ��  � �� �	#FFB2B6DC6+   �� 5       � ��$ 	Tw Cen MT)�6+   �� 5       � ��$ 19(�6)   �� 5       � ��$ 25��6'   �� 5       � ��$	 100��6&   �� 5       � ��
 �����6+   �� 5       � �� �	#FFB2B6DC6,   �� 5       � ��$ 5q�6'   5      5      .��5      �  � RowDefinitions 5    
   �� 5!      $��35 �6   �� 5"      �� 5#      $��35 �6   .+�5%   
   �� $��0��6   ���	#FFB2B6DC.+�5&      �� -   5        $��Right=�5&      .��6H   
Назад5(      5)      �� 5,   
   $��1��6    �� Orientation$ Vertical=�6"   $��Center=�69   $	��Top=�6V   .+�5-      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 DataG_Users��5-      $	��300��6,   
   AutoGenerateColumns
 .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6U      Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Логин��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *login+6T     50      $ Пароль��6)    69   �� *
password+6X     51      $ Роль��6)    67   �� *role+6R   53      54      �� 55   
   $��2��6   $ 
Horizontal=�6"   ���	#FFB2B6DC57      58      59      