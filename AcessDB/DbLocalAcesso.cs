using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDB
{
    public class DbLocalAcesso
    {
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        private bool conectado;
        SqlConnection conn; //acessa o banco online

        
        public bool Conectar()
        {
            DateTime tempo = DateTime.Now;
            int conta = 1; //conta quantas vezes o sistema tentou se conectar sem êxito

            while (true)
            {
                while (tempo <= DateTime.Now)
                {
                    conta++;

                    try
                    {
                        conn = new SqlConnection(DadosDB.ConexaoLocal);

                        conn.Open();
                        conectado = true;
                        return true;
                    }
                    catch (SqlException)
                    {
                        tempo = DateTime.Now;
                        double sec = 5 * conta;
                        tempo = tempo.AddSeconds(sec);

                        if (conta > 2)
                            return false;
                    }
                }
            }
        }

        private void LimparParametrosSql()
        {
            sqlParameterCollection.Clear();
        }

        public void AddParametrosSql(string nomeParametro, object valorParametros)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametros));
        }

        public bool ExecutarComandoSql(string cmdText)
        {
            if (conectado)
            {
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 3600;

                foreach (SqlParameter mySqlParameter in sqlParameterCollection)
                    cmd.Parameters.Add(mySqlParameter);

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
                finally
                {
                    LimparParametrosSql();
                    conn.Dispose();
                }
            }
            else
                return false;
        }

        public int ExecutarScalarSql(string cmdText)
        {
            if (conectado)
            {
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 3600;

                foreach (SqlParameter mySqlParameter in sqlParameterCollection)
                    cmd.Parameters.Add(mySqlParameter);

                try
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
                finally
                {
                    LimparParametrosSql();
                    conn.Dispose();
                }
            }
            else
                return 0;
        }

        public DataTable dataTableSql(string cmdText)
        {
            if (conectado)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(cmdText, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 3600;

                    foreach (SqlParameter parameter in sqlParameterCollection)
                        cmd.Parameters.Add(parameter);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    da.Fill(dt);
                    conn.Close();

                    if (dt.Rows.Count > 0)
                        return dt;
                    else
                        return null;
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
                finally
                {
                    LimparParametrosSql();
                    conn.Dispose();
                }
            }
            else
                return null;
        }
    }
}
