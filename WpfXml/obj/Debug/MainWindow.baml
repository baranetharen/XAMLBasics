   M S B A M L   `   `   `  ����A  =WpfXml, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfXml.ControlsWpfXml.Controls  5   	   3clr-namespace:WpfXml.ConverterWpfXml.Converter  5   	       WpfXml.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2Controlsclr-namespace:WpfXml.Controls     5   	   4	converterclr-namespace:WpfXml.Converter     5   	     � Title$  
MainWindow��5	   	   $	��409��6   $��543.5��6)    � 	Resources 5
      *   $WpfXml.Converter.VisibilityConverter   boolConverter��%   &	          5   
   6(   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6    �� 5      �� 5      $
��Auto �6     � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��3��6   ���#F05A28 �� Orientation$ 
Horizontal=�6>   .+�5      �� $��Images/logo.png��6   $��50��6-   �� 5       	 Title#��[ 6   
�������$��30(�5      $��	ExtraBold"�5      $��Bottom=�5      $��20q�5      �� 5      $��Version 1.0��6   ���#333333$��Bottom=�5!      $��25q�5"      5#      � 5$   
   -   5         �Name$ Control_pannel��5$      $��1��6'   ���#EEEEEE 5%      �� 5&      $
��Auto �6    �� 5'      $��* �6    .+�5)      �� $ 
Horizontal=�6   .+�5*      �� -   5         ��Name$ add_btn��5*      $��5q�6*   $��39��6H   ��5+      �� 5,      $	��Add��6$   $��Center=�6/   $��1 0 0 0 q�5-   !   5/      �� 50      -   5        $ del_btn��50      $��5q�6*   $��25��65   .��51      �� $��Delete��6    $��Center=�6.   $��1,0,0,0q�52   !   $��40��62   $��26��6=   53      �� 54      -   5        $ nav_btn��54      $��5q�6*   $��30��65   .��55      �� $	��Nav��6    $��Center=�6+   $��1,0,0,0q�56   !   $��42��62   $��20��6=   57      58      59      �� 5:      -   5         ��Name$ 	cust_list��5:   $   $��1��6   ���#EEEEEE �� SelectedItem 5;      �� *SelectedCustomer+	 �� Mode$	 TwoWay=���5<      �� 
 �� Path$
 	Customers���5=      �� 5>      .R�5?      �� $ 
Horizontal=�6%   $��5q�6>   .+�5@      �� $
��Bold"�6C   ��6(   �� *	FirstName+6C   �� 5A      $��2 0 0 0q�6B   ��6(   �� *
LastName+6B   �� 5B      $��(IsDeveloper)��6(   y�6=   �� *IsDeveloper+ �� 	Converter# [  5C      5D      5F      5G      )   #WpfXml.Controls.CustomerUserControl  5H   
   $��1��6'   $��5q�64   $��1��6?      Customer 5I   *   �� *SelectedCustomer+5K      5L      