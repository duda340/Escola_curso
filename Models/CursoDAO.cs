using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Projeto_Esc.Interface;
using Projeto_Esc.Database;

namespace Projeto_Esc.Models
{
    internal class CursoDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Curso curso)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO Curso VALUES (null, @nome_cur, @descricao_cur, @carga_horaria_cur, @turno_cur);";

                comando.Parameters.AddWithValue("@nome_cur", curso.Nome_Curso);
                comando.Parameters.AddWithValue("@descricao_cur", curso.Descricao);
                comando.Parameters.AddWithValue("@carga_horaria_cur", curso.CargaH);
                comando.Parameters.AddWithValue("@turno_cur", curso.Turno);


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
        }

        public List<Curso> List()
        {
            try
            {
                var lista = new List<Curso>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM Curso";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var curso = new Curso();

                    curso.id = reader.GetInt32("id_cur");
                    curso.Nome_Curso = IDAO.GetString(reader, "nome_cur");
                    curso.Descricao =IDAO.GetString(reader, "descricao_cur");
                    curso.CargaH = IDAO.GetString(reader, "carga_horaria_cur");
                    curso.Turno = IDAO.GetString(reader, "turno_cur");

                    lista.Add(curso);
                }

                reader.Close();
                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Curso curso)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM Curso WHERE (id_cur = @id)";

                comando.Parameters.AddWithValue("@id", curso.id);

                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao deletar as informações");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void Update(Curso curso)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "update Curso set " +
                    "nome_cur = @nome, descricao_cur = @descricao, carga_horaria_cur = @carga_horaria, turno_cur = @turno" + " where id_cur = @id";

                comando.Parameters.AddWithValue("@id", curso.id);
                comando.Parameters.AddWithValue("@nome", curso.Nome_Curso);
                comando.Parameters.AddWithValue("@descricao", curso.Descricao);
                comando.Parameters.AddWithValue("@carga_horaria", curso.CargaH);
                comando.Parameters.AddWithValue("@turno", curso.Turno);

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
        }
    }
}

