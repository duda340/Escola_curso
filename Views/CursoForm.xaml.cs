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
    /// Lógica interna para CursoForm.xaml
    /// </summary>
    public partial class CursoForm : Window
    {
        private Curso _curso = new Curso();

        public CursoForm()
        {
            InitializeComponent();
            Loaded += CursoForm_Loaded;
        }
        public CursoForm(Curso curso)
        {
            InitializeComponent();
            _curso = curso;
            Loaded += CursoForm_Loaded;
        }

        private void CursoForm_Loaded(object sender, RoutedEventArgs e)
        {
            txtNomeCurso.Text = _curso.Nome_Curso;
            txtCargaH.Text = _curso.CargaH;
            txtDescricao.Text = _curso.Descricao;

            if (_curso.Turno == "Matutino")
            {
                rdMatutino.IsChecked = true;
            }
            else
            {
                if (_curso.Turno == "Vespertino")
                {
                    rdVespet.IsChecked = true;
                }
                else rdNoturno.IsChecked = true;

            }
        }

        private void btSalvarC_Click(object sender, RoutedEventArgs e)
        {
            _curso.Nome_Curso = txtNomeCurso.Text;
            _curso.CargaH = txtCargaH.Text;
            if ((bool)rdMatutino.IsChecked)
                _curso.Turno = "Matutino";
            else
            {
                if ((bool)rdVespet.IsChecked)
                    _curso.Turno = "Vespertino";
                else _curso.Turno = "Noturno";
            }
            _curso.Descricao = txtDescricao.Text;

            try
            {
                var dao = new CursoDAO();

                if (_curso.id > 0)
                {
                    dao.Update(_curso);
                    MessageBox.Show("Registro de curso atualizado com sucesso!");
                }
                else
                {
                    dao.Insert(_curso);
                    MessageBox.Show("Registro de curso cadastrado com sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }

      
    
}
