   M S B A M L   `   `   `  ����>  :SRB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SRBSRB  5   	       SRB.EqAccountingEdit   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:SRB     5   	     � Title$  EqAccountingEdit��5   	   $	��450��6"   $	��800��6/    � WindowStartupLocation$ CenterScreen=�6;    � WindowStyle$
 None=�6`   .��5	      � ���	#FF101921.+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ AccountingGrid��5
      $
��Left=�6+   $	��402��6F   $��
388,30,0,0q�6S   $	��Top=�6g   $	��395��6      
IsReadOnly .    CanUserResizeRows .     CanUserResizeColumns .  $��16(�6�   $��Franklin Gothic Book)�6�   
������ 
���������5      �� 5       �� Color$ 	#FF182834��6"    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader	 �� 
TargetType
 �� Property �� Value)  #System.Windows.Controls.DataGridRow��%q  '        '  �     �� 5      "	  6   .�5      �� 
 � �� �	#FF15222C63   �� 5      
 � ��$ SemiBold"�63   �� 5      
 � ��$ 0,0,0,2q�68   �� 5      
 � ��$ 20(�61   �� 5      
 � ��
 ���� 64   5      �� 5      "	  6   .�5      �� 
 � ��
 ���� 63   �� 5      
 � ��
 �����63   5      5      5      �� 5   
   -   5         ��Name$ equipmentNameTextBox��5      $
��Left=�60   $��29��6K   $��	10,47,0,0q�6W    �� TextWrapping$
 Wrap=�6j   $�� ��6~   $	��Top=�6�   $	��373��6�   
������ 
�������
�������$��Franklin Gothic Book)�6�   $��16(�6  �� 5   
   $1��+Название оборудования: ��6   $
��Left=�62   $��	10,21,0,0q�6M   $	��Top=�6`   $��Franklin Gothic Book)�6x   $��16(�6�   
�������6�   �� 5   
   $+��%Название отделения: ��6   $
��Left=�6/   $��	10,81,0,0q�6J   $	��Top=�6]   $��Franklin Gothic Book)�6u   $��16(�6�   
�������6�   �� 5    
   -   5        $ equipmentDepartTextbox��5       $
��Left=�62   $��29��6M   $��
10,109,0,0q�6Y   $
 Wrap=�6m   $�� ��6�   $	��Top=�6�   $	��188��6�   
������ 
�������
�������$��Franklin Gothic Book)�6�   $��16(�6  �� 5!   
   $��Стоимость: ��6   $
��Left=�6&   $��
10,143,0,0q�6A   $	��Top=�6U   $��Franklin Gothic Book)�6m   $��16(�6�   
�������6�   �� 5"   
   -   5        $ equipmentMoneyTextBox��5"      $
��Left=�61   $��29��6L   $��
10,171,0,0q�6X   $
 Wrap=�6l   $�� ��6�   $	��Top=�6�   $	��188��6�   
������ 
�������
�������$��Franklin Gothic Book)�6�   $��16(�6  �� 5#   
   $��Количество: ��6   $
��Left=�6'   $��
10,200,0,0q�6B   $	��Top=�6V   $��Franklin Gothic Book)�6n   $��16(�6�   
�������6�   �� 5$   
   -   5        $ equipmentCountTextBox��5$      $
��Left=�61   $��29��6L   $��
10,228,0,0q�6X   $
 Wrap=�6l   $�� ��6�   $	��Top=�6�   $	��188��6�   
������ 
�������
�������$��Franklin Gothic Book)�6�   $��16(�6  �� 5%   
   $��Дата поломки: ��6   $
��Left=�6)   $��
10,314,0,0q�6D   $	��Top=�6X   $��Franklin Gothic Book)�6p   $��16(�6�   
�������6�   (  "System.Windows.Controls.DatePicker  5&   
   -   5          Name$ equipmentDateTextBox��5&      $
��Left=�63   $	��Top=�6N   $��
10,342,0,0q�6f   $	��188��6z   $��29��6�   $��Franklin Gothic Book)�6�   $��16(�6�   �� 5'   
   -   5         ��Name$ EditBtn��5'      $ ��Редактировать��6"   $��Center=�6:   $��16(�6Y   $��Franklin Gothic Book)�6g   ���	#FF9AE4CF$��92,404,486,10q�6�   $	��214��6�   6�   �� 5(   
   $��Поставщик: ��6   $
��Left=�6&   $��
10,257,0,0q�6A   $	��Top=�6U   $��Franklin Gothic Book)�6m   $��16(�6�   
�������6�   �� 5)   
   -   5        $ equipmentProvTextBox��5)      $
��Left=�60   $��29��6K   $��
10,285,0,0q�6W   $
 Wrap=�6k   $�� ��6   $	��Top=�6�   $	��188��6�   
������ 
�������
�������$��Franklin Gothic Book)�6�   $��16(�6  �� 5*   
   -	   5        $ ExitBtn��5*      $��X��6"   $��Right=�6.   $	��Top=�6K   $��25��6c   $��Franklin Gothic Book)�6n   $��24(�6�   
������ 
������ 
�������6�   5+      5,      