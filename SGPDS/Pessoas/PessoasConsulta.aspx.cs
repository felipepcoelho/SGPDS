using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGPDS.Pessoas
{
    public partial class PessoasConsulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack){
                if (Session["usuarioID"] == null)
                    Response.Redirect("../index.aspx");
                carregarSemPostBack();
            }
            carregarComPostBack();
        }

        public void carregarComPostBack() 
        {
            gvPessoasCadastradasExibir();
        }

        public void carregarSemPostBack()
        { 
        
        }

        private void gvPessoasCadastradasExibir() {
            this.controlePanelDeDados(pComDados, pSemDados, gvPessoasCadastradas);
        }

        private void controlePanelDeDados(Panel comDados,Panel semDados, GridView gridView){
            if (gridView.Rows.Count == 0)
            {
                comDados.Visible = false;
                semDados.Visible = true;
            }
            else
            {
                comDados.Visible = true;
                semDados.Visible = false;
            }
        
        }

        protected void bNovo_Click(object sender, EventArgs e)
        {
            Response.Redirect("PessoasCadastro.aspx");
        }
    }
}