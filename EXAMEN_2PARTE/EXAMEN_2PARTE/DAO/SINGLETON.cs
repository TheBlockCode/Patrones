using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EXAMEN_2PARTE.DAO
{
    class SINGLETON
    {
 
            private static SINGLETON instance = null;
            public static SINGLETON Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new SINGLETON();
                    }

                    return instance;
                }
            }

        private MySqlConnection sqlConnection;
        public MySqlConnection SqlConnection { get => sqlConnection; }

        private SINGLETON()
            {
                string server = "localhost";
                string user = "root";
                string password = "13Junio1998L9";
                string database = "examen";
                string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";

                sqlConnection = new MySqlConnection(connectionString);
            }
        
    }
}

