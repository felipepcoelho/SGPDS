using MODEL.acesso;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLLER
{
    public class AcessoDadosController: ConcreteController
    {

        public override void cadastrar(FRAMEWORK.IModel model)
        {
            string sql = @"INSERT INTO ACESSO.GAPS_ACESSO_DADOS
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
                command.Parameters.Add("@login",System.Data.SqlDbType.NVarChar).Value = acessoModel.Login;
                command.Parameters.Add("@senha",System.Data.SqlDbType.NVarChar).Value = acessoModel.Senha;
                command.Parameters.Add("@ID_cadastroUsuario",System.Data.SqlDbType.NVarChar).Value = acessoModel.usuario.ID;
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

        public override FRAMEWORK.IModel consultar(FRAMEWORK.IModel model)
        {
            throw new NotImplementedException();
        }
    }
}
