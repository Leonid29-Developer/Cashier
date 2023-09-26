using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier
{
    internal class SQL
    {
        //Проверка подключения к серверу
        public static bool ServerСonnectionVerification(string Server)
        {
            try
            {
                SqlConnection Connection = new SqlConnection($@"Data Source={Server};Integrated Security=True");
                Connection.Open(); return true;
            }
            catch
            {
                return false;
            }
        }

        //Проверка подключения к базе данных
        public static bool DataBaseСonnectionVerification(string Server, string DataBase)
        {
            try
            {
                SqlConnection Connection = new SqlConnection($@"Data Source={Server};" + $"Initial Catalog=\"{DataBase}\";Integrated Security=True");
                Connection.Open(); return true;
            }
            catch
            {
                return false;
            }
        }

        //Исполнение хранимой процедуры для получения таблицы согласно запросу Select
        public static List<List<string>> SELECT(string Server, string SQL_Command)
        {
            using (SqlConnection Connection = new SqlConnection($@"Data Source={Server};Integrated Security=True"))
            {
                Connection.Open();
                using (SqlCommand CMD = new SqlCommand(SQL_Command, Connection))
                {
                    SqlDataReader reader = CMD.ExecuteReader(); List<List<string>> Data = new List<List<string>>();

                    if (reader.HasRows) // если есть данные
                    {
                        {
                            List<string> Log = new List<string>();
                            for (int l = 0; l < reader.FieldCount; l++) Log.Add(reader.GetName(l).ToString());
                            Data.Add(Log);
                        }

                        while (reader.Read())
                        {
                            List<string> Log = new List<string>();
                            for (int l = 0; l < reader.FieldCount; l++) Log.Add(reader.GetValue(l).ToString());
                            Data.Add(Log);
                        }
                    }
                    Connection.Close(); return Data;
                }
            }
        }

        //Создание локальной таблицы по предоставленным столбцам
        public static List<List<string>> LocalDB(string[] Columns)
        {
            List<List<string>> Data = new List<List<string>>();
            List<string> Column = new List<string>();
            for (int I1 = 0; I1 < Columns.Length; I1++) Column.Add(Columns[I1]);
            Data.Add(Column); return Data;
        }

        //Добавление данных в локальную таблицу
        public static List<List<string>> LocalDB(List<List<string>> Data, string[] Line)
        {
            List<string> LL = new List<string>();
            for (int I1 = 0; I1 < Line.Length; I1++) LL.Add(Line[I1]);
            Data.Add(LL); return Data;
        }
    }
}