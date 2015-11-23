using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTILS
{
    public class Conexao
    {
        public static string Local
        {
            get { return @"Data Source=.\SQLExpress;Initial Catalog=SGAPS;Integrated Security=True"; }
        }
        
    }
}
