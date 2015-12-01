using FRAMEWORK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.usuario
{
    public class UsuarioTipoModel: IModel
    {
        public int ID { get; set; }
        public string Descricao { get; set; }

        public UsuarioTipoModel() {
        }

        public UsuarioTipoModel(UsuarioTipoModel model)
        {
            this.ID = model.ID;
            this.Descricao = model.Descricao;
        }

        public IModel clone()
        {
            return new UsuarioTipoModel(this);
        }
    }
}
