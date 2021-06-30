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
    public class AssuntosBD
    {
        string Conn;

        public AssuntosBD()
        {
            Conn = ConfigurationManager.AppSettings["ConexaoBD"];
        }

        public void IncluirAssunto(Assuntos assuntos)
        {
            var connection = new MySqlConnection(Conn);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO assuntos (assunto) VALUES (?assunto)";
                command.Parameters.AddWithValue("?assunto", assuntos.Assunto);
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

        public void AlterarAssunto(Assuntos assuntos)
        {
            var connection = new MySqlConnection(Conn);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "UPDATE assuntos SET assunto = ?assunto WHERE idAssunto = ?idAssunto";
                command.Parameters.AddWithValue("?idAssunto", assuntos.AssuntoID);
                command.Parameters.AddWithValue("?assunto", assuntos.Assunto);
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

        public void ExcluirAssunto(Assuntos assuntos)
        {
            var connection = new MySqlConnection(Conn);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "DELETE FROM assuntos WHERE idAssunto = ?idAssunto";
                command.Parameters.AddWithValue("?idAssunto", assuntos.AssuntoID);
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

        public DataTable getAssuntos()
        {
            MySqlConnection cn = new MySqlConnection(Conn);
            MySqlCommand cmd = cn.CreateCommand();
            MySqlDataAdapter da;
            cmd.CommandText = "SELECT * FROM assuntos";

            try
            {
                cn.Open();
                cmd = new MySqlCommand(cmd.CommandText, cn);
                da = new MySqlDataAdapter(cmd);
                DataTable dtAssuntos = new DataTable();
                da.Fill(dtAssuntos);
                return dtAssuntos;
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

            adp.Fill(ds, "assuntos");

            return ds;
        }
    }
}