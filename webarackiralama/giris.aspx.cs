using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using System.Drawing;
using DBModel;

namespace webarackiralama
{
    public partial class giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Session.Clear();
                Session.Abandon();
            }
        }

        protected void btnSistemeGiris_Click(object sender, EventArgs e)
        {
            string kadi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            DBModel.ModelDERSITP context = new DBModel.ModelDERSITP();
            KULLANICI k = context.KULLANICI.FirstOrDefault(p => p.KULLANICIADI == kadi && p.SIFRE == sifre);
            if (k != null)
            {
                Session["auth"] = true;
                Session["kullanici"] = k;
                Response.Redirect("anasayfa.aspx");
            }
            else
            {
                lblMesaj.Text = "Kullanıcı adı ve şifrenizi kontrol ediniz";
                lblMesaj.ForeColor = Color.Red;
            }


        }
    }
}