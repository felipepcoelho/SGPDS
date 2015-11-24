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
        public int ID { get; set; }
        public string Nome {get;set;}
        public int Idade {get;set;}
        public DateTime DataNascimento{get;set;}
        public string Cpf {get;set;}
        public string Rg{get;set;}
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
