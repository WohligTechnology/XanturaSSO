   M S B A M L   `   `   `  ����B  >Xantura, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Mizutama.Lib.MVVMMizutama.Lib.MVVM  5   	   clr-namespace:TrixieTrixie  5   	       Trixie.OptionDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   0libmclr-namespace:Mizutama.Lib.MVVM     5   	   $appclr-namespace:Trixie     5   	   $	��400��5   	   $	��600��6     � Title  5      `� 5   
    �� StringFormat$ 	{0} - {1}��6   .1�5      *   $Mizutama.Lib.MVVM.TranslateExtension  
   Key$ WinTitle��6   �� 5          
Trixie.App   	UserAgent �� Source# Z 6   5!      .��5$      �� .@�5%   
   �� $��Scripts��6   .��5&      �  � ColumnDefinitions 5'      �� 5(      $��2* �6'   �� 5)      $
��Auto �6'   �� 5*      $��3* �6'   .+�5-      �� -   5         ��Name$ SettingList��5-      $��0��6/   $��4q�6?   ��5.      �� *
Settings+��5/      �� 50      .R�51      ��  �� Orientation$ 
Horizontal=�6)   .+�52   "   ��  d� 	IsChecked 6+   �� *	Enabled+�� 53   "   ��6,   �� *Script.Name+54      55      57      �� 59      $��1��6   $��3��6/   $��Stretch=�69   � 5;      $��2��6   $��4q�6'   	 � RowDefinitions	 5<      �� 5=      $
��Auto �6(   �� 5>      $��* �6(   �� 5?      $��* �6(   �� 5@      $��* �6(   �� 5A      $��50 �6(   �� 5B      $
��Auto �6(    5D      �� 5E      $
��Auto �6+   �� 5F      $��* �6+   .+�5H      �� $��0��6    $��0��6-   $��4q�6=   	Namespace6S   �� 5I      $��0��6    $��1��6-   $��4q�6=   
 �� 
IsReadOnly
 . " �� VerticalScrollBarVisibility$
 Auto=�6Z    �� TextWrapping$
 Wrap=�6}   ��5J      �� *SelectedItem.Script.Namespace+ �� ElementName$ SettingList�� �� Mode$ OneWay=��� 5L      $��1��6    $��0��6-   $��4q�6=   Description6U   �� 5M      $��1��6    $��1��6-   $��4q�6=   
 . $
 Auto=�6Z   $
 Wrap=�6}   ��5N      �� *!SelectedItem.Script.Description+$ SettingList��$ OneWay=��� 5P      $��2��6    $��0��6-   $��4q�6=   
Includes6R   �� 5Q      $��2��6    $��1��6-   $��4q�6=   
 . $
 Auto=�6Z   $
 Wrap=�6}   ��5R      �� *SelectedItem.Script.Includes+$ SettingList��$ OneWay=��� 5T      $��3��6    $��0��6-   $��4q�6=   
Excludes6R   �� 5U      $��3��6    $��1��6-   $��4q�6=   
 . $
 Auto=�6Z   $
 Wrap=�6}   ��5V      �� *SelectedItem.Script.Excludes+$ SettingList��$ OneWay=��� 5X      $��4��6    $��0��6-   $��4q�6=   File6N   �� 5Y      $��4��6    $��1��6-   $��4q�6=   
 . $
 Auto=�6Z   $
 Wrap=�6}   ��5Z      �� *SelectedItem.Script.Path+$ SettingList��$ OneWay=��� 5\      -   5        $��5��5\      $��0��6*   $��60��6:   $��4,2,4,2q�6E   .��6k   Reload6s   �� 5]      $��5��6!   $��1��6.   $ 
Horizontal=�5^      $��Right=�5_      .+�5a      �� -   5        $��60��5a   !   $��4,2,4,2q�6,   .��6N   OK6R   �� 5b      -   5        $��60��5b   !   $��4,2,4,2q�6,   .��6R   CANCEL6Z   5c      5d      5e      5f      �� 5g   
   $��Settings��6   .��5h      �� .+�5i      �� $��Script settings��6   �� 5j      $(��"Refresh scripts on browser refresh��6   $
 TrueY�6H   {�.  6Y   5k      5l      5m      5n      