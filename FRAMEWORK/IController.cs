using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRAMEWORK
{
    public interface IController
    {
        void cadastrar(IModel model);
        void deletar(IModel model);
        Object consultar(IModel model);
    }

}
