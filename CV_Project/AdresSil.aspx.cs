using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV_Project
{
    public partial class AdresSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CVEntityEntities db = new CVEntityEntities();
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            var adresId = db.TBLADRES.Find(id);
            db.TBLADRES.Remove(adresId);
            db.SaveChanges();
            Response.Redirect("Adres.aspx");
        }
    }
}