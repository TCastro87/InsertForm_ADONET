using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Dados
    {

        string connStr = ConfigurationManager.ConnectionStrings["String_Sql"].ConnectionString;

        public int Inserir_DadosCadastro(string Nome, string Endereco)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand dCmd = new SqlCommand("sp_insert_user", conn);
            dCmd.CommandType = CommandType.StoredProcedure;
            
            try
            {
                dCmd.Parameters.AddWithValue("@PNome", Nome); //nome
                dCmd.Parameters.AddWithValue("@PEmail", Endereco); //Endereco                      
           
                return dCmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                dCmd.Dispose();
                conn.Close();
                conn.Dispose();
            }

            

        }




    }
}
