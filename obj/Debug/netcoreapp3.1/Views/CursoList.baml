   M S B A M L   `   `   `  ����F  BProjeto_Esc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Projeto_Esc.ViewsProjeto_Esc.Views  5   	   !    Projeto_Esc.Views.CursoList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Projeto_Esc.Views     5   	     � Title$  	CursoList��5   	   $	��450��6   $	��800��6(   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridCurso��5
       $��1��6   $��5q�67      AutoGenerateColumns$ False��6B      CanUserAddRows$ False��6^      CanUserDeleteRows$ False��5         
IsReadOnly$
 True��6-      AlternatingRowBackground �	#FFE5E5E5 �� AlternationCount$ 2��6d      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *Id+  5      $	 
Nome Curso��6%   
 69   �� *	NomeCurso+  5      $	 Carga Horária��6%   
 6<   �� *CargaH+  5      $	 Turno��6%   
 64   �� *Turno+4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 Ações��6)      CellTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� -   5        $��Atualizar registro��5   )   $	��5 0q�6F   6S   �� 5   "   -   5        $��Excluir registro��5   )   6D   5      5      5      5"      5#      5$      