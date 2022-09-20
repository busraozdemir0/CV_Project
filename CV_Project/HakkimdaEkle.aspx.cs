using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV_Project
{
    public partial class HakkimdaEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CVEntityEntities db = new CVEntityEntities();
            TBLHAKKIMDA t = new TBLHAKKIMDA();
            t.ADSOYAD = Txtadsoyad.Text;
            t.EGITIM = Txtegitim.Text;
            t.ISDENEYIMLERI = Txtisdeneyim.Text;
            t.MESLEK = Txtmeslek.Text;
            t.GORSELURL = Txtgorsel.Text;
            db.TBLHAKKIMDA.Add(t);
            db.SaveChanges();
            Response.Redirect("Hakkimda.aspx");
        }
    }
}