   M S B A M L   `   `   `  ����  Cine    	Cine.GUI3   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$%  Consulta y Filtro de Películas��5   	   $	��450��60   $	��800��6=   .��5      � $��10q�6   .+�5   
   �� $��Seleccionar fecha:��6   $	��Top=�6-   $
��Left=�6E   $��	10,10,0,0q�6`   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��DatePickerFecha��5      $	��Top=�6,   $
��Left=�6D   $��
120,10,0,0q�6_   �� 5   
   $��Género:��6   $	��Top=�6"   $
��Left=�6:   $��	10,50,0,0q�6U   �� 5   
   -   5        $��ComboBoxGenero��5      $	��Top=�6)   $
��Left=�6A   $��
120,50,0,0q�6\   $	��150��6p   .@�5      �� .��6   Todos6"   �� 5      .��6   	Acción6#   �� 5      .��6   	Comedia6$   �� 5      .��6   Drama6"   5      �� 5   
   $��Idioma:��6   $	��Top=�6"   $
��Left=�6:   $��	10,90,0,0q�6U   �� 5   
   -   5        $��ComboBoxIdioma��5      $	��Top=�6)   $
��Left=�6A   $��
120,90,0,0q�6\   $	��150��6p   .@�5      �� .��6   Todos6"   �� 5      .��6   
Español6$   �� 5      .��6   	Inglés6#   �� 5      .��6   
Francés6$   5      �� 5   
   -   5        $��ButtonConsultar��5      $-��'Consultar todas las películas del día��6(   $	��Top=�6X   $
��Left=�6p   $��
10,140,0,0q�6�   $	��250��6�   �� 5   
   -   5        $��ButtonAplicarFiltros��5      $��Aplicar filtros��6-   $	��Top=�6G   $
��Left=�6_   $��270,140,0,0q�6z   $	��150��6�   �� 5   
   -   5        $��ButtonLimpiar��5      $��Limpiar filtros��6&   $	��Top=�6@   $
��Left=�6X   $��430,140,0,0q�6s   $	��100��6�   &   System.Windows.Controls.DataGrid  5!   
   -   5        $��DataGridPeliculas��5!      $	��Top=�6,   $
��Left=�6D   $��
10,200,0,0q�6_   $	��200��6s   $	��760��6�      Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ Título��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Titulo+6P     5$      $ Género��6%   $	 150 6P    65   �� *Genero+6P     5%      $ Idioma��6%   $	 150 6P    65   �� *Idioma+6P     5&      $ Horario��6%   $	 100 6R    66   �� *	Horario+6R   5(      5)      5*      