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
            var sorgu = from x in db.TBLADMIN where x.KULLANICIAD == TextBox1.Text && x.SIFRE == TextBox2.Text select x;
            if(sorgu.Any()) //eğer sorgunun içerisinde bir şey varsa textboxlardan gelen değerler eşleştirebiliyorsa Any içerisinde bir şey olacaktır
            {
                Response.Redirect("istatistik.aspx");
            }
            else
            {
                Response.Write("Hatalı Kullanıcı Adı ya da Şifre girdiniz.");
            }
        }
    }
}