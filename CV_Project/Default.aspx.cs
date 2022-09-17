using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV_Project
{
    public partial class Default : System.Web.UI.Page
    {
        CVEntityEntities db = new CVEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TBLHAKKIMDA.ToList(); //veri kaynağı hakkımda tablosundan gelen değer olacak
            Repeater1.DataBind(); //veriyi bağla
            Repeater2.DataSource = db.TBLHAKKIMDA.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = db.TBLHAKKIMDA.ToList();
            Repeater3.DataBind();
            Repeater4.DataSource = db.TBLYETENEKLER.ToList();
            Repeater4.DataBind();
            Repeater5.DataSource = db.TBLADRES.ToList();
            Repeater5.DataBind();
            Repeater6.DataSource = db.TBLADRES.ToList();
            Repeater6.DataBind();
            Repeater7.DataSource = db.TBLADRES.ToList();
            Repeater7.DataBind();
            Repeater8.DataSource = db.TBLADRES.ToList();
            Repeater8.DataBind();
        }
    }
}