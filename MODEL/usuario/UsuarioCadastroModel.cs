using FRAMEWORK;
using MODEL.Endereco;
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
        public string email { get; set; }
        public string telefoneCelular { get; set; }
        public string telefoneFixo { get; set; }
        public UsuarioTipoModel tipo { get; set; }
        public EnderecoLogradouroModel logradouro { get; set; }

        public UsuarioCadastroModel() {
            this.tipo = new UsuarioTipoModel();
            this.logradouro = new EnderecoLogradouroModel();
        }

        public UsuarioCadastroModel(UsuarioCadastroModel model) {
            this.ID = model.ID;
            this.Nome = model.Nome;
            this.Idade = model.Idade;
            this.DataNascimento = model.DataNascimento;
            this.tipo = model.tipo;
            this.email = model.email;
        }

        public IModel clone()
        {
            return new UsuarioCadastroModel(this);
        }
    }
}
