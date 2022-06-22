using System;
using System.Collections.Generic;
using System.Text;
using Projeto_Esc.Database;
using Projeto_Esc.Interface;
using MySql.Data.MySqlClient;

namespace Projeto_Esc.Models
{
    internal class EscolaDAO
    {
        private static Conexao conn;
        public EscolaDAO()
        {
            conn = new Conexao();
        }
        public void Delete(Escola escola)
        {
            try
            {
                var comando = _conn.Query();
                comando.CommandText = "DELETE FROM escola_esc WHERE (id_esc = @id)";
                comando.Parameters.AddWithValue("@id", escola.id);

                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram eros ao salvar as informaçoes");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Escola GetById(int id)
        {
            throw new NotImplementedException();
        }

        private static Conexao _conn = new Conexao();
        public void Insert(Escola escola)
        {

            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO Escola VALUES(id_esc, nome_fantasia_esc,razao_social_esc," +
                    "cnpj_esc,insc_estadual_esc,tipo_esc, data_criacao_esc,responsavel_esc,responsavel_telefone_esc," +
                    " email_esc,telefone_esc ,rua_esc,numero_esc,bairro_esc,complemento_esc,cep_esc,cidade_esc," +
                    "estado_esc);";



                query.Parameters.AddWithValue("@nomeFantasia", escola.nome_fantasia_esc);
                query.Parameters.AddWithValue("@razaoSocial", escola.razao_social_esc);
                query.Parameters.AddWithValue("@cnpj", escola.cnpj_esc);
                query.Parameters.AddWithValue("@inscricaoEstadual", escola.insc_estadual_esc);
                query.Parameters.AddWithValue("@tipoEscola", escola.tipo_esc);
                query.Parameters.AddWithValue("@dataCriacao", escola.data_criacao_esc?.ToString("yyyy/mm/dd"));
                query.Parameters.AddWithValue("@responsavelNome", escola.responsavel_esc);
                query.Parameters.AddWithValue("@responsavelTelefone", escola.responsavel_telefone_esc);
                query.Parameters.AddWithValue("@email", escola.email_esc);
                query.Parameters.AddWithValue("@telefoneEscola", escola.telefone_esc);
                query.Parameters.AddWithValue("@rua", escola.rua_esc);
                query.Parameters.AddWithValue("@numero", escola.numero_esc);
                query.Parameters.AddWithValue("@bairro", escola.bairro_esc);
                query.Parameters.AddWithValue("@complemento", escola.complemento_esc);
                query.Parameters.AddWithValue("@cep", escola.cep_esc);
                query.Parameters.AddWithValue("@cidade", escola.cidade_esc);
                query.Parameters.AddWithValue("@estado", escola.estado_esc);


                var result = query.ExecuteNonQuery();

                if (result == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
           

        }

        public void Update(Escola escola)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "UPDATE Escola set" +
                    " nome_fantasia_esc = @nome  , razao_social_esc = @razao_social, cnpj_esc = @cnpj, insc_estadual_esc = @inscricao, " +
                    "tipo_esc = @tipo, data_criacao_esc = @data_criacao, responsavel_esc = @resp, responsavel_telefone_esc = @resp_tel, " +
                    "email_esc = @email, telefone_esc = @telefone, rua_esc = @rua, numero_esc = @numero, " +
                    "bairro_esc = @bairro, complemento_esc = @complemento, cep_esc = @cep, cidade_esc = @cidade, estado_esc = @estado " +
                    "WHERE id_esc = @id";

                comando.Parameters.AddWithValue("@id", escola.id);
                comando.Parameters.AddWithValue("@nome", escola.nome_fantasia_esc);
                comando.Parameters.AddWithValue("@razao_social", escola.razao_social_esc);
                comando.Parameters.AddWithValue("@cnpj", escola.cnpj_esc);
                comando.Parameters.AddWithValue("@inscricao", escola.insc_estadual_esc);
                comando.Parameters.AddWithValue("@tipo", escola.tipo_esc);
                comando.Parameters.AddWithValue("@data_criacao", escola.data_criacao_esc?.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@resp", escola.responsavel_esc);
                comando.Parameters.AddWithValue("@resp_tel", escola.responsavel_telefone_esc);
                comando.Parameters.AddWithValue("@email", escola.email_esc);
                comando.Parameters.AddWithValue("@telefone", escola.telefone_esc);
                comando.Parameters.AddWithValue("@rua", escola.rua_esc);
                comando.Parameters.AddWithValue("@numero", escola.numero_esc);
                comando.Parameters.AddWithValue("@bairro", escola.bairro_esc);
                comando.Parameters.AddWithValue("@complemento", escola.complemento_esc);
                comando.Parameters.AddWithValue("@cep", escola.cep_esc);
                comando.Parameters.AddWithValue("@cidade", escola.cidade_esc);
                comando.Parameters.AddWithValue("@estado", escola.estado_esc);

                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            } public List<Escola> List()
            {
                try
                {
                    var lista = new List<Escola>();
                    var comando = _conn.Query();

                    comando.CommandText = "SELECT * FROM Escola";

                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        var escola = new Escola();

                        escola.id = reader.GetInt32("id_esc");
                        escola.nome_fantasia_esc = IDAO.GetString(reader, "nome_fantasia_esc");
                        escola.razao_social_esc = IDAO.GetString(reader, "razao_social_esc");
                        escola.cnpj_esc = IDAO.GetString(reader, "cnpj_esc");
                        escola.insc_estadual_esc = IDAO.GetString(reader, "insc_estadual_esc");
                        escola.tipo_esc = IDAO.GetString(reader, "tipo_esc");
                        escola.data_criacao_esc = IDAO.GetDateTime(reader, "data_criacao_esc");
                        escola.responsavel_esc = IDAO.GetString(reader, "responsavel_esc");
                        escola.responsavel_telefone_esc = IDAO.GetString(reader, "responsavel_telefone_esc");
                        escola.email_esc = IDAO.GetString(reader, "email_esc");
                        escola.telefone_esc = IDAO.GetString(reader, "telefone_esc");
                        escola.rua_esc = IDAO.GetString(reader, "rua_esc");
                        escola.numero_esc = IDAO.GetString(reader, "numero_esc");
                        escola.bairro_esc = IDAO.GetString(reader, "bairro_esc");
                        escola.complemento_esc = IDAO.GetString(reader, "complemento_esc");
                        escola.cep_esc = IDAO.GetString(reader, "cep_esc");
                        escola.cidade_esc = IDAO.GetString(reader, "cidade_esc");
                        escola.estado_esc = IDAO.GetString(reader, "estado_esc");

                        lista.Add(escola);
                    }
                    reader.Close();
                    return lista;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }
    } }
