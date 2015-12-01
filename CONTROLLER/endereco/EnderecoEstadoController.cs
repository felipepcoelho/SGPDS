using FRAMEWORK;
using MODEL.Endereco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTILS;

namespace CONTROLLER.endereco
{
    public class EnderecoEstadoController:IController 
    {
        public void cadastrar(IModel model)
        {
            throw new NotImplementedException();
        }

        public void deletar(IModel model)
        {
            throw new NotImplementedException();
        }

        public object consultar(IModel obj)
        {
            string sql = @"SELECT ID,uf,nome
                          FROM ENDERECO.SGPDS_ENDERECO_ESTADO
                    where ID = @ID";

            EnderecoEstadoModel model = (EnderecoEstadoModel)obj;
            SqlConnection con = new SqlConnection(Conexao.Local);
            SqlCommand command = new SqlCommand(sql, con);
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                command.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = model.ID;
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    model.nome = dr["nome"].ToString();
                    model.ID = Convert.ToInt32(dr["ID"]);
                    model.UF = dr["uf"].ToString();
                }
                dr.Close();
                return model;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();
            }
        }
    }
}
