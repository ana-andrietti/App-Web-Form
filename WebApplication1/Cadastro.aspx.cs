using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Login1.Mensagem = "Este é o form principal";
            mostrarLista();
        }

        private void mostrarLista()
        {
            pnlCamposCadastro.Visible = false;
            pnlResultado.Visible = true;

            gridResultado.DataSource = Usuario.Lista;
            gridResultado.DataBind();
        }

        private void mostrarCadastro()
        {
            pnlCamposCadastro.Visible = true;
            pnlResultado.Visible = false;           
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            string caminhoArquivo = AppDomain.CurrentDomain.BaseDirectory + System.Configuration.ConfigurationManager.AppSettings["caminhoArquivo"] + @"\" + fileFoto.FileName;
            fileFoto.SaveAs(caminhoArquivo);

            var usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Telefone = txtTelefone.Text;
            usuario.Foto = System.Configuration.ConfigurationManager.AppSettings["caminhoArquivo"].Replace(@"\", "/") + "/" + fileFoto.FileName;
            usuario.Salvar();

            txtNome.Text = "";
            txtTelefone.Text = "";

            mostrarLista();
        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {          
            mostrarCadastro();
        }
    }    
}