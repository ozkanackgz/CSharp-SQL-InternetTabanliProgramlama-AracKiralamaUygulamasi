using DBModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webarackiralama
{
    public partial class aracListesi : System.Web.UI.Page
    {
        ModelDERSITP context = new ModelDERSITP();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                
                gridAraclar.DataSource = context.V_ARACLAR.ToList();
                gridAraclar.DataBind();
            }
        }

        protected void gridAraclar_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string cn = e.CommandName.ToString();
            Int32 ca = Convert.ToInt32(e.CommandArgument.ToString());
            switch(cn)
            {
                case "g":
                    Response.Redirect("aracTanim.aspx?p1=" +  ca);
                    break;
                case "s":
                    Response.Redirect("aracTanim.aspx?p1=" + ca + "&sil=1");
                    //ARACLAR arac = context.ARACLAR.FirstOrDefault(p => p.ID == ca && p.AKTIF);
                    //if(arac != null)
                    //{
                    //    arac.AKTIF = false;
                    //    context.ARACLAR.AddOrUpdate(arac);
                    //    context.SaveChanges();
                    //}
                    break;
            }
        }
    }
}