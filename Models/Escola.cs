using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Esc.Models
{
    public class Escola
    {
        public int id { get; set; }
        public string nome_fantasia_esc { get; set; }
        public string razao_social_esc { get; set; }
        public string cnpj_esc { get; set; }
        public string insc_estadual_esc { get; set; }
        public string tipo_esc { get; set; }
        public string responsavel_esc { get; set; }
        public string responsavel_telefone_esc { get; set; }
        public string email_esc { get; set; }
        public string telefone_esc { get; set; }
        public string rua_esc { get; set; }
        public string numero_esc { get; set; }
        public string bairro_esc { get; set; }
        public string complemento_esc { get; set; }
        public string cep_esc { get; set; }
        public string cidade_esc { get; set; }
        public string estado_esc { get; set; }
        public DateTime? data_criacao_esc { get; set; }
    }
}

