   M S B A M L   `   `   `  ����>  :SRB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SRBSRB  5          SRB.EqAccounting   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:SRB     5        N� Title$  EqAccounting��5	      .��5      � .+�5   
    � -   5          �Name$ AccMain��5      $�� ��6!   $
��Left=�6,   $	��587��6G   $	��Top=�6T   $
��1258��6l     � NavigationUIVisibility$ Hidden=�6y   ���	#FF1019216�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ AccountingGrid��5      $
��Left=�6+   $	��542��6F   $��	10,38,0,0q�6S   $	��Top=�6f   $
��1230��6~      
IsReadOnly .    CanUserResizeRows .     CanUserResizeColumns .  $��16(�6�   $��Franklin Gothic Book)�6�   
������ 
���������5      �� 5       �� Color$ 	#FF182834��6"    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader	 �� 
TargetType
 �� Property �� Value)  #System.Windows.Controls.DataGridRow��%q  '        '  �     �� 5      "	  6   .�5      �� 
 � �� �	#FF15222C63   �� 5      
 � ��$ SemiBold"�63   �� 5      
 � ��$ 0,0,0,2q�68   �� 5      
 � ��$ 20(�61   �� 5      
 � ��
 ���� 64   5      �� 5      "	  6   .�5      �� 
 � ��
 ���� 63   �� 5      
 � ��
 �����63   5      5      5      �� 5    
   -   5         ��Name$ AccAdd��5       $?��9Поставить на учёт оборудование��6!   $
��Left=�6J   $	��Top=�6f   $	��255��6~   $��35��6�   ���	#FF9AE4CF$��16(�6�   $��10,0,0,0q�6�   $��Franklin Gothic Book)�6�   
�������6  �� 5!   
   -   5        $ PrintBtn��5!      $��Печать��6#   $
��Left=�64   $	��Top=�6P   $��92��6h   $��35��6s   ���	#FF9AE4CF$��16(�6�   $��
1148,3,0,0q�6�   $��Franklin Gothic Book)�6�   
�������6�   �� 5"   
   -   5        $ AccDel��5"      $$��Удалить из учёта��6!   $
��Left=�6<   $	��Top=�6X   $	��256��6p   $��35��6|   ���	#FF9AE4CF$��16(�6�   $��
326,-2,0,0q�6�   $��Franklin Gothic Book)�6�   
�������6�   �� 5#   
   -   5        $ AccEdit��5#      $-��'Редиктировать запись��6"   $
��Left=�6A   $	��Top=�6]   $	��256��6u   $��35��6�   ���	#FF9AE4CF$��16(�6�   $��
648,-2,0,0q�6�   $��Franklin Gothic Book)�6�   
�������6�   �� 5$   
   -   5        $ ResetBtn��5$      $��Button��6#   $
��Left=�64   $��1286,560,-102,0q�6O   $	��Top=�6h   $��74��6�   $y�Hidden=�6�   �� 5%   
   -   5        $ 	SearchBtn��5%      $��Button��6$   $
��Left=�65   $��1285,522,-102,0q�6P   $	��Top=�6i   $��75��6�   $y�Hidden=�6�   �� 5&   
   -	   5         ��Name$ 	SearchBox��5&      $
��Left=�6%   $��24��6@   $��1285,466,-147,0q�6L    �� TextWrapping$
 Wrap=�6e   $��TextBox��6y   $	��Top=�6�   $	��120��6�   $y�Hidden=�6�   �� 5'   
   -
   5         ��Name$ ABCchck��5'      $��CheckBox��6$   $
��Left=�67   $��1299,417,-141,0q�6R   $	��Top=�6k   $	��100��6�   $y�Hidden=�6�   5)      5*      