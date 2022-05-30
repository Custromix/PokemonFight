using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace PokemonFight.models
{
    class Connection
    {
        private static Connection connection;
        private MySqlConnection dbConnect;

        private Connection()
        {
            this.dbConnect = new MySqlConnection("server=127.0.0.1; port=3306; user id=root; password=; database=pokemon_fight; SslMode=none");
            try
            {
                this.dbConnect.Open();
                this.dbConnect.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static Connection GetDBConn()
        {
            if (connection == null)
            {
                connection = new Connection();
            }
            return connection;
        }

        public MySqlConnection getConnection()
        {
            return this.dbConnect;
        }
    }
}
