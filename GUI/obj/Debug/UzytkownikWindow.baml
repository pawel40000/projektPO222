   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.UzytkownikWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  UzytkownikWindow��5   	   $	��450��6"   $	��800��6/   .��5	      �  J� RenderTransformOrigin$ 0.509,0.128&�6   .+�5
   
   �� -   5         ��Name$ textBox_imie��5
      $
��Left=�6(   $��23��6C   $��
190,39,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $��TextBox��6w   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ textBox_nazwisko��5      $
��Left=�6,   $��23��6G   $��190,104,0,0q�6S   $
 Wrap=�6h   $��TextBox��6|   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ textBox_nick��5      $
��Left=�6(   $��23��6C   $��190,175,0,0q�6O   $
 Wrap=�6d   $��TextBox��6x   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ textBox_recenzja��5      $
��Left=�6,   $��91��6G   $��154,301,0,0q�6S   $
 Wrap=�6h   $��TextBox��6|   $	��Top=�6�   $	��308��6�   �� 5   
   $
��Imie��6   $
��Left=�6   $��	41,39,0,0q�6:   $	��Top=�6M   $��93��6e   �� 5   
   $��Nazwisko��6   $
��Left=�6#   $��
41,100,0,0q�6>   $	��Top=�6R   $��93��6j   �� 5   
   $
��Nick��6   $
��Left=�6   $��
41,171,0,0q�6:   $	��Top=�6N   $��93��6f   �� 5   
   $��Ocena��6   $
��Left=�6    $��
41,238,0,0q�6;   $	��Top=�6O   $��93��6g   �� 5   
   $��Recenzja��6   $
��Left=�6#   $��
41,301,0,0q�6>   $	��Top=�6R   $��93��6j   �� 5   
   $
��Film��6   $
��Left=�6   $��405,142,0,0q�6:   $	��Top=�6O   $��93��6g   �� 5   
   -   5         ��Name$ listBox_filmy��5      $
��Left=�6)   $	��243��6D   $��
503,39,0,0q�6Q   $	��Top=�6e   $	��238��6}   �� 5   
   -   5         ��Name$ comboBox_ocena��5      $
��Left=�6,   $��190,238,0,0q�6G   $	��Top=�6\   $	��120��6t   .@�5      �� -   5         ��Name$	 one��5      .��6*   beznadziejny68   �� 5      -   5        $	 two��5      .��6*   slaby61   �� 5      -	   5        $ three��5      .��6,   
przecietny68   �� 5      -
   5        $
 four��5      .��6+   dobry62   �� 5      -   5        $
 five��5      .��6+   bdobry63   �� 5      -   5        $	 six��5      .��6*   rewelacyjny67   5      �� 5   
   -   5         ��Name$ 	zatwierdz��5      $��
Zatwierdź��6$   $
��Left=�68   $��543,301,0,0q�6S   $	��Top=�6h   $	��168��6�   $��85��6�   6�   5       5!      