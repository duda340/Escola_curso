using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Linq;

namespace Projeto_Esc.Interface
{interface IDAO<T>
    {
        void Insert(T t);
        void Update(T t);
        void Delet(T t);
        List<T> List();
        T GetById(int id);
    }
    static class IDAO
    {
    public static string GetString(MySqlDataReader reader, string column_name)
    {
        string text = string.Empty;

        if (!reader.IsDBNull(reader.GetOrdinal(column_name)))
            text = reader.GetString(column_name);

        return text;
    }
        public static DateTime? GetDateTime(MySqlDataReader reader, string column_name)
        {
            DateTime? value = null;

            if (!reader.IsDBNull(reader.GetOrdinal(column_name)))
                value = reader.GetDateTime(column_name);

            return value;
        }
    }
    
}
