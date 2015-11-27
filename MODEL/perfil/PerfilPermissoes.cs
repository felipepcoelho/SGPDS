using FRAMEWORK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.perfil
{
    public class PerfilPermissoes: IModel
    {
        public int ID { get; set; }
        public Guid chave { get; set; }
        public string pagina { get; set;}

        public PerfilPermissoes() { }

        public PerfilPermissoes(PerfilPermissoes model) {
            this.ID = model.ID;
            this.chave = model.chave;
            this.pagina = model.pagina;
        }

        public IModel clone()
        {
            return new PerfilPermissoes(this);
        }
    }
}
