using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDB
{
    public class DadosDB
    {
        public static string AccessServer { get { return "server=LOCALHOST;user id=nandolevit;password=@wizykovisc87;SslMode=none;database=levittech"; } }
        //public static string AccessServer { get { return "server=levittech.mysql.uhserver.com;user id=nandolevit;password=@wizykovisc87;SslMode=none;database="; } }
        //public static string AccessServer { get { return "server=localhost;user id=nandolevit;password=@wizykovisc87;SslMode=none;database="; } }
        public static string ConexaoSys { get { return "server=empresadb.mysql.uhserver.com;user id=nandolevita;password=@wizykovisc87;database=empresadb;SslMode=none"; } }
        //public static string ConexaoSys{ get { return "server=localhost;user id=nandolevit;password=@wizykovisc87;database=empresadb;SslMode=none"; } }
        public static string DiretorioFolder { get { return @"C:\Users\Public\LevitSoft"; } }
        public static string ConexaoLocal { get { return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Public\LevitSoft\dblevitsoft.mdf;Integrated Security=True;Connect Timeout=30"; } }
    }
}
