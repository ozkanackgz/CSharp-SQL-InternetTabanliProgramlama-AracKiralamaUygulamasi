using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBModel;

namespace webarackiralama
{
    public partial class aracTanim : System.Web.UI.Page
    {
        ModelDERSITP context = new ModelDERSITP();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ModelDERSITP context = new ModelDERSITP();
                cmbSinifi.DataSource = context.REF_SINIFI.ToList();
                cmbSinifi.DataTextField = "ARACSINIFI";
                cmbSinifi.DataValueField = "KOD";
                cmbSinifi.DataBind();

                lblMesaj.Visible = false;

                if (Request.QueryString["p1"] != null)
                {
                    if (Request.QueryString["sil"] != null && Request.QueryString["sil"].ToString() == "1")
                        btnKaydet.Text = "Sil";
                    else
                        btnKaydet.Text = "Güncelle";
                    int pID = Convert.ToInt32(Request.QueryString["p1"]);
                    ARACLAR arac = context.ARACLAR.FirstOrDefault(a => a.ID == pID && a.AKTIF == true);
                    if (arac != null)
                    {
                        cmbSinifi.SelectedValue = arac.KOD_REF_SINIFI.ToString();
                        txtMarka.Text = arac.MARKA;
                        txtModel.Text = arac.MODEL;
                        txtGunlukFiyat.Text = arac.GUNLUKFIYAT.ToString().Replace(',', '.');
                        txtModelYil.Text = arac.MODELYILI.ToString();
                        rdVites.SelectedValue = Convert.ToInt16(arac.EH_VITESOT).ToString();
                        txtAciklama.Text = arac.ACIKLAMA;
                        chkUygun.Checked = arac.EH_UYGUN;
                    }
                }
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            ARACLAR ya = new ARACLAR();
            lblMesaj.Text = "Araç Kaydı Yapıldı!";
            if (Request.QueryString["p1"] != null)
            {
                int pID = Convert.ToInt32(Request.QueryString["p1"]);
                ya = context.ARACLAR.FirstOrDefault(a => a.ID == pID && a.AKTIF == true);
                lblMesaj.Text = "Araç Kaydı Güncellendi!";
            }
            ya.KOD_REF_SINIFI = Convert.ToInt16(cmbSinifi.SelectedValue);
            ya.MARKA = txtMarka.Text;
            ya.MODEL = txtModel.Text;
            ya.GUNLUKFIYAT = Convert.ToDecimal(txtGunlukFiyat.Text);
            ya.MODELYILI = Convert.ToInt16(txtModelYil.Text);
            ya.EH_VITESOT = Convert.ToBoolean(Convert.ToInt16(rdVites.SelectedValue));
            ya.ACIKLAMA = txtAciklama.Text;
            ya.EH_UYGUN = Convert.ToBoolean(chkUygun.Checked);
            if (Request.QueryString["sil"] != null && Request.QueryString["sil"].ToString() == "1")
            {
                ya.AKTIF = false;
                lblMesaj.Text = "Araç Kaydı Silindi!";
            }
            else
                ya.AKTIF = true;

            context.ARACLAR.AddOrUpdate(ya);
            context.SaveChanges();
            lblMesaj.Visible = true;
            btnKaydet.Enabled = false;
        }
    }
}