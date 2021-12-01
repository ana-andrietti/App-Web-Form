using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : Filtro
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Session["email"]);
            Response.Write("<br>");
            Response.Write(Session["nome"]);
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            Session["email"] = txtEmail.Text;
            Session["nome"] = txtNome.Text;
        }
    }
    
}