   M S B A M L   `   `   `  ����A  =vistas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:vistasvistas  5   	       vistas.ventas   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:vistas     5   	     � Title$  ventas��5   	   $	��600��6   $	��800��6%   .��5	      � .+�5   
   �� $��Nombre Cliente��6   $
��Left=�6)   $��	70,67,0,0q�6D   $	��Top=�6W   �� 5   
   $��Apellido Cliente��6   $
��Left=�6+   $��
70,107,0,0q�6F   $	��Top=�6Z   �� 5   
   -   5         ��Name$ txt_NombreCliente��5      $
��Left=�6-   $��23��6H   $��
197,67,0,0q�6T    �� TextWrapping$
 Wrap=�6h   $	��Top=�6}   $	��120��6�   �� 5   
   -   5        $ txt_ApellidoCliente��5      $
��Left=�6/   $��23��6J   $��197,110,0,0q�6V   $
 Wrap=�6k   $	��Top=�6�   $	��120��6�   �� 5   
   $��Email��6   $
��Left=�6    $��
70,149,0,0q�6;   $	��Top=�6O   �� 5   
   -   5        $ 	txt_Email��5      $
��Left=�6%   $��23��6@   $��197,152,0,0q�6L   $
 Wrap=�6a   $	��Top=�6v   $	��120��6�   �� 5   
   $��Numero de personas��6   $
��Left=�6-   $��
70,235,0,0q�6H   $	��Top=�6\   �� 5   
   -   5        $ txt_NROPersonas��5      $
��Left=�6+   $��23��6F   $��197,238,0,0q�6R   $
 Wrap=�6g   $	��Top=�6|   $	��120��6�   �� 5   
   $��Precio por persona ��6   $
��Left=�6.   $��
70,195,0,0q�6I   $	��Top=�6]   �� 5   
   -   5        $ 
txt_Precio��5      $
��Left=�6&   $��23��6A   $��197,195,0,0q�6M   $
 Wrap=�6b   $	��Top=�6w   $	��120��6�   �� 5   
   $��Total��6   $
��Left=�6    $��113,293,0,0q�6;   $	��Top=�6P   $��79��6h   $��20(�6s   $
��Bold"�6�   �� 5   
   -   5        $ 	txt_total��5      $
��Left=�6%   $��37��6@   $��197,293,0,0q�6L   $
 Wrap=�6a   $	��Top=�6v   $	��120��6�   $��20(�6�   $
��Bold"�6�   �� 5   
   -   5        $��generar contrato ��5      $
��Left=�6-   $��414,299,0,0q�6H   $	��Top=�6]   $	��150��6u   $��32��6�   6�   �� 5   
   -   5         ��Name$ Contrato��5      $
��Left=�6&   $��
449,67,0,0q�6A   $
��Wrap=�6U   $	��Top=�6j   $��66��6�   $	��280��6�   
���   ����	#FFEEE9E96�   �� 5   
   -	   5         ��Name$ limpiar��5      $��Limpiar��6"   $
��Left=�64   $��675,152,0,0q�6O   $	��Top=�6d   $��75��6|   6�   &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ tabla��5      $
��Left=�6"   $	��176��6=   $��
70,364,0,0q�6J   $	��Top=�6^   $	��680��6v      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 61   �� 
 �� Path$
 id�  5      $ Nombre��6%   	 65   �� $
 nombre�  5      $ Apellido��6%   	 67   �� $
 apellido�  5      $ Email��6%   	 64   �� $
 email�  5       $ Precio Persona��6%   	 6=   �� $
 precioPesona�  5!      $ Cantidad��6%   	 67   �� $
 
NroPersona�  5"      $ Total��6%   	 64   �� $
 Total�4  .System.Windows.Controls.DataGridTemplateColumn  5#         CellTemplate 5$      �� 5%      .R�5&      �� -   5        ��5&   <   �� $
 id�.��6a   
Eliminar6k   5'      5)        5*       5+      �� 5,      .R�5-      �� -   5        ��5-   <   �� $
 id�.��6a   editar6i   5.      50      53      56      58      