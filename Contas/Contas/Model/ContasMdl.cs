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
using Contas.Controller;

namespace Contas.Model
{
    public class ContasMdl
    {
        string Conn;

        public ContasMdl()
        {
            Conn = ConfigurationManager.AppSettings["ConexaoBD"];
        }

        public void IncluirConta(ContasCtl contas)
        {
            var connection = new MySqlConnection(Conn);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO contas (descricao, ativa, saldoInicial, dataCadastro) VALUES (?descricao, ?ativa, ?saldoinicial, ?datacadastro)";
                command.Parameters.AddWithValue("?descricao", contas.ContaDescricao);
                command.Parameters.AddWithValue("?ativa", contas.ContaDescricao);
                command.Parameters.AddWithValue("?saldoInicial", contas.SaldoInicial);
                command.Parameters.AddWithValue("?dataCadastro", DateTime.Parse(contas.DataCadastro).ToString("yyyy-MM-dd"));
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

        public void AlterarConta(ContasCtl contas)
        {
            var connection = new MySqlConnection(Conn);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "UPDATE contas SET descricao = ?descricao, ativa = ?ativa, saldoInicial = ?saldo, dataCadastro = ?data WHERE idConta = ?idconta";
                command.Parameters.AddWithValue("?idconta", contas.ContaID);
                command.Parameters.AddWithValue("?descricao", contas.ContaDescricao);
                command.Parameters.AddWithValue("?ativa", contas.ContaAtiva);
                command.Parameters.AddWithValue("?saldo", contas.SaldoInicial);
                command.Parameters.AddWithValue("?data", contas.DataCadastro);
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

        public void ExcluirConta(ContasCtl contas)
        {
            var connection = new MySqlConnection(Conn);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "DELETE FROM contas WHERE idConta = ?idConta";
                command.Parameters.AddWithValue("?idConta", contas.ContaID);
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

        public DataTable getContas()
        {
            MySqlConnection cn = new MySqlConnection(Conn);
            MySqlCommand cmd = cn.CreateCommand();
            MySqlDataAdapter da;
            cmd.CommandText = "SELECT * FROM contas";

            try
            {
                cn.Open();
                cmd = new MySqlCommand(cmd.CommandText, cn);
                da = new MySqlDataAdapter(cmd);
                DataTable dtContas = new DataTable();
                da.Fill(dtContas);
                return dtContas;
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

            adp.Fill(ds, "contas");

            return ds;
        }

    }
}
// resetar autoincremento

//ALTER TABLE tabela AUTO_INCREMENT = 1