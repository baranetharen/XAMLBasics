   M S B A M L   `   `   `  ����A  =WpfXml, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfXml.ControlsWpfXml.Controls  5      )    #WpfXml.Controls.CustomerUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfXml.Controls     5      -   5          >�Name$
  Root��5   7   .��5
      �� .+�5   
   �� $��10q�6    �� Orientation$ 
Horizontal=�6"   .+�5      �� 
First Name6$   �� 5         inputControlsStyle#��[  6   ��6B   ��  �� ElementName$
 Root�� �� Path$ Customer.FirstName� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5   
   $��10q�6   $ 
Horizontal=�6#   .+�5      �� 	Last Name6#   �� 5      #��[  6   ��5      �� $
 Root��$ Customer.LastName�$ TwoWay=�$ PropertyChanged=�5      �� 5   
   $��10q�6   $��IsDeveloper��6!    d� 	IsChecked 5      �� $
 Root��$ Customer.IsDeveloper�$ TwoWay=�$ PropertyChanged=�5      5      