﻿using System;
using System.Configuration;
using MySqlConnector;

namespace BudicMarinAdresar.Store
{
    internal class SqlConnectionFactory
    {
        public static string SqlConnectionString => ConfigurationManager.ConnectionStrings["Baza"].ConnectionString;

        public MySqlConnection GetNewConnection()
        {
            try
            {
                var connection = new MySqlConnection(SqlConnectionString);
                connection.Open();

                return connection;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void CloseConnection(MySqlConnection connection)
        {
            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
