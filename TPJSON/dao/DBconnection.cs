using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPJSON.dao
{
    class DBconnection
    {
        private string dataBase = "jsondb_biblioteca";
        private string servidor = "localhost";
        private uint puerto = 3306;
        private string usuario = "root";
        private string password = "";

        private MySqlConnection connection;

        private void open()
        {
            MySqlConnectionStringBuilder configConecion = new MySqlConnectionStringBuilder();
            configConecion.Database = this.dataBase;
            configConecion.Server = this.servidor;
            configConecion.Port = this.puerto;
            configConecion.UserID = this.usuario;
            configConecion.Password = this.password;
            configConecion.SslMode = MySqlSslMode.None;
            connection = new MySqlConnection(configConecion.ConnectionString);
            connection.Open();
        }

        public MySqlConnection getConnection()
        {
            if (connection == null)
                open();
            return connection;
        }
    }
}
