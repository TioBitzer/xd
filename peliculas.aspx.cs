using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace brunoplanilla
{
    public partial class peliculas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string idx= Request.QueryString["idx"];
            if (idx !=null &&( idx=="cartelera" || idx = "estrenos"))
            {
                rptPeliculas.DataSource=new dao.PeliculaDAO(.getPeliculas)
            }
        }
    }
}


