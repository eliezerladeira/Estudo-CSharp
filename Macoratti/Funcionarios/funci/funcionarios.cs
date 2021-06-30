using System.Data;
using System.Data.OleDb;

namespace employeesapp
{
    public class funcionarios
    {
        public int Codigo;
        public string Nome;
        public string Cargo;
        public string Empresa;

        public DataSet get()
        {
            OleDbConnection conn = new OleDbConnection(Conexao.getConexao());
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select Codigo as Codigo, Nome as Nome, Cargo as Cargo, Empresa as Empresa From funcionarios", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public  void AddNew()
        {
            OleDbConnection conn = new OleDbConnection(Conexao.getConexao());
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Insert Into funcionarios(Nome,Cargo,Empresa)Values ('" + Nome + "','" + Cargo + "','" + Empresa + "')", conn);
            cmd.ExecuteNonQuery();
        }

        public  void Update(int Codigo)
        {
            OleDbConnection conn = new OleDbConnection(Conexao.getConexao());
            conn.Open();
            string updatesql = "update funcionarios set Nome= '" + Nome + "', Cargo = '" + Cargo + "', Empresa = '" + Empresa + "'  Where Codigo = " + Codigo;
            OleDbCommand cmd = new OleDbCommand(updatesql, conn);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int Codigo)
        {
            OleDbConnection conn = new OleDbConnection(Conexao.getConexao());
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE * FROM funcionarios Where Codigo = " + Codigo , conn);
            cmd.ExecuteNonQuery();
        }

        public static DataSet Procurar(int codigo)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(Conexao.getConexao());
                conn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("Select Codigo as Codigo, Nome as Nome, Cargo as Cargo, Empresa as Empresa From funcionarios Where Codigo = " + codigo, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "DGV1");
                return ds;
            }
            catch
            {
                throw;
            }
        }
    }
}
