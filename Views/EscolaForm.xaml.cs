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
using MySql.Data.MySqlClient;


namespace Projeto_Esc.Views
{
    /// <summary>
    /// Lógica interna para EscolaForm.xaml
    /// </summary>
    public partial class EscolaForm : Window
    {
        private Escola _escola = new Escola();
        public EscolaForm()
        {
            InitializeComponent();
            Loaded += EscolaForm_Loaded;
        }
       public EscolaForm(Escola escola)
        {
            InitializeComponent();
            Loaded += EscolaForm_Loaded;
            _escola = escola;
        }
        private void EscolaForm_Loaded(object sender, RoutedEventArgs e)
        {
            txtNomeFan.Text = _escola.nome_fantasia_esc;
            txtRazaoS.Text = _escola.razao_social_esc;
            txtCNPJ.Text = _escola.cnpj_esc;
            txtInsc.Text = _escola.insc_estadual_esc;
            dtCriacao.SelectedDate = _escola.data_criacao_esc;
            txtNomeRes.Text = _escola.responsavel_esc;
            txtTelefone.Text = _escola.responsavel_telefone_esc;
            txtEmail.Text = _escola.email_esc;
            txtTelefone.Text = _escola.telefone_esc;
            txtEndereco.Text = _escola.rua_esc;
            txtNumero.Text = _escola.numero_esc;
            txtBairro.Text = _escola.bairro_esc;
            txtComplemento.Text = _escola.complemento_esc;
            txtCEP.Text = _escola.cep_esc;
            txtCidade.Text = _escola.cidade_esc;
            txtEstado.Text = _escola.estado_esc;

            if (_escola.tipo_esc == "Pública")
            {
                rdPublico.IsChecked = true;
            }
            else
            {
                rdPrivado.IsChecked = true;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            _escola.nome_fantasia_esc = txtNomeFan.Text;
            _escola.razao_social_esc = txtRazaoS.Text;
            _escola.cnpj_esc = txtCNPJ.Text;
            _escola.insc_estadual_esc = txtInsc.Text;
            _escola.data_criacao_esc = dtCriacao.SelectedDate;
            _escola.responsavel_esc = txtNomeRes.Text;
            _escola.responsavel_telefone_esc = txtTelefone.Text;
            _escola.email_esc = txtEmail.Text;
            _escola.telefone_esc = txtTelefone.Text;
            _escola.rua_esc = txtEndereco.Text;
            _escola.numero_esc = txtNumero.Text;
            _escola.bairro_esc = txtBairro.Text;
            _escola.complemento_esc = txtComplemento.Text;
            _escola.cep_esc = txtCEP.Text;
            _escola.cidade_esc = txtCidade.Text;
            _escola.estado_esc = txtEstado.Text;
            _escola.tipo_esc = "Pública";

            if ((bool)rdPrivado.IsChecked)
                _escola.tipo_esc = "Privada";


            try
            {
                var dao = new EscolaDAO();

                if (_escola.id > 0)
                {
                    dao.Update(_escola);
                    MessageBox.Show("Registro de escola atualizados com sucesso!");
                }
                else
                {
                    dao.Insert(_escola);
                    MessageBox.Show("Registro de escola cadastrado com sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

      
}

