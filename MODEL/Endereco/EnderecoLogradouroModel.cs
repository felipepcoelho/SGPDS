using FRAMEWORK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Endereco
{
    [Serializable]
    public class EnderecoLogradouroModel: IModel
    {
        public Int64 ID { get; set; }
        public string nome { get; set; }
        public Int64 cep { get; set; }
        public EnderecoBairroModel bairro { get; set; }

        public EnderecoLogradouroModel() {
            this.bairro = new EnderecoBairroModel();
        }

        public IModel clone()
        {
            throw new NotImplementedException();
        }
    }
}
