using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WebApplication1
{
    public class Filtro : Page
    {
        public Filtro()
        {
            this.Page.Load += Page_Load;
            this.Page.Init += Page_Init;
            this.Page.PreInit += Page_PreInit;
            this.Page.LoadComplete += Page_LoadComplete;
            this.Page.PreRender += Page_PreRender;
        }

        private void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write(Request["param"]);
            Response.Write("oi pre Render <br><hr><br>");
        }

        private void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Request["param"]);
            Response.Write("oi Load <br><hr><br>");
        }

        private void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write(Request["param"]);
            Response.Write("oi LoadComplete <br><hr><br>");
        }

        private void Page_Init(object sender, EventArgs e)
        {
            Response.Write(Request["param"]);
            Response.Write("oi init <br><hr><br>");
        }

        private void Page_PreInit(object sender, EventArgs e)
        {
            /*var nome = this.ToString();
            Response.Write(nome);
            //exibe a página selecionada */

            Response.Write(Request["param"]);
            Response.Write("oi pre init <br><hr><br>");
        }
    }
}