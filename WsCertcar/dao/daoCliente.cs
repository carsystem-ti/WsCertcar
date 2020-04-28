using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace WsCertcar.dao
{
    public class daoCliente
    {
        public DataTable getCliente(int tipo,string documento)
        {
            ConnectionStringSettings getString = WebConfigurationManager.ConnectionStrings["getcliente"] as ConnectionStringSettings;

            DataTable dt_Cliente = new DataTable();
            if (getString != null)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(getString.ConnectionString))
                    {
                        conn.Open();


                        SqlCommand cmd = new SqlCommand("Plus.[SegAP].[pro_GetDadosApolice]", conn);
                        cmd.Parameters.AddWithValue("@tp", tipo);
                        cmd.Parameters.AddWithValue("@nr_doc", documento);

                        cmd.CommandTimeout = 160;
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt_Cliente);
                    }
                }
                catch (SqlException ex)
                {
                    throw new global::System.Data.StrongTypingException("'Procure o Administrador'", ex);
                }
            }
            return dt_Cliente;
        }
    }
}