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
            Repeater9.DataSource = db.TBLHAKKIMDA.ToList();
            Repeater9.DataBind();
            Repeater10.DataSource = db.TBLHAKKIMDA.ToList();
            Repeater10.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLILETISIM t = new TBLILETISIM();
            t.ADSOYAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.KONU = TextBox3.Text;
            t.MESAJ = TextBox4.Text;
            db.TBLILETISIM.Add(t);
            db.SaveChanges();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TBLILETISIM t = new TBLILETISIM();
            t.ADSOYAD = " ";
            t.MAIL = " ";
            t.KONU = " ";
            t.MESAJ = " ";

        }
    }
}