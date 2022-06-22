using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Projeto_Esc.Models;

namespace Projeto_Esc.Views
{
    /// <summary>
    /// Lógica interna para CursoList.xaml
    /// </summary>
    public partial class CursoList : Window
    {
        public CursoList()
        {
            InitializeComponent();
            Loaded += CursoList_Loaded;
        }

        private void CursoList_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarListagem();
        }
        private void CarregarListagem()
        {
            try
            {
                var dao = new CursoDAO();
                List<Curso> listaCurso = dao.List();

                dataGridCurso.ItemsSource = listaCurso;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Atualizar_Click(object sender, RoutedEventArgs e)
        {

            var cursosSelecionado = dataGridCurso.SelectedItem as Curso;

            var form = new CursoForm(cursosSelecionado);
            form.ShowDialog();
            CarregarListagem();

        }

        private void Button_Remover_Click(object sender, RoutedEventArgs e)
        {
            var cursoSelecionada = dataGridCurso.SelectedItem as Curso;

            var resultado = MessageBox.Show($"Deseja realmente remover o curso '{cursoSelecionada.Nome_Curso}' ?", "Confirmação de Exclusão",
                MessageBoxButton.YesNo, MessageBoxImage.Warning);

            try
            {
                if (resultado == MessageBoxResult.Yes)
                {

                    var dao = new CursoDAO();
                    dao.Delete(cursoSelecionada);

                    MessageBox.Show("Registro removido com sucesso!");
                    CarregarListagem();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

    }   }
}
