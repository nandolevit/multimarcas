using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class ValidarCpfCnpj
    {
        private string cpfCnpj;

        public ValidarCpfCnpj(string cpfCnpjNum)
        {
            cpfCnpj = cpfCnpjNum;
        }

        public bool CpfCpnjValido()
        {
            if (cpfCnpj.Length == 11)
                return IsCpf();
            else if (cpfCnpj.Length == 14)
                return IsCnpj();
            else
                return false;
        }

        private bool IsCpf()
        {

            if (!CpfValido())
                return false;

            //criação de vetores
            int[] mult1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mult2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            //criação de string
            string tempCpf, digito;

            //criação de variável
            int soma, resto, i;

            tempCpf = cpfCnpj.Substring(0, 9);
            soma = 0;

            //verificando o primeiro dígito
            for (i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * mult1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf += digito;

            //verificando o segundo dígito
            soma = 0;

            for (i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * mult2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;


            digito += resto.ToString();

            return cpfCnpj.EndsWith(digito);
        }

        //valida se o cpf é uma sequência de numero repetido ex.:111111
        private bool CpfValido()
        {
            if (cpfCnpj.Length == 11)
            {

                int cont = 0;
                for (int i = 0; i < cpfCnpj.Length; i++)
                {
                    char l = cpfCnpj[i];
                    if (cpfCnpj[0] == l)
                    {
                        ++cont;
                    }
                }

                if (cont < 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
        }

        //==========================================


        private bool IsCnpj()
        {
            int[] mult1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mult2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCnpj, digito;
            int soma, resto, i;

            tempCnpj = cpfCnpj.Substring(0, 12);
            soma = 0;

            //validando o primeiro dígito
            for (i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * mult1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCnpj += digito;

            //validando o segundo dígito

            soma = 0;

            for (i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * mult2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            return cpfCnpj.EndsWith(digito);
        }
    }
}
