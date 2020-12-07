using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace AccessDB
{
    public class AccessDbMySql
    {
        public AccessDbMySql(){}
        private bool conectado;
        private MySqlParameterCollection mySqlParameterCollection = new MySqlCommand().Parameters;

        MySqlConnection conn; //acessa o banco online

        public bool ConectarSys()
        {
            return Conectar(DadosDB.ConexaoSys);
        }

        public void FecharConexao()
        {
            conn.Close();
            conn.Dispose();
        }

        public bool ConectarSemPersistencia(string empaccess)
        {
            try
            {
                conn = new MySqlConnection(empaccess);

                conn.Open();
                conectado = true;
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }

        public bool ConectarOffline(string empaccess)
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
                        conn = new MySqlConnection(empaccess);

                        conn.Open();
                        conectado = true;
                        return true;
                    }
                    catch (MySqlException)
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

        public bool Conectar(string empaccess)
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
                        conn = new MySqlConnection(empaccess);

                        conn.Open();
                        conectado = true;
                        return true;
                    }
                    catch (MySqlException)
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

        private void LimparParametrosMySql()
        {
            mySqlParameterCollection.Clear();
        }

        public void AddParametrosMySql(string nomeParametro, object valorParametros)
        {
            mySqlParameterCollection.Add(new MySqlParameter(nomeParametro, valorParametros));
        }

        public bool ExecutarComandoMySql(string cmdText)
        {
            if (conectado)
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 3600;

                foreach (MySqlParameter mySqlParameter in mySqlParameterCollection)
                    cmd.Parameters.Add(mySqlParameter);

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (MySqlException ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
                finally
                {
                    LimparParametrosMySql();
                    conn.Dispose();
                }
            }
            else
                return false;
        }

        public int ExecutarScalarMySql(string cmdText)
        {
            if (conectado)
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 3600;

                foreach (MySqlParameter mySqlParameter in mySqlParameterCollection)
                    cmd.Parameters.Add(mySqlParameter);

                try
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (MySqlException ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
                finally
                {
                    LimparParametrosMySql();
                    conn.Dispose();
                }
            }
            else
                return 0;
        }

        public DataTable dataTableMySql(string cmdText)
        {
            if (conectado)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 3600;

                    foreach (MySqlParameter parameter in mySqlParameterCollection)
                        cmd.Parameters.Add(parameter);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
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
                catch (MySqlException ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
                finally
                {
                    LimparParametrosMySql();
                    conn.Dispose();
                }
            }
            else
                return null;
        }

    }
}
