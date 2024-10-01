using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webarackiralama
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["auth"] == null || Session["kullanici"] == null)
            {
                Response.Redirect("giris.aspx");
            }
            if ((bool)Session["auth"] != true)
            {
                Response.Redirect("giris.aspx");
            }
            KULLANICI k = (KULLANICI)Session["kullanici"];
            lblKullanici.Text = k.ADSOYAD + " (" + k.EPOSTA + ")";
        }
    }
}