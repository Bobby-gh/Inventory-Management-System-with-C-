﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace BobCs
{
    internal class DBConnect
    {
        public static string con_s = @"server=localhost; userid=root; password=;  database=inventory_system_bob;";
        public static MySqlConnection connection = new MySqlConnection(con_s);
        public static MySqlCommand command = new MySqlCommand();

        public static void open_connection()
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void close_connection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public DataTable getTable(string query)
        {
            open_connection();
            command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            close_connection();
            return table;
        }
    }
}
