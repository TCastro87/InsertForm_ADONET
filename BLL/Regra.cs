using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Regra
    {
        //Inserção 
        public int Inserir_Dados(string TxtNome, string TxtEnd)
        {
            Dados pDAL = new Dados();
            try
            {
                return pDAL.Inserir_DadosCadastro(TxtNome, TxtEnd);
            }
            catch
            {
                throw;
            }
            finally
            {
                pDAL = null;
            }

        }
    }
}
