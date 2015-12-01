using FRAMEWORK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Endereco
{
    [Serializable]
    public class EnderecoCidadeModel: IModel
    {
        public int ID { get; set; }
        public String nome { get; set; }
        public EnderecoEstadoModel estado { get; set; }

        public EnderecoCidadeModel() {
            this.estado = new EnderecoEstadoModel();
        }

        public IModel clone()
        {
            throw new NotImplementedException();
        }
    }
}
