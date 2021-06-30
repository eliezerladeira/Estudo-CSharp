using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class BancasBD
    {
        string Conn;

        public BancasBD()
        {
            Conn = ConfigurationManager.AppSettings["ConexaoBD"];
        }

        public void IncluirBanca(Bancas bancas)
        {
            var connection = new MySqlConnection(Conn);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO bancas (banca) VALUES (?banca)";
                command.Parameters.AddWithValue("?banca", bancas.Banca);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public void AlterarBanca(Bancas bancas)
        {
            var connection = new MySqlConnection(Conn);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "UPDATE bancas SET banca = ?banca WHERE idBanca = ?idBanca";
                command.Parameters.AddWithValue("?idBanca", bancas.BancaID);
                command.Parameters.AddWithValue("?banca", bancas.Banca);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public void ExcluirBanca(Bancas bancas)
        {
            var connection = new MySqlConnection(Conn);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "DELETE FROM bancas WHERE idBanca = ?idBanca";
                command.Parameters.AddWithValue("?idBanca", bancas.BancaID);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public DataTable getBancas()
        {
            MySqlConnection cn = new MySqlConnection(Conn);
            MySqlCommand cmd = cn.CreateCommand();
            MySqlDataAdapter da;
            cmd.CommandText = "SELECT * FROM bancas";

            try
            {
                cn.Open();
                cmd = new MySqlCommand(cmd.CommandText, cn);
                da = new MySqlDataAdapter(cmd);
                DataTable dtBancas = new DataTable();
                da.Fill(dtBancas);
                return dtBancas;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                cn.Close();
            }
        }

        public DataSet mostraResultados(string query)
        {
            var ds = new DataSet();
            MySqlConnection cn = new MySqlConnection(Conn);
            cn.Open();

            var adp = new MySqlDataAdapter(query, cn);

            adp.Fill(ds, "bancas");

            return ds;
        }
    }
}