using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace hortus.Connection
{
    public class Connection
    {
        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;
        protected SqlDataReader sqlDataReader;

        protected void OpenConnection()
        {
            try
            {
                sqlConnection = new SqlConnection( @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matheus.gomes\Documents\hortus_db.mdf;Integrated Security=True;Connect Timeout=30" );
                sqlConnection.Open();
            }
            catch( Exception e )
            {
                throw new Exception( "Erro ao abrir conexão: " + e.Message );
            }
        }

        protected void CloseConnection()
        {
            try
            {
                if( sqlConnection != null )
                {
                    sqlConnection.Close();
                }
            }
            catch( Exception e )
            {
                throw new Exception( "Erro ao fechar conexão: " + e.Message );
            }
        }
    }
}