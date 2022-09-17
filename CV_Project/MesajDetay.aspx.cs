using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV_Project
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CVEntityEntities db = new CVEntityEntities();
            int id = int.Parse(Request.QueryString["ID"]);
            var mesaj = db.TBLILETISIM.Find(id);
            txtadsoyad.Text = mesaj.ADSOYAD;
            txtmail.Text = mesaj.MAIL;
            txtkonu.Text = mesaj.KONU;
            txtmesaj.Text = mesaj.MESAJ;
        }
    }
}