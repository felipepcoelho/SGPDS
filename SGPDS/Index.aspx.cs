using CONTROLLER;
using FRAMEWORK;
using MODEL.acesso;
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
                IController controller = new AcessoDadosController();
                AcessoDadosModel model = new AcessoDadosModel();
                model.Login = tbLogin.Text;
                model.Senha = tbSenha.Text;
                model = (AcessoDadosModel) controller.consultar(model);
                criarSessaoUsuario(model);
                redirecionar();
            }catch(Exception){
                pAlertErro.Visible = true;
            }
        }

        private void criarSessaoUsuario(AcessoDadosModel model) { 
            Session["usuarioID"] = model.ID;
            Session["usuarioLogin"] = model.Login ;
            Session["usuarioSenha"] = model.Senha ;
        }

        private void redirecionar() {
            Response.Redirect("Menu.aspx");
        }

        protected void bAlertErroClose_Click(object sender, EventArgs e)
        {
            pAlertErro.Visible = false;
        }
    }
}