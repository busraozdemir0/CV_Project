using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV_Project
{
    public partial class HakkimdaGuncelle : System.Web.UI.Page
    {
        CVEntityEntities db = new CVEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var deger = db.TBLHAKKIMDA.Find(id);
                Txtadsoyad.Text = deger.ADSOYAD;
                Txtegitim.Text = deger.EGITIM;
                Txtisdeneyim.Text = deger.ISDENEYIMLERI;
                Txtmeslek.Text = deger.MESLEK;
                Txtgorsel.Text = deger.GORSELURL;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            var deger = db.TBLHAKKIMDA.Find(id);
            deger.ADSOYAD = Txtadsoyad.Text;
            deger.EGITIM = Txtegitim.Text;
            deger.ISDENEYIMLERI = Txtisdeneyim.Text;
            deger.MESLEK = Txtmeslek.Text;
            deger.GORSELURL = Txtgorsel.Text;
            db.SaveChanges();
            Response.Redirect("Hakkimda.aspx");
        }
    }
}