using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV_Project
{
    public partial class AdresEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CVEntityEntities db = new CVEntityEntities();
            TBLADRES t = new TBLADRES();
            t.TELEFON = Txttelefon.Text;
            t.MAIL= Txtmail.Text;
            t.ADRES = Txtadres.Text;
            t.KONUM = Txtkonum.Text;
            db.TBLADRES.Add(t);
            db.SaveChanges();
            Response.Redirect("Adres.aspx");
        }
    }
}