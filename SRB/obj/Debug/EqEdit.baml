   M S B A M L   `   `   `  ����>  :SRB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SRBSRB  5   	       
SRB.EqEdit   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:SRB     5   	     � Title$  EqEdit��5   	   $	��500��6   $
��1000��6%    � WindowStartupLocation$ CenterScreen=�62    � WindowStyle$
 None=�6W   .��5	      � ���	#FF101921.+�5
   
   �� -   5         ��Name$ ExitBtn��5
      $��X��6"   $��Right=�6.   $	��Top=�6K   $��25��6c   $��Franklin Gothic Book)�6n   $��24(�6�   
������ 
������ 
�������6�   �� 5   
   $;��5Редактирование оборудования��6   $��Center=�66   $	��Top=�6T   ���	#00000000���	#FFE2B2B2$��20(�6�   $��Franklin Gothic Book)�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ SkladEd��5      $
��Left=�6$   $	��407��6?   $��
406,38,0,0q�6L   $	��Top=�6`   $	��576��6x      
IsReadOnly .    CanUserResizeRows .     CanUserResizeColumns .  $��16(�6�   $��Franklin Gothic Book)�6�   
������ 
���������5      �� 5       �� Color$ 	#FF182834��6"   	 � 	Resources	 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader
 �� 
TargetType �� Property �� Value)  #System.Windows.Controls.DataGridRow��%q  '        '  �     �� 5      "
  6   .�5      ��  � �� �	#FF15222C63   �� 5       � ��$ SemiBold"�63   �� 5       � ��$ 0,0,0,2q�68   �� 5       � ��$ 20(�61   �� 5       � ��
 ���� 64   5      �� 5      "
  6   .�5      ��  � ��
 ���� 63   �� 5       � ��
 �����63   5      5      5      �� 5   
   $0��*Название оборудования:��6   $
��Left=�61   $��	10,80,0,0q�6L   $	��Top=�6_   ���	#00000000���	#FFE2B2B2$��20(�6�   $��Franklin Gothic Book)�6�   �� 5    
   $��Описание: ��6   $
��Left=�6%   $��
10,164,0,0q�6@   $	��Top=�6T   ���	#FFE2B2B2$��Franklin Gothic Book)�6�   $��20(�6�   �� 5!   
   -   5         ��Name$! equipmentDescriptionTextBox��5!      $
��Left=�67   $	��120��6R   $��
10,195,0,0q�6_    �� TextWrapping$
 Wrap=�6s   $�� ��6�   $	��Top=�6�   $	��386��6�   $��Franklin Gothic Book)�6�   $��16(�6�   �� 5"   
   -   5        $ EditBtn��5"      $ ��Редактировать��6"   $��Center=�6:   $��16(�6Y   $��Franklin Gothic Book)�6g   ���	#FF9AE4CF$��89,320,689,143q�6�   $	��214��6�   6�   �� 5#   
   -   5        $ equipmentNameTextBox��5#      $
��Left=�60   $��23��6K   $��
10,111,0,0q�6W   $
 Wrap=�6k   $�� ��6   $	��Top=�6�   $	��386��6�   5$      5%      