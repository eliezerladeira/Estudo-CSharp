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
    public class DisciplinasBD
    {
        string Conn;

        public DisciplinasBD()
        {
            Conn = ConfigurationManager.AppSettings["ConexaoBD"];
        }

        public void IncluirDisciplina(Disciplinas disciplinas)
        {
            //MySqlConnection CN = new MySqlConnection(Conn);
            //MySqlCommand Cmd = CN.CreateCommand();
            //Cmd.CommandText = "INSERT INTO disciplinas(disciplina) Values(?disciplina)";
            //Cmd.Parameters.AddWithValue("?disciplina", disciplinas.Disciplina);

            var connection = new MySqlConnection(Conn);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO disciplinas (disciplina) VALUES (?disciplina)";
                command.Parameters.AddWithValue("?disciplina", disciplinas.Disciplina);
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

        public void AlterarDisciplina(Disciplinas disciplinas)
        {
            var connection = new MySqlConnection(Conn);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "UPDATE disciplinas SET disciplina = ?disciplina WHERE idDisciplina = ?idDisciplina";
                command.Parameters.AddWithValue("?idDisciplina", disciplinas.DisciplinaID);
                command.Parameters.AddWithValue("?disciplina", disciplinas.Disciplina);
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

        public void ExcluirDisciplina(Disciplinas disciplinas)
        {
            var connection = new MySqlConnection(Conn);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "DELETE FROM disciplinas WHERE idDisciplina = ?idDisciplina";
                command.Parameters.AddWithValue("?idDisciplina", disciplinas.DisciplinaID);
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

        public void PesquisarDisciplina(Disciplinas disciplinas)
        {
            var connection = new MySqlConnection(Conn);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM disciplinas WHERE disciplina = ?disciplina";
                command.Parameters.AddWithValue("?disciplina", disciplinas.Disciplina);
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

        public DataTable getDisciplinas()
        {
            MySqlConnection cn = new MySqlConnection(Conn);
            MySqlCommand cmd = cn.CreateCommand();
            MySqlDataAdapter da;
            cmd.CommandText = "SELECT * FROM disciplinas";

            try
            {
                cn.Open();
                cmd = new MySqlCommand(cmd.CommandText, cn);
                da = new MySqlDataAdapter(cmd);
                DataTable dtDisciplinas = new DataTable();
                da.Fill(dtDisciplinas);
                return dtDisciplinas;
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

            adp.Fill(ds, "disciplinas");

            return ds;
        }
    }
}

// resetar autoincremento

//ALTER TABLE tabela AUTO_INCREMENT = 1