using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace POSTGRESQL
{
    class CConexao
    {
        NpgsqlConnection conex = new NpgsqlConnection();

        static String servidor = "localhost";
        static String bd = "TesteDB";
        static String usuario = "postgres";
        static String password = "250403";
        static String porta = "5432";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + porta + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public NpgsqlConnection estabelecerConexao()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("Conexão bem sucedida com o BANCO DE DADOS!");
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("Nao se pode conectar a base de dados, error: " + e.ToString());
            }

            return conex;
        }


    }
}