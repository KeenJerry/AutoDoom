   M S B A M L   `   `   `  ���� C  ?AutoDoom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AutoDoom.ViewsAutoDoom.Views  (    "AutoDoom.Views.CreateProcessWindow   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:AutoDoom.Views     Z VPrism.Unity.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True � Title$ CreateProcessWindow��$	��340��$	��440�� � WindowStyle$
 None=�'  !System.Windows.Shell.WindowChrome   WindowChrome      CaptionHeight$ 0Q�   ResizeBorderThickness$ 10q� � 	Resources  �� MergedDictionaries �� Source��  �� $8 2/Assets/Resources/TopBar/TopBarButtonTemplate.xaml?��� $A ;/Assets/Resources/Project/SelectLocationButtonTemplate.xaml?��� $> 8/Assets/Resources/Project/CreateProcessTextBoxStyle.xaml?�%    .���    
Background#��[  	 � RowDefinitions	 �� $��30 ��� �� $��40 �.+�� -   
 �Name$
 
TopBarGrid��  Dock#��[ $��30��$	��Top=� � ColumnDefinitions �� $��30 ��� �� $��40 �.+��� $��1��$��Center=� 
 Letter#��[ $��New Blank Process���� -    ��Name$ TopBarCloseButton��$��2��$��40��  TopBarCloseButtonTemplate#��[  � ToolTip$ Close��$��Right=�� $��1��$��10q� � IsSharedSizeScope$
 True��	 �� $��30 ��� $��25 ��� $��20 ��� .+��� $��New Blank Process��$��0q�
�������$
��Bold"�$��15(��� $��1��$D��>Start with a blank project to design a new automation process.��$��0q�#��[ $��12(��� $��2��  LightBorder#��[ $	��Top=�� $��3�� �� $��80 � z� SharedSizeGroup$ Label���� 	 �� $��30 ��� $��30 ��� .+��� $��Name *��$��0q�#��[ $��Center=��� $��1��$��0��$��
Location *��$��0q�#��[ $��Center=��� $��2��$��0��$��30��$��Description��$��0q�#��[ $	��Top=�$��Center=��� -    ��Name$ NameTextBox��$��0��$��1��#��[ 
������ $��Center=�$��5q� �� 
CaretBrush
 �����  CreateProcessTextStyle#��[ ����  �� Path$ Process.Name�.��� $��1��$��1��$��5q� �� �� $��25 �.+��� -   $ LocationTextBox��$��0��
������ #��[ #��[ $��Center=�
 ��������� $ Process.Location�.���� -   $ SelectLocationButton��$��1��   SelectLocationButtonTemplate#��[ �� -   $ DescriptionTextBox��$��2��$��1�� �� TextWrapping$
 Wrap=� �� AcceptsReturn$
 True��
 �����
������ #��[ $��5q�#��[ ���� $ Process.Description��� $��2��#��[ ._��� $��2��$��23��$��60��$��Right=�$��0 0 8 0q�$�� ��{��� $ CreateButtonEnabled�.��Create