   M S B A M L   `   `   `  ����@  <TRPO3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TRPO3TRPO3  5   	       TRPO3.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:TRPO3     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
MainWindow��5	   	   $	��400��6   $	��600��6)    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � 
ResizeMode$ NoResize=�5   	   $��18(�5   	      MaterialDesignFont#���   5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   � ��5      �� 5       �� ImageSource$ /Images/fon.jpg��6   5      '  !MaterialDesignThemes.Wpf.PackIcon  5   
   -   5           Kind$ Close=�5   "   $	��Top=�6/   $��20��6G   $��20��6R   $��Right=�6^   $��1��6z   6�   �� 5   
   $��1��6   $��
15 20 15 0q�6&   .@�5      �� $��Вход��6   .��5      ��  �� Orientation$ Vertical=�6   $
��0 25q�64   .+�5      �� ���	#FF4C4731$��19(�5        42Введите свой логин и пароль6K   �� 5!      -   5        	 ��Name$	 
sign_in_TB��5&       % !MaterialDesignFloatingHintTextBox#��[ 5!      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Login��5"         FloatingOffset$ 0 -20&�5#      ���	#FF4C4731$��	0 0 0 1.5q�5%      $��
20,25,20,0q�6:   5&   4   G� 5(      -   5         G�Name$ sign_in_PassBox��5.       ) %MaterialDesignFloatingHintPasswordBox#��[ 5)      $
 Password��5*      $ 0 -20&�5+      ���	#FF4C4731$��	0 0 0 1.5q�5-      $
��20 5q�6:   5.   9   �� 50      -   5        $	 visible_pas_TB��56      #��[ 50      $
 Password��51      $ 0 -20&�52      ���	#FF4C4731$��	0 0 0 1.5q�54      $y�	Collapsed=�55      $
��20 5q�66   56   8   �� 58      -   5         ��Name$ pas_vis_Check��58   F   ���	#FF4C4731$��20 15q�67   .��6�   Показать пароль6�   �� 5:      -   5         ��Name$ 
signIn_Btn��5>      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5:      
�������$��20(�5<      $��20 15q�5=      .��5>   J   
Войти5@      5A      5B      �� 5D      $��Регистрация��6   .��5E      �� $ Vertical=�6   .+�5F      �� ���	#FF4C4731$��19(�5G       $
��0 25q�5H       1/Придумайте логин и пароль6I   �� 5I      -   5        $	 	signUp_Tb��5N      #��[ 5I      $
 Login��5J      $ 0 -20&�5K      ���	#FF4C4731$��	0 0 0 1.5q�5M      $
��20 0q�6:   5N   3   G� 5P      -   5        $ signUp_PassBox��5V      #��[ 5Q      $
 Password��5R      $ 0 -20&�5S      ���	#FF4C4731$��	0 0 0 1.5q�5U      $
��20 5q�6:   5V   8   �� 5X      -	   5        $	 vis_signUp_Tb��5^      #��[ 5X      $
 Password��5Y      $ 0 -20&�5Z      ���	#FF4C4731$��	0 0 0 1.5q�5\      $y�	Collapsed=�5]      $
��20 5q�66   5^   7   G� 5_      -
   5        $ signUp_PassBox2��5e      #��[ 5`      $
 Password��5a      $ 0 -20&�5b      ���	#FF4C4731$��	0 0 0 1.5q�5d      $
��20 5q�6:   5e   9   �� 5g      -   5        $	 vis_signUp_Tb2��5m      #��[ 5g      $
 Password��5h      $ 0 -20&�5i      ���	#FF4C4731$��	0 0 0 1.5q�5k      $y�	Collapsed=�5l      $
��20 5q�66   5m   8   �� 5o      -   5        ���	#FF4C4731$
��20 5q�5o   7   .��6�   Показать пароль6�   �� 5q      -   5        $ 
signUp_Btn��5u      $ 10��5q      
�������$��20(�5s      $
��20 5q�5t      .��5u   J   &$Зарегистрироваться5w      5x      5y      5z      5{      5|      