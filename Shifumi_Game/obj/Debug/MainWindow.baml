   M S B A M L   `   `   `  ����G  CShifumi_Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Shifumi_GameShifumi_Game  5   	       Shifumi_Game.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Shifumi_Game     5   	     � Title$  Shifumi��5   	   $	��600��6   $	��800��6&   .��5
      �  � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      $
��568* �6   .+�5   
   �� ���	#FF212121$
��Left=�6%   $	��572��6@   
���   �$	��Top=�6\   $	��795��6t   $��
0,0,0,-4.5q�6�   $��1��6�   �� 5   
   $
��Left=�6   $	��307��6+   $��	38,10,0,0q�68   $	��Top=�6K   $	��757��6c   $2��,shi-fu-mi-shifugeek-boutique-cadeau-geek.jpg��6o   $��1��6�   �� 5   
   -   5         ��Name$
 play��5      $��Jouer !��6   $
��Left=�61   $��327,447,0,0q�6L   $	��Top=�6a   $	��161��6y   $��60��6�   $��20(�6�   $��Segoe Print)�6�   $��	ExtraBold"�6�   ���	#FFDEBE2B���	#FFFF2300$��1��6  �� 5   
   -   5        $ paperbutton��5      $��Feuille��6&   $
��Left=�68   $��518,346,0,0q�6S   $	��Top=�6h   $	��125��6�   $��38��6�   $��16(�6�   $��Trebuchet MS)�6�   $��1��6�   ���	#FF212121���	#FF25ECF3���	#FF34EEFC6  �� 5   
   -   5        $ stonebutton��5      $��Pierre��6&   $
��Left=�67   $��305,346,0,0q�6R   $	��Top=�6g   $	��125��6   $��38��6�   $��16(�6�   $��Trebuchet MS)�6�   $��1��6�   ���	#FF212121���	#FF25ECF3���	#FF34EEFC6  �� 5   
   -   5        $ cutterbutton��5      $��Ciseau��6'   $
��Left=�68   $��
84,346,0,0q�6S   $	��Top=�6g   $	��125��6   $��38��6�   $��16(�6�   $��Trebuchet MS)�6�   $��1��6�   ���	#FF212121���	#FF25ECF3���	#FF34EEFC6  �� 5   
   -   5         ��Name$ resultTextBlock��5      $
��Left=�6-   $��250,240,0,0q�6H   $��1��6]   $
��Wrap=�6j   $��?��6~   $	��Top=�6�   $��50��6�   $	��240��6�   $��Times New Roman)�6�   
���   � J� OpacityMask �	#FF3EDBE4���	#FF3EDBE4 �� TextAlignment$ Center=�6  $��16(�6.  �� 5   
   -   5        $ statsTextBlock��5      $
��Left=�6,   $��
38,465,0,0q�6G   $��1��6[   $
��Wrap=�6h   $��?��6|   $	��Top=�6�   ���	#FFB0F4F0$��91��6�   $	��202��6�   $��10(�6�   $ Center=�6�   �� 5   
   $��Compteur de Victoire��6   $
��Left=�6/   $��
63,432,0,0q�6J   $��1��6^   $	��Top=�6k   $	��140��6�   ���	#FF212121���	#FF3EDBE4���	#FF3EDBE46�   �� 5   
   -   5        $ percentsTextBlock��5      $
��Left=�6/   $��575,465,0,0q�6J   $��1��6_   $
��Wrap=�6l   $��?��6�   $	��Top=�6�   ���	#FFB0F4F0$��91��6�   $	��191��6�   $��16(�6�   $ Center=�6�   �� 5   
   $��% Victoire contre l'IA��6   $
��Left=�61   $��601,432,0,0q�6L   $��1��6a   $	��Top=�6n   $	��140��6�   ���	#FF212121���	#FF3EDBE4���	#FF3EDBE46�   5      5      