using FRAMEWORK;
using MODEL.usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.acesso
{
    public class AcessoDadosModel:IModel
    {
        #region Atributos
        public int ID {get;set;}
        public string Login { get; set; }
        public string Senha {get;set;}
        public UsuarioCadastroModel Usuario{get;set;}
        #endregion

        #region Construtores
        public AcessoDadosModel() {
            this.Usuario = new UsuarioCadastroModel();
        }

        public AcessoDadosModel(AcessoDadosModel model)
        {
            this.ID = model.ID;
            this.Login = model.Login;
            this.Senha = model.Senha;
            this.Usuario = model.Usuario;
        }
        #endregion

        public IModel clone()
        {
            return new AcessoDadosModel(this);
        }
    }
}
