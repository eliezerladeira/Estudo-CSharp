using System.Configuration;

namespace employeesapp
{
    public class Conexao
    {
        /// <summary>
        /// Para usar esse recurso você deve incluir uma referência ao assembly System.Configuration no seu projeto
        /// </summary>
        /// <returns></returns>
        public static string getConexao()
        {
            return ConfigurationManager.ConnectionStrings["FuncionariosConexao2"].ConnectionString;
        }
    }
}
