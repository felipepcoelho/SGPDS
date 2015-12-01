using FRAMEWORK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Endereco
{
    [Serializable]
    public class EnderecoEstadoModel: IModel
    {
        public int ID { get; set; }
        public string UF { get; set; }
        public string nome { get; set; }

        public IModel clone()
        {
            throw new NotImplementedException();
        }
    }
}
