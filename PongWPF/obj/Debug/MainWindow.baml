   M S B A M L   `   `   `  ����M  ISystem, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089/$clr-namespace:System;assembly=SystemSystem  5   @    PongWPF   PongGame.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   7system$clr-namespace:System;assembly=System     6@   -   5          � Title$  
MainWindow��5   	   $	��503��6   $	��806��6)    � 
ResizeMode$ NoResize=�65   .��5      �� -   5        $��
MainCanvas��5      $	��475��6   ���	#FFD1D1D1$��0,0,0,0q�6C   .+�5   
   �� -   5        $��LeftPad��5      $	��100��5      $��20��6!   
����  �
 �� Top 5	      �� *	YPosition+5   %   �� 5   
   -   5        $��RightPad��5      $	��100��5      $��20��6!   
���**�� �� Left$	 780��5       5      �� *	YPosition+5   &   �� 5   
   	 �� X1$	 400��6   	 �� X2$	 400��6   	 �� Y2$	 500��6!   	 �� Y1$ 0��6*   $��2��61   ���	#FFDBB0626Z   A� 5   
   -   5        $
��Ball��5   +   $��20��5      $��20��6   $	��0.1��5   Y   ���	#FFF84949 5   )   �� *X+ 5      �� *Y+ � DataContext 67   �� 	 �� Path$
	 ball�5      �� 5   
   -   5        $��label1��5   T   $	 630��6   $ 34��6"   $��28��6H   ��62   �� *Y+6T   �� 5   
   -   5        $��label2��5   R   $	 565��6   $ 34��6"   $��	Y of ball��62   $��28��6F   6R   �� 5   
   -   5        $��label3��5   W   $	 535��6   $ 68��6"   $��Y of right pad��62   $��28��6K   6W   �� 5   
   -	   5        $��label4��5   \   $	 630��6   $ 68��6"   $��28��6P   ��62   �� *	YPosition+6\   �� 5   
   -
   5        $��label5��5   _   $	 638��6   $	 128��6"   $��28��6S   ��63   �� *MovingRight+6_   �� 5   
   -   5        $��label6��5   T   $	 184��6   $ 34��6"   $��28��6H   ��62   �� *X+6T   �� 5   
   -   5        $��label7��5   R   $	 119��6   $ 34��6"   $��	X of ball��62   $��28��6F   6R   �� 5   
   -   5        $��label8��5   V   $ 89��6   $ 68��6!   $��X of right pad��61   $��28��6J   6V   �� 5   
   -   5        $��label9��5   \   $	 184��6   $ 68��6"   $��28��6P   ��62   �� *	YPosition+6\   �� 5   
   -   5        $��label10��5   _   $	 349��6   $ 35��6"   $
��auto��6Q   $��40(�5      
����  ���5   2   �� *
LeftResult+5      �� 5    
   -   5        $��label11��5    `   $	 421��6   $ 35��6"   $
��auto��6R   $��40(�5!      
���**����5    2   �� *RightResult+5!      5"      5#      