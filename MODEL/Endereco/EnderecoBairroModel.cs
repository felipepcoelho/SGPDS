using FRAMEWORK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Endereco
{
    [Serializable]
    public class EnderecoBairroModel: IModel
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public EnderecoCidadeModel cidade { get; set; }

        public EnderecoBairroModel() {
            this.cidade = new EnderecoCidadeModel();
        }

        public IModel clone()
        {
            throw new NotImplementedException();
        }
    }
}
