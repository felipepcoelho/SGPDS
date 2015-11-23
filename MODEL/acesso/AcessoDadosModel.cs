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
        private int id;
        private string login;
        private string senha;
        public UsuarioCadastroModel usuario;
        #endregion

        #region Encapsulamento
        public int ID {
            get { return this.id; }
            set { this.id = value;}
        }
        public string Login {
            get { return this.login; }
            set { 
                if (value.Length > 30)
                   throw new Exception("O Tamanho da palavra ultrapassa 30 caracters!");
                this.login = value;
            }
        }
        public string Senha {
            get { return this.senha; }
             set { 
                if (value.Length > 30)
                   throw new Exception("O Tamanho da palavra ultrapassa 30 caracters!");
                this.senha = value;
            }
        }
        #endregion

        #region Construtores
        public AcessoDadosModel() {
            this.usuario = new UsuarioCadastroModel();
        }

        public AcessoDadosModel(AcessoDadosModel model)
        {
            this.ID = model.ID;
            this.Login = model.Login;
            this.Senha = model.Senha;
            this.usuario = model.usuario;
        }
        #endregion

        public IModel clone()
        {
            return new AcessoDadosModel(this);
        }
    }
}
