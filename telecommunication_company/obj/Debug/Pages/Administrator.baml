   M S B A M L   `   `   `  ����T  Ptelecommunication_company, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:telecommunication_company.Pagestelecommunication_company.Pages  5      3    -telecommunication_company.Pages.Administrator   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:telecommunication_company.Pages     5      $	��450��5	      $	��820��6     N� Title$  Administrator��5
       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ btnAdd��5      $��0��6   $
��Left=�6.   $��Добавить��6I   6\   �� 5   
   -   5        $ btnSave��5      $��0��6   $
��Left=�6/   $��Сохранить PDF��6J   $��	160 0 0 0q�6b   6u   �� 5   
   -   5        $ btnExcel��5      $��0��6   $
��Left=�60   $��Получить Excel��6K   $��	320 0 0 0q�6d   6w   �� 5   
   -   5        $ btnPoisk��5      $��0��6   $��Right=�60   $��
Поиск��6L   6\   �� 5   
   -   5        $ btnSort��5      $��0��6   $
��Left=�6/   $��357,10,0,10q�6J   $��Сортировать��6_   $y�Hidden=�6u   �� 5   
   -   5         ��Name$ 	txtbPoisk��5      $��0��6%   $	��150��62   $��25��6>   $��Right=�6J   $��Center=�6f   $��	0,0,150,0q�6�    �� TextAlignment$
 Left=�6�   �� 5   
   -   5         ��Name$ cmbVubor��5       $��0��6   $	��192��62   $��30��6>   $
��Left=�6J   $��151,15,0,15q�6e   $y�Hidden=�6z   .@�5      �� $!��По возрастанию��6   $��0q�6.   �� 5      $��По убыванию��6   $��0q�6+   5      �� 5   
   -   5         ��Name$ listSotrudniki��5       $��1��6   $��Stretch=�68   ��5      �� 5      .R�5      �  � Orientation$ 
Horizontal=�6    ��69   �� *ActualWidth+	 �� ElementName$	 listSotrudniki��5       ��5"      �� 5#      .R�5$      �� -	   5        
���   �$��1q�5$   1   ���	#FFDBF6F3$��Stretch=�6\   ._�5%      � 
 �Name$
 dataSotrudnik��6    5&      �� 5'   "   $	��100 �60   �� 5(   "   $	��100 �60   .+�5*      �� $��0��6%   $��80��62   $��80��6=   $��1q�6I   $��/Resources/User.jpg��6T   �� 5+      $��1��6)   $��1q�66   $	��150��6A   $��Stretch=�6M   .+�5,   "   �� $��Center=�6F   $��1q�6c   ��6,   �� *
Familiya+6c   �� 5-   "   $
��Bold"�6B   $��Center=�6T   $��1q�6q   ��6,   �� *Imya+6q   �� 5.   "   $��Center=�6G   $��1q�6d   ��6,   �� *	Otchestvo+6d   5/      50      51      52      54      56      57      