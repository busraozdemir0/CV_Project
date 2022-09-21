using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV_Project
{
    public partial class AdresGuncelle : System.Web.UI.Page
    {
        CVEntityEntities db = new CVEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var deger = db.TBLADRES.Find(id);
                Txttelefon.Text = deger.TELEFON;
                Txtmail.Text = deger.MAIL;
                Txtadres.Text = deger.ADRES;
                Txtkonum.Text = deger.KONUM;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            var deger = db.TBLADRES.Find(id);
            deger.TELEFON = Txttelefon.Text;
            deger.MAIL = Txtmail.Text;
            deger.ADRES = Txtadres.Text;
            deger.KONUM = Txtkonum.Text;
            db.SaveChanges();
            Response.Redirect("Adres.aspx");
        }
    }
}