   M S B A M L   `   `   `  ����C  ?AutoDoom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AutoDoom.ViewsAutoDoom.Views  5   	   (    "AutoDoom.Views.CreateProcessWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:AutoDoom.Views     5   	   Z VPrism.Unity.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5   	   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5   	    � Title$ CreateProcessWindow��5
   	   $	��340��6%   $	��440��62    � WindowStyle$
 None=�6>   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 0Q�6      ResizeBorderThickness$ 10q�6)    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $8 2/Assets/Resources/TopBar/TopBarButtonTemplate.xaml?�6%   �� 5      $A ;/Assets/Resources/Project/SelectLocationButtonTemplate.xaml?�6%   �� 5      $> 8/Assets/Resources/Project/CreateProcessTextBoxStyle.xaml?�6%   %    5      .��5      �    
Background#��[  6   	 � RowDefinitions	 5   
   �� 5      $��30 �6   �� 5      �� 5      $��40 �6   .+�5    
   � -   5        
 �Name$
 
TopBarGrid��5         Dock#��[ 6#   $��30��6F   $	��Top=�6R    � ColumnDefinitions 5!      �� 5"      $��30 �6#   �� 5#      �� 5$      $��40 �6#   .+�5'      �� $��1��6   $��Center=�6$    
 Letter#��[ 6?   $��New Blank Process��6d   �� 5(      -   5         ��Name$ TopBarCloseButton��5(   %   $��2��6   $��40��6@     TopBarCloseButtonTemplate#��[ 6K    � ToolTip$ Close��6�   $��Right=�5)      5*      5+      � 5-   
   $��1��6   $��10q�6    � IsSharedSizeScope$
 True��6(   	 5.      �� 5/      $��30 �6    �� 50      $��25 �6    �� 51      $��20 �6    �� 52      .+�54      �� $��New Blank Process��6   $��0q�60   
�������$
��Bold"�6O   $��15(�6a   �� 55      $��1��6   $D��>Start with a blank project to design a new automation process.��6!   $��0q�56      #��[ 6    $��12(�6E   �� 57      $��2��6     LightBorder#��[ 6%   $	��Top=�6O   � 58      $��3��6    59      �� 5:      $��80 �6'    z� SharedSizeGroup$ Label��62   �� 5;      	 5>      �� 5?      $��30 �6$   �� 5@      $��30 �6$   �� 5A      .+�5D      �� $��Name *��6   $��0q�6)   #��[ 65   $��Center=�6Z   �� 5E      $��1��6   $��0��6%   $��
Location *��65   $��0q�6J   #��[ 6V   $��Center=�6{   �� 5F      $��2��6   $��0��6%   $��30��65   $��Description��6A   $��0q�6W   #��[ 6c   $	��Top=�6�   $��Center=�6�   �� 5H      -   5         ��Name$ NameTextBox��5H      $��0��6/   $��1��6<   #��[ 6L   
������ $��Center=�6�   $��5q�5I       �� 
CaretBrush
 �����  CreateProcessTextStyle#��[ 6[   ��68   ��  �� Path$ Process.Name�.��6�   5J      � 5K      $��1��6   $��1��6$   $��5q�64    5L      �� 5M      �� 5N      $��25 �6+   .+�5Q      �� -   5        $ LocationTextBox��5Q      $��0��67   
������ #��[ 6`   #��[ 5R      $��Center=�6N   
 �������5S      �� $ Process.Location�.��6o   5T      �� 5U      -   5        $ SelectLocationButton��5U   -   $��1��6      SelectLocationButtonTemplate#��[ 6K   6�   5V      �� 5W      -   5        $ DescriptionTextBox��5W      $��2��66   $��1��6C    �� TextWrapping$
 Wrap=�6S    �� AcceptsReturn$
 True��6g   
 �����
������ #��[ 5X   3   $��5q�6X   #��[ 5Y      ��5Z      �� $ Process.Description�5[      5]      �� 5^   
   $��2��6   #��[ 6   ._�5_      �� $��2��6   $��23��6"   $��60��6.   $��Right=�69   $��0 0 8 0q�6U   $�� ��6�   {�6f   �� $ CreateButtonEnabled�.��6�   Create5a      5b      5c      5e      