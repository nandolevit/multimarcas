using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObjTransfer;
using System.Data;
using Correios.Net;

namespace AccessDB
{
    public class CepDB
    {
        private string cep;

        public CepDB(string cepArg)
        {
            cep = cepArg;
        }

        //não utilizado
        public CepInfo BuscaCepCorreios()
        {
            CepInfo cepI = new CepInfo();
            Address address = SearchZip.GetAddress(cep);

            if (address.Zip != null)
            {
                cepI.Bairro = address.District;
                cepI.Cep = cep;
                cepI.Cidade = address.City;
                cepI.Logradouro = address.Street;
                cepI.Uf = address.State;

                return cepI;
            }
            else
                return null;
        }

        public CepInfo BuscarCorreios()
        {
            CepInfo cepI = new CepInfo();

            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", cep);
                ds.ReadXml(xml);

                if(Convert.ToInt32(ds.Tables[0].Rows[0]["resultado"].ToString()) != 0)
                {
                    cepI.Logradouro = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString().ToUpper() + " " + ds.Tables[0].Rows[0]["logradouro"].ToString().ToUpper();
                    cepI.Bairro = ds.Tables[0].Rows[0]["bairro"].ToString().ToUpper();
                    cepI.Cidade = ds.Tables[0].Rows[0]["cidade"].ToString().ToUpper();
                    cepI.Uf = ds.Tables[0].Rows[0]["uf"].ToString().ToUpper();

                    return cepI;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                return null;
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}
