using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class DALContato
    {
        private Conexao objConexao;

        public DALContato(Conexao conexao)
        {
            objConexao = conexao;
        }

        public void Incluir(Contato contato)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "INSERT INTO contato(con_nome, con_email, con_fone, con_rua, con_bairro, con_cidade, con_estado, con_cep) VALUES (@nome, @email, @fone, @rua, @bairro, @cidade, @estado, @cep); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", contato.Nome);
            cmd.Parameters.AddWithValue("@email", contato.Email);
            cmd.Parameters.AddWithValue("@fone", contato.Fone);
            cmd.Parameters.AddWithValue("@rua", contato.Rua);
            cmd.Parameters.AddWithValue("@bairro", contato.Bairro);
            cmd.Parameters.AddWithValue("@cidade", contato.Cidade);
            cmd.Parameters.AddWithValue("@estado", contato.Estado);
            cmd.Parameters.AddWithValue("@cep", contato.Cep);
            objConexao.Conectar();
            //executescalar aguarda retorno do banco de dados
            contato.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            objConexao.Desconectar();
        }

        public void Alterar(Contato contato)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Contato SET con_nome = @nome, con_email = @email, con_fone = @fone, con_rua = @rua, con_bairro = @bairro, con_cidade = @cidade, con_estado = @estado, con_cep = @cep WHERE con_cod = @cod";
            cmd.Parameters.AddWithValue("@nome", contato.Nome);
            cmd.Parameters.AddWithValue("@email", contato.Email);
            cmd.Parameters.AddWithValue("@fone", contato.Fone);
            cmd.Parameters.AddWithValue("@rua", contato.Rua);
            cmd.Parameters.AddWithValue("@bairro", contato.Bairro);
            cmd.Parameters.AddWithValue("@cidade", contato.Cidade);
            cmd.Parameters.AddWithValue("@estado", contato.Estado);
            cmd.Parameters.AddWithValue("@cep", contato.Cep);
            cmd.Parameters.AddWithValue("@cod", contato.Codigo);
            objConexao.Conectar();
            // executenonquery não espera retorno do banco de dados
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "DELETE FROM Contato WHERE con_cod = @cod";
            cmd.Parameters.AddWithValue("@cod", codigo);
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM contato WHERE con_nome LIKE '%" + valor + "%'", objConexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public Contato carregaContato(int codigo)
        {
            Contato modelo = new Contato();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM Contato WHERE con_cod = " + codigo.ToString();
            objConexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Codigo = Convert.ToInt32(registro["con_cod"]);
                modelo.Nome = Convert.ToString(registro["con_nome"]);
                modelo.Email = Convert.ToString(registro["con_email"]);
                modelo.Fone = Convert.ToString(registro["con_fone"]);
                modelo.Rua = Convert.ToString(registro["con_rua"]);
                modelo.Bairro = Convert.ToString(registro["con_bairro"]);
                modelo.Cidade = Convert.ToString(registro["con_cidade"]);
                modelo.Estado = Convert.ToString(registro["con_estado"]);
                modelo.Cep = Convert.ToString(registro["con_cep"]);
            }
            return modelo;
        }
    }
}