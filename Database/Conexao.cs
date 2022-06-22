using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projeto_Esc.Database
{
    
        internal class Conexao
        {
            private static string host = "localhost";
            private static string port = "3306";
            private static string user = "root";
            private static string password = "Eduarda18#04";
            private static string dbname = "bd_escola";
            private static MySqlConnection connection;
            private static MySqlCommand command;

            public Conexao()
            {
                try
                {
                    connection = new MySqlConnection($"server={host};database={dbname};port={port};user={user};password={password}");
                    connection.Open();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            public MySqlCommand Query()
            {
                try
                {
                    command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;

                    return command;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void Close()
            {
                connection.Close();
            }



        }
    
}
