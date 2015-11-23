using FRAMEWORK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.usuario
{
    public class UsuarioCadastroModel:IModel
    {
        #region Atributos
        private int id;
        private string nome;
        private int idade;
        private DateTime dataNascimento;
        private string cpf;
        private string rg;
        #endregion

        #region Encapsulamento
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }


        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }


        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }


        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public int ID {
            get { return this.id; }
            set { this.id = value; }
        }

        #endregion

        #region Construtores
        public UsuarioCadastroModel() { }

        public UsuarioCadastroModel(UsuarioCadastroModel model) { 
            
        }
#endregion

        public IModel clone()
        {
            throw new NotImplementedException();
        }
    }
}
