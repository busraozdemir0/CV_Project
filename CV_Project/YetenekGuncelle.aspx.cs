using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV_Project
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        CVEntityEntities db = new CVEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var deger = db.TBLYETENEKLER.Find(id);
                TextBox1.Text = deger.YETENEK;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            var deger = db.TBLYETENEKLER.Find(id);
            deger.YETENEK = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Yetenekler.aspx");
        }
    }
}