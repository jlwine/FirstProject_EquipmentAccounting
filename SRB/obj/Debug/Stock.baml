   M S B A M L   `   `   `  ����>  :SRB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SRBSRB  5          	SRB.Stock   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:SRB     5        N� Title$  Stock��5	      .��5      � .+�5   
    � -   5          �Name$ 
StockFrame��5      $�� ��6$   $
��Left=�6/   $	��594��6J   $��	10,0,0,-4q�6W   $	��Top=�6j   $
��1240��6�     � NavigationUIVisibility$ Hidden=�6�   ���	#FF1C2F3E6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Sklad��5      $
��Left=�6"   $	��494��6=   $��	10,40,0,0q�6J   $	��Top=�6]   $
��1230��6u      
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
   -   5         ��Name$ EditBtn��5       $;��5Редактирование оборудования��6"   $
��Left=�6H   $	��Top=�6d   $	��246��6|   $��35��6�   ���	#FF9AE4CF$��16(�6�   $��	286,0,0,0q�6�   $��Franklin Gothic Book)�6�   �� 5!   
   -   5        $ AddBtn��5!      $/��)Добавить оборудование��6!   $
��Left=�6A   $	��Top=�6]   $	��246��6u   $��35��6�   ���	#FF9AE4CF$��16(�6�   $��16,0,0,0q�6�   $��Franklin Gothic Book)�6�   �� 5"   
   -   5        $ 	DeleteBtn��5"      $/��)Удаление оборудования��6$   $
��Left=�6D   $	��Top=�6`   $	��246��6x   $��35��6�   ���	#FF9AE4CF$��16(�6�   $��	556,0,0,0q�6�   $��Franklin Gothic Book)�6�   �� 5#   
   -   5        $ 
RefreshBtn��5#      $%��Обновить таблицу��6%   $
��Left=�6@   $	��Top=�6\   $	��246��6t   $��35��6�   ���	#FF9AE4CF$��16(�6�   $��	830,0,0,0q�6�   $��Franklin Gothic Book)�6�   �� 5$   
   -   5         ��Name$ 	SearchBox��5$      $
��Left=�6%   $��19��6@   $��
57,541,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��735��6�   $��Franklin Gothic Book)�6�   $��18(�6�   $��Center=�6�   
�������
������ 6  �� 5%   
   $��Assets/search.png��6   $
��Left=�6+   $��19��6F   $��
29,541,0,0q�6R   $	��Top=�6f   $��23��6~   �� 5&   
   -   5        $ 	SearchBtn��5&      $��
Поиск��6$   $
��Left=�64   $	��Top=�6P   $	��153��6h   $��19��6t   ���	#FF9AE4CF$��14(�6�   $��797,541,0,0q�6�   $��Franklin Gothic Book)�6�   6�   �� 5'   
   -	   5        $ ResetBtn��5'      $��Сбросить��6#   $
��Left=�66   $	��Top=�6R   $	��153��6j   $��19��6v   ���	#FF9AE4CF$��14(�6�   $��797,561,0,0q�6�   $��Franklin Gothic Book)�6�   6�   �� 5(   
   -
   5         ��Name$ ABCchck��5(      $2��,Сортировать по алфавиту��6$   $
��Left=�6F   $��
57,565,0,0q�6a   $	��Top=�6u   
�������$��16(�6�   5)      5*      