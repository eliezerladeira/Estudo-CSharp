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
    public class EmpresasMdl
    {
        string Conn;

        public EmpresasMdl()
        {
            Conn = ConfigurationManager.AppSettings["ConexaoBD"];
        }

        public void IncluirEmpresa(EmpresasCtl empresas)
        {
            var connection = new MySqlConnection(Conn);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO empresas (RazaoSocial, cadastro, fantasia) VALUES (?razaosocial, ?datacadastro, ?fantasia)";
                command.Parameters.AddWithValue("?razaosocial", empresas.EmpresaRazao);
                command.Parameters.AddWithValue("?datacadastro", DateTime.Parse(empresas.EmpresaDataCadastro).ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("?fantasia", empresas.EmpresaFantasia);
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

        public void AlterarEmpresa(EmpresasCtl empresas)
        {
            var connection = new MySqlConnection(Conn);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "UPDATE empresas SET RazaoSocial = ?razaosocial, cadastro = ?datacadastro, fantasia = ?fantasia WHERE idEmpresa = ?idempresa";
                command.Parameters.AddWithValue("?idempresa", empresas.EmpresaID);
                command.Parameters.AddWithValue("?datacadastro", empresas.EmpresaDataCadastro);
                command.Parameters.AddWithValue("?fantasia", empresas.EmpresaFantasia);
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

        public void ExcluirEmpresa(EmpresasCtl empresas)
        {
            var connection = new MySqlConnection(Conn);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "DELETE FROM empresas WHERE idEmpresa = ?idEmpresa";
                command.Parameters.AddWithValue("?idEmpresa", empresas.EmpresaID);
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

        public string ContaRegistros()
        {
            var connection = new MySqlConnection(Conn);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "SELECT COUNT(idEmpresa) AS total FROM empresas";
                command.ExecuteReader();


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





            //////string com o comando a ser executado 
            ////string sql = "SELECT COUNT(campo_tabela) AS total FROM tabela";

            ////    //instância do comando recebendo o comando e a conexão 
            ////    SqlCeCommand cmd = new SqlCeCommand(sql, conn);

            ////    //abro conexão 
            ////    conn.Open();

            ////    //instância do leitor 
            ////    SqlCeDataReader leitor = cmd.ExecuteReader();

            ////    //passo os valores para o textbox cliente que será retornado 
            ////    txtNome.Text = leitor["total"].ToString();

            ////    //fecha conexão 
            ////    conn.Close();







            //}
            //catch (MySqlException ex)
            //{
            //    throw new ApplicationException(ex.ToString());
            //}
            //finally
            //{
            //    cn.Close();
            //}

            //SELECT COUNT(ATRIB) FROM tabela1)
        }

        public DataTable getEmpresas()
        {
            MySqlConnection cn = new MySqlConnection(Conn);
            MySqlCommand cmd = cn.CreateCommand();
            MySqlDataAdapter da;
            cmd.CommandText = "SELECT * FROM empresas";

            try
            {
                cn.Open();
                cmd = new MySqlCommand(cmd.CommandText, cn);
                da = new MySqlDataAdapter(cmd);
                DataTable dtEmpresas = new DataTable();
                da.Fill(dtEmpresas);
                return dtEmpresas;
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

            adp.Fill(ds, "empresas");

            return ds;
        }

    }
}
// resetar autoincremento

//ALTER TABLE tabela AUTO_INCREMENT = 1