using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV_Project
{
    public partial class YetenekSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CVEntityEntities db = new CVEntityEntities();
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            var yetenek = db.TBLYETENEKLER.Find(id);
            db.TBLYETENEKLER.Remove(yetenek);
            db.SaveChanges();
            Response.Redirect("Yetenekler.aspx");
        }
    }
}