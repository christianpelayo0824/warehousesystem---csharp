   M S B A M L   `   `   `  ����  WarehouseSystem#    WarehouseSystem.ProductWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    6*   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6l   @d2http://schemas.microsoft.com/expression/blend/2008     5	      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6V     � Title$  WarehouseSystem��5       � WindowStartupLocation$ CenterScreen=�5       � 
ResizeMode$ NoResize=�5      $	��600��5      $
��1000��5      ���	#FF333333.��5      � .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ product_DataGrid��5      $	��523��5         RowBackground �	#FF37474F   HorizontalGridLinesBrush �	#FF37474F   VerticalGridLinesBrush �	#FF37474F   AlternatingRowBackground �	#FF455A64   GridLinesVisibility$
 None=�5      $��Center=�5      $��Center=�5      |�.  $��15(�5      	   ColumnHeaderHeight$	 30Q�5      $��0,0,0,0q�5      
 J� OpacityMask
 �	#FF333333 � OverridesDefaultStyle .     HeadersVisibility$ Column=�5      {�.    
IsReadOnly . $��Normal"�5         SelectionMode$ Extended=�5       "   VerticalScrollBarVisibility$
 Auto=�5!      $   HorizontalScrollBarVisibility$
 Auto=�5"      ���	#FF37474F���	#FF37474F���	#FF90A4AE$	��650��5&      $��0��5'      $��0��5(      $
��Left=�5)      $	��Top=�5*      $��323,22.5,0,0q�5+      �� 5,      -   5         ��Name$ productCode_Textbox��51      $��30��5-      $��0,0,0,1q�5.      ���	#FF03A9F4$	��270��50      $��13(�52      $��Light"�53      ���	#FFF7F7F7���	#FF333333$��Center=�56      $��0��57      $��0��58      $
��Left=�59      $	��Top=�5:      $��
20,110,0,0q�5;      �� 5<      
�������$��13(�5>      $��30��5?      $��95��5@      $��Product Code��5A      $��SemiBold"�5B      $��0��5C      $��0��5D      $
��Left=�5E      $	��Top=�5F      $��
106,72,0,0q�5G      � 5H      -   5         �Name$ search_Button��5N      $��30��5I      $	��270��5J      ���	#FF2196F3$��0��5P      $��0��5Q      $
��Left=�5R      $��Bottom=�5S      $��
19,0,0,382q�5T      .+�5U      �� 
�������$��13(�5W      $��SemiBold"�5X      $��30��5Y      $��0��5Z      $��0��5[      $	��Top=�5\      $��61��5]      $��Right=�5^      $��0,0,88,0q�5_      $��SEARCH��5`      �� 5a      $��20��5b      $��20��5c      $��0��5d      $��2��5e      $��0��5f      $
��Left=�5g      $	��Top=�5h      $��	236,5,0,0q�5i      $r��lC:\Users\chris\OneDrive\Documents\SharpDevelop Projects\WarehouseSystem\WarehouseSystem\img\Search_100px.png��5j       � ColumnDefinitions 5k      �� 5l      $��0.935460657009017* �5m      �� 5n      $��0.0645393429909825* �5o      5q      � 5r      ���	#FFFF5722$��
315,22,0,0q�5t      $	��Top=�5u      $
��Left=�5v      $��0��5w      $��0��5x      $	��523��5y      $��8��5z      5{      5|      