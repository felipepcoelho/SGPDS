using FRAMEWORK;
using MODEL.usuario;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLLER.usuario
{
    public class UsuarioCadastroController: ConcreteController
    {
        public override void cadastrar(IModel obj)
        {
            string sql = @"INSERT INTO SGAPS.USUARIO.SGPDS_USUARIO_CADASTRO
                           (nome
                           ,idade
                           ,dataNascimento
                           ,ID_usuarioTipo
                           ,email
                           ,ID_enderoLogradouro
                           ,cpf
                           ,rg)
                     VALUES
                           (@nome
                           ,@idade
                           ,@dataNascimento
                           ,@ID_usuarioTipo
                           ,@email
                           ,@ID_enderoLogradouro
                           ,@cpf
                           ,@rg)";
            try
            {
                UsuarioCadastroModel model = (UsuarioCadastroModel)obj;
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar).Value = model.Nome.ToUpper();
                command.Parameters.Add("@idade", System.Data.SqlDbType.Int).Value = model.Idade;
                command.Parameters.Add("@dataNascimento", System.Data.SqlDbType.DateTime).Value = model.DataNascimento;
                command.Parameters.Add("@ID_usuarioTipo", System.Data.SqlDbType.Int).Value = model.tipo.ID;
                command.Parameters.Add("@ID_enderoLogradouro", System.Data.SqlDbType.BigInt).Value = model.logradouro.ID;
                command.Parameters.Add("@email", System.Data.SqlDbType.NVarChar).Value = model.email.ToUpper();
                command.Parameters.Add("@cpf", System.Data.SqlDbType.NVarChar).Value = model.Cpf.ToUpper();
                command.Parameters.Add("@rg", System.Data.SqlDbType.NVarChar).Value = model.Rg.ToUpper();
                this.executeCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void deletar(IModel model)
        {
            throw new NotImplementedException();
        }

        public override object consultar(IModel model)
        {
            throw new NotImplementedException();
        }
    }
}
