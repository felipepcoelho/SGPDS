using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UTILS;

namespace SGPDS
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bLogar_Click(object sender, EventArgs e)
        {
            try
            {
                TratamentoDeString.verificarCaracterEspecial(tbLogin.Text);
                TratamentoDeString.verificarCaracterEspecial(tbSenha.Text);
            }catch(Exception){
                
            }
        }
    }
}