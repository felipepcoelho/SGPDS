using MODEL.acesso;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTILS;

namespace CONTROLLER
{
    public class AcessoDadosController: ConcreteController
    {

        public override void cadastrar(FRAMEWORK.IModel model)
        {
            string sql = @"INSERT INTO ACESSO.SGPDS_ACESSO_DADOS
                                   (login
                                   ,senha
                                   ,ID_cadastroUsuario)
                             VALUES
                                   (@login
                                   ,@senha
                                   ,@ID_cadastroUsuario)";
            try
            {
                AcessoDadosModel acessoModel = (AcessoDadosModel) model;
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.Add("@login", System.Data.SqlDbType.NVarChar).Value = acessoModel.Login.ToUpper();
                command.Parameters.Add("@senha", System.Data.SqlDbType.NVarChar).Value = acessoModel.Senha.ToUpper();
                command.Parameters.Add("@ID_cadastroUsuario",System.Data.SqlDbType.NVarChar).Value = acessoModel.Usuario.ID;
                this.executeCommand(command);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
            
            }
        }

        public override void deletar(FRAMEWORK.IModel model)
        {
            throw new NotImplementedException();
        }

        public override Object consultar(FRAMEWORK.IModel model)
        {
            string sql = @"SELECT  ID
                                  ,login
                                  ,senha
                                  ,ID_cadastroUsuario
                              FROM ACESSO.SGPDS_ACESSO_DADOS
                              WHERE login = @login AND senha = @senha";
            SqlConnection conn = new SqlConnection(Conexao.Local);
            SqlCommand command = new SqlCommand(sql,conn);
            try {
                AcessoDadosModel acessoModel = (AcessoDadosModel) model;
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                command.Parameters.Add("@login",System.Data.SqlDbType.NVarChar).Value = acessoModel.Login.ToUpper();
                command.Parameters.Add("@senha", System.Data.SqlDbType.NVarChar).Value = acessoModel.Senha.ToUpper();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read()) 
                {
                    acessoModel.ID = Convert.ToInt32(dr["ID"]);
                    dr.Close();
                    return model;
                }
            }catch(Exception ex){
                throw ex;
            }finally{
                conn.Close();
               
            }
            return new Exception("Não foi encontrado nenhum usuário com os dados informados!!");
        }
    }
}
