   M S B A M L   `   `   `  ����G  CMVVMDemoCnam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MVVMDemoCnam.ViewMVVMDemoCnam.View  5   	   ?$clr-namespace:MVVMDemoCnam.ViewModelMVVMDemoCnam.ViewModel  5   	   "    MVVMDemoCnam.View.PlayerView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:MVVMDemoCnam.View     5   	   3vm$clr-namespace:MVVMDemoCnam.ViewModel     5   	     � Title$  
PlayerView��5	   	   $	��200��6   $	��319��6)    � DataContext 5
      ,   &MVVMDemoCnam.ViewModel.PlayerViewModel  5   
   .��5      � $	��169��6   $��Bottom=�6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   $��74��6,   �� 5      $
��109* �6   �� 5      $
��124* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��textFullName��5   �   $��0��6   $��0��6$   $��2��61   $��4q�6E   $��Center=�6�   $
��Bold"�6�   ��6P   �� *
FullName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��0��6   $��1��6    $��0,4,4,4q�6-   $��First Name:��6>   $��Right=�6T   $��70��6p   �� 5!   
   -   5        $��boxFirstName��5!   �   $��1��6   $��1��6"   $	��0,4q�6/   $
��Left=�6|   $	��200��6�   $��2��6�   ��6<   �� *	FirstName+$ PropertyChanged=�6�   �� 5#   
   $��0��6   $��2��6    $��0,4,4,4q�6-   $��
Last Name:��6>   $��Right=�6S   $��70��6o   �� 5$   
   -   5        $��boxLastName��5$   �   $��1��6   $��2��6"   $	��0,4q�6/   $
��Left=�6{   $	��200��6�   $��2��6�   ��6<   �� *
LastName+$ PropertyChanged=�6�   �� 5&   
   $��0��6   $��3��6    $��0,4,4,4q�6-   $��Pseudo:��6>   $��Right=�6P   $��70��6l   �� 5'   
   $��1��6   $��3��6$   $	��0,4q�61   $
��Left=�6R   $��0��6m   ��6>   �� *Id+6m   �� 5)   
   -   5         ��Name$ 	boxPseudo��5)   �   $��1��6   $��3��6"   $��1,3,0,5q�6/   $
��Left=�6}   $	��200��6�   $��2��6�   ��6@   �� *Pseudo+$ PropertyChanged=�6�   �� 5+   
   -   5        $��3��5+      $��4��6!   $��
10,4,4,-32q�6/   $
��O.K.��6X   5,      5-      