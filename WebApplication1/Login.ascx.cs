using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.UserControl
    {
        public string Mensagem;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = Mensagem;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == "Ana" && txtSenha.Text == "12345678")
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(),"alerta", "<script>alert('" + txtLogin.Text + " entrou com sucesso');</script>");
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(),"alerta", "<script>alert('" + txtLogin.Text + " não existe na base de dados');</script>");
            }
        }
    }
}