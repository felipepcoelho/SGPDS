using FRAMEWORK;
using MODEL.perfil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.usuario
{
    public class UsuarioCadastroModel:IModel
    {

        public int ID { get; set; }
        public string Nome {get;set;}
        public int Idade {get;set;}
        public DateTime DataNascimento{get;set;}
        public string Cpf {get;set;}
        public string Rg{get;set;}
        public PerfilTiposModel PefilTipos { get; set; }

        public UsuarioCadastroModel() {
            this.PefilTipos = new PerfilTiposModel();
        }

        public UsuarioCadastroModel(UsuarioCadastroModel model) {
            this.ID = model.ID;
            this.Nome = model.Nome;
            this.Idade = model.Idade;
            this.DataNascimento = model.DataNascimento;
            this.PefilTipos = model.PefilTipos;

        }

        public IModel clone()
        {
            throw new NotImplementedException();
        }
    }
}
