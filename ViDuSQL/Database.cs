using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ViDuSQL
{
    internal class Database
    {
        private static string connectionString =
            @"Data Source=PHAMMINHQUANG;Initial Catalog=ViDuSQLNangCao;Integrated Security=True;TrustServerCertificate=True";

        public static DataTable Query(string sql, Dictionary<string, object> dictionary)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            foreach (string key in dictionary.Keys)
            {
                adapter.SelectCommand.Parameters.AddWithValue(key, dictionary[key]);
            }
            adapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        public static DataTable Query(string sql)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        public static void Execute(string sql, Dictionary<string, object> dictionary)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            foreach (KeyValuePair<string, object> item in dictionary)
            {
                command.Parameters.AddWithValue(item.Key, item.Value);
            }
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void Execute(string sql)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
