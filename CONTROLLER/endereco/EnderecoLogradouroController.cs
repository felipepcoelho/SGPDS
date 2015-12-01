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
    public class EnderecoLogradouroController: IController
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
            string sql = @"SELECT ID,ID_bairro,nome,cep FROM ENDERECO.SGPDS_ENDERECO_LOGRADOURO
                                WHERE cep = @cep";
            EnderecoLogradouroModel model = (EnderecoLogradouroModel) obj;
            SqlConnection con = new SqlConnection(Conexao.Local);
            SqlCommand command = new SqlCommand(sql,con);
            try { 
                if(con.State == System.Data.ConnectionState.Closed)
                    con.Open();
               command.Parameters.Add("@cep",System.Data.SqlDbType.BigInt).Value = model.cep;
               SqlDataReader dr = command.ExecuteReader();
               if (dr.Read()) {
                   model.ID = Convert.ToInt64(dr["ID"]);
                   model.bairro.ID = Convert.ToInt32(dr["ID_bairro"]);
                   model.nome = dr["nome"].ToString();
                   model.cep = Convert.ToInt64(dr["cep"]);

                   model = this.buscarDadosBairro(model);
               }
               dr.Close();
               return model; 
            }catch(Exception ex){
                throw ex;
            
            }finally{
                con.Close();
            }
        }

        private EnderecoLogradouroModel buscarDadosBairro(EnderecoLogradouroModel model)
        {
            try 
            { 
            EnderecoBairroController controller = new EnderecoBairroController();
            model.bairro = (EnderecoBairroModel) controller.consultar(model.bairro);
            return model;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
