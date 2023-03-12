using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Mart
{
    

        class connections
        {
            public static MySqlConnection getConnection()
            {
                MySqlConnection koneksi = null;

                try
                {
                    string sConnstring = "server = localhost;database= mart;uid=root;password=;";
                    koneksi = new MySqlConnection(sConnstring);
                }
                catch (MySqlException sqlex)
                {
                    throw new Exception(sqlex.Message.ToString());
                }
                return koneksi;
            }
        }
    }

