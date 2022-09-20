using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV_Project
{
    public partial class istatistik : System.Web.UI.Page
    {
        CVEntityEntities db = new CVEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label5.Text = " ~ Hoşgeldin " + Session["control"]+ " ~";

            Label1.Text = db.TBLYETENEKLER.Count().ToString();
            Label2.Text = db.TBLILETISIM.Count().ToString();
            Label3.Text = db.TBLYETENEKLER.Average(x => x.DERECE).ToString().Substring(0,4);
            Label4.Text = db.TBLYETENEKLER.Max(x => x.DERECE).ToString();
        }
    }
}