using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV_Project
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CVEntityEntities db = new CVEntityEntities();
            TBLKULLANİCİ kullanici = new TBLKULLANİCİ();
            kullanici.ADSOYAD = Txtadsoyad.Text;
            kullanici.KULLANICIAD = Txtkullaniciadi.Text;
            kullanici.MAIL = Txtmail.Text;
            kullanici.SIFRE = Txtsifre.Text;
            db.TBLKULLANİCİ.Add(kullanici);
            db.SaveChanges();
            Response.Redirect("istatistik.aspx");
        }
    }
}