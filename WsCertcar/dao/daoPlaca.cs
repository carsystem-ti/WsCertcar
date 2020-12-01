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
    public class daoPlaca
    {
        public DataTable getPlaca(string ds_placa)
        {
            ConnectionStringSettings getString = WebConfigurationManager.ConnectionStrings["cns"] as ConnectionStringSettings;

            DataTable dt_Cliente = new DataTable();
            if (getString != null)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(getString.ConnectionString))
                    {
                        conn.Open();


                        SqlCommand cmd = new SqlCommand("Principal.Venda.pro_getNortixManual", conn);
                        cmd.Parameters.AddWithValue("@ds_placa", ds_placa);
                        cmd.Parameters.AddWithValue("@tipo", 2);
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
        public int set_PlacaNortix(int ano, string placaveiculo, int id_sucateamento, string modelo, string fabricante,
                                 string chassi, string renavan, string nr_motor,
                                 int nr_anoVeiculo, int anoFabricacao)
        {
            ConnectionStringSettings getString = WebConfigurationManager.ConnectionStrings["cns"] as ConnectionStringSettings;

            int id_processo = 0;
            if (getString != null)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(getString.ConnectionString))
                    {
                        conn.Open();


                        SqlCommand cmd = new SqlCommand("Principal.[Venda].[pro_setPlacaNortixManual]", conn);
                        cmd.Parameters.AddWithValue("@id_modelo", 0);
                        cmd.Parameters.AddWithValue("@nr_ano", ano);
                        cmd.Parameters.AddWithValue("@ds_placa", placaveiculo);
                        cmd.Parameters.AddWithValue("@id_sucateamento", id_sucateamento);
                        cmd.Parameters.AddWithValue("@ds_modelo", modelo);
                        cmd.Parameters.AddWithValue("@ds_fabricante", fabricante);
                        cmd.Parameters.AddWithValue("@ds_chassi", chassi);
                        cmd.Parameters.AddWithValue("@ds_renavan", renavan);
                        cmd.Parameters.AddWithValue("@nr_motor", nr_motor);
                        cmd.Parameters.AddWithValue("@nr_anoModelo", nr_anoVeiculo);
                        cmd.Parameters.AddWithValue("@nr_anoFabricacao", anoFabricacao);

                        cmd.CommandTimeout = 160;
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        id_processo = cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    throw new global::System.Data.StrongTypingException("'Procure o Administrador'", ex);
                }
            }
            return id_processo;
        }
   
    }
}