using System;
using System.Configuration;
using System.Data;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Banco_de_Questões
{
    public class instituicaoBD
    {
        string conn;

        public instituicoesBD()
        {
            conn = ConfigurationSettings.AppSettings["ConexaoBD"];
        }

        public void IncluirInstituicao(Instituicao instituicao)
        {
            MySqlConnection CN = new MySqlConnection(conn);
            MySqlCommand command = CN.CreateCommand();
            command.CommandText = "INSERT INTO question_institution(institution, timecreated, timemodified) Values(?instituicao, ?criado, ?modificado)";
            command.Parameters.AddWithValue("?instituicao", instituicao.Instituicao);
            command.Parameters.AddWithValue("?criado", instituicao.DataCriacao);
            command.Parameters.AddWithValue("?modificado", instituicao.DataAlteracao);

            try
            {
                CN.Open();
                int registrosAfetados = command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }

        public DataTable getInstituicao()
        {
            MySqlConnection CN = new MySqlConnection(conn);
            MySqlCommand cmd = CN.CreateCommand();
            MySqlDataAdapter da;

            cmd.CommandText = "SELECT * FROM question_institution";

            try
            {
                CN.Open();
                cmd = new MySqlCommand(cmd.CommandText, CN);
                da = new MySqlDataAdapter(cmd);

                DataTable dtInstituicao = new DataTable();

                da.Fill(dtInstituicao);

                return dtInstituicao;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }
    }
}