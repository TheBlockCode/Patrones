   M S B A M L   `   `   `  ����D  @DBej6MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:DBej6MVVM	DBej6MVVM  5   	       DBej6MVVM.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:DBej6MVVM     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      ]� .+�5
   
   �� -   5         ��Name$ LoadBTN��5
      $
��Load��6"   61   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	DataGrid1��5         AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6[   $	��782��6k      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
CategoryID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *
CategoryID+  5      $ CategoryName��6%    6;   �� *CategoryName+  5      $ Description��6%    6:   �� *Description+4  .System.Windows.Controls.DataGridTemplateColumn  5         HeaderTemplate 5      �� 5      .R�5      �� $��Hello��6(   5      	   CellTemplate	 5      �� 5      .R�5      �� 
 �� Orientation$
 
Horizontal=�6)   .+�5   "   �� $ 	UpdateBTN��6)   -   5        $��Update��5   <   6M   5      5      5      5!      5"      5#      