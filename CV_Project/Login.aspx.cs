using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV_Project
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        CVEntityEntities db = new CVEntityEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLKULLANİCİ where x.KULLANICIAD == Txtkullaniciadi.Text && x.SIFRE == Txtsifre.Text select x;
            if(sorgu.Any()) //Tanımlanan int türündeki dizideki değerlerin belirlenen koşullara göre koleksiyonda olup olmadığı kontrol edilir. Koşula uygun değer var ise True, yok ise False sonucu döner.
            {
                Session["control"] = Txtkullaniciadi.Text;
                Response.Redirect("istatistik.aspx");
            }
            else
            {
                Label1.Text = "Hatalı Kullanıcı Adı ya da Şifre girdiniz.";
                //Response.Write("Hatalı Kullanıcı Adı ya da Şifre girdiniz.");
            }
        }
    }
}