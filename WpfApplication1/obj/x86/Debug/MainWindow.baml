   M S B A M L   `   `   `  ����  RemindKitty    RemindKitty.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  Remind Kitty��5   	   $	��755��6   $	��529��6+    � 
ResizeMode$ NoResize=�6N    � WindowStartupLocation$ CenterScreen=�6d    � 	Resources 5         SmallLettersStyle �� Property �� Value  reminderlisttemplate �� Orientation � DataContext  tasklisttemplate��%�  &	        &	 �     &	 �    �� 5   
   .�5	      ��  � ��$ 10(�61   �� 5
       � ��$ Normal"�63   �� 5       � ��$ 1q�68   5      �� 5   
   .R�5      �� $��3q�6   $ Vertical=�6$   .+�5      �� $��remtitle��6   ��6,   �� *
RemTitle+ 6G   �� 6a   �� 5      $y�	Collapsed=�68   ��6   �� *
RemGroupID+6R   �� 5      $y�	Collapsed=�67   ��6   �� *	GroupType+6Q   �� 5      $y�	Collapsed=�63   ��6   �� *sType+6M   5      5      �� 5   
   .R�5      �� $��3q�6   $ Vertical=�6$   .+�5      �� ��6   �� *	TaskTitle+69   5      5      5      .��5      � ���	#FF585858$	��705��6"   $	��507��6/    � ColumnDefinitions 5   
   �� 5       $	��194 �6   �� 5!      $
��266* �6   �� 5"      $	��12* �6   .+�5$   
   �� -   5        $��cmdEditReminders��5$   �   #��[  6   $
��Edit��6<   $��27��6K   $
��Left=�6W   $��	12,12,0,0q�6r   $	��Top=�6�   $��69��6�   
�������$
��Bold"�6�   ���	#FF939393
���   �6  �� 5%   
   -   5        $��cmdAddReminders��5%   X   $��+��6   $��23��6   $
��Left=�6)   $��
169,13,0,0q�6D   $	��Top=�6o   $��25��6�   ���	#FFCBCBCB���	#FFC37FEB6�   &   System.Windows.Controls.Calendar  5&   
   -   5        $��	calendar1��5&   O   $	��173��6   $
��Left=�6    $��
12,469,0,0q�6;   $	��Top=�6`   $	��182��6x   �� 5'   
   -   5        $��lstTasks��5'   z   $	��585��6?   $
��Left=�6L   $��	18,49,0,0q�6g   $	��Top=�6�   $	��266��6�   $��1��6�   #��[ 6�   ��6   �� 	 �� Path$	 TaskCollection� 5(      
 �� Color��%  (��       5)   "   *$"SystemColors.HighlightTextBrushKey+)(��      5+   "   * SystemColors.HighlightBrushKey+)(�� >     5-   "   *SystemColors.ControlBrushKey+)�� 5)      $
 White��6X   �� 5+      $
 Black��6U   �� 5-      $

 Gray��6R   5.      5/      �� 50   
   -   5        $��button1��50   [   $
��Edit��6   $��23��6    $
��Left=�6,   $��
234,13,0,0q�6G   $	��Top=�6j   $��50��6�   
����������	#FF656363$��1��6�   �� 51   
   -   5        $��lblSelectedReminder��51   �   $��32��6x   $
��Left=�6�   $��	18,12,0,0q�6�   $	��Top=�6�   $	��201��6�   
�������$
��Bold"�6  $��15(�6  $��1��6%  ��6   �� $	 RemTitle� 63   ��  �� ElementName$ lstReminders��$	 SelectedItem�6%  �� 52   
   -   5        $��lstReminders��52      ���	#FF727272
�������$��13(�6P   #��[ 6�   $��12,49,0,558q�6�   $
��Left=�6	  $	��182��6$  ��6^   �� $	 ReminderCollection� 54      ��%  (��       55   "   *$"SystemColors.HighlightTextBrushKey+)(��      57   "   * SystemColors.HighlightBrushKey+)(�� >     59   "   *SystemColors.ControlBrushKey+)�� 55      $
 Black��6X   �� 57      $
 White��6U   �� 59      $

 Gray��6R   5:      5<      �� 5=   
   -	   5        $��	btnAction��5=   i   $��Select an Action ▼��6   $��23��6.   $
��Left=�6:   $��
75,440,0,0q�6U   $	��Top=�6z   $	��119��6�   $��11(�6�   $��Italic$�6�   6�   �� 5>   
   -
   5        $��listBox1��5>   �   ���	#FF727272$��13(�6)   
�������#��[ 6J   $��12,195,0,290q�6�   ��6   �� $	 ReminderCollection� 5?      ��%  (��       5@   0   *$"SystemColors.HighlightTextBrushKey+)(�� $     5A   0   * SystemColors.HighlightBrushKey+)(�� H     5B   /   *SystemColors.ControlBrushKey+)�� 5@      $
 Black��6"   60   �� 5A      $
 White��6"   60   �� 5B      $

 Gray��6"   6/   5C      5D      5E      5F      