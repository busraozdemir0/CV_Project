using System;
using System.Collections.Generic;
using System.IO;
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

            HttpPostedFile yuklenecekDosya = FileUpload1.PostedFile;
            if (yuklenecekDosya != null)
            {
                FileInfo dosyaBilgisi = new FileInfo(FileUpload1.FileName);

                string dosyaAdi = dosyaBilgisi.Name.Substring(0, dosyaBilgisi.Name.Length - dosyaBilgisi.Extension.Length);
                dosyaAdi += "-" + Guid.NewGuid().ToString().Replace("-", "") + dosyaBilgisi.Extension;
                string yuklemeYeri = Server.MapPath("~/Resimler/") + dosyaAdi;
                yuklenecekDosya.SaveAs(yuklemeYeri);

                string kayitYeri = "Resimler/" + dosyaAdi;
                t.GORSELURL = kayitYeri;
            }

            t.ADSOYAD = Txtadsoyad.Text;
            t.EGITIM = Txtegitim.Text;
            t.ISDENEYIMLERI = Txtisdeneyim.Text;
            t.MESLEK = Txtmeslek.Text;
            //t.GORSELURL = Txtgorsel.Text;
            db.TBLHAKKIMDA.Add(t);
            db.SaveChanges();
            Response.Redirect("Hakkimda.aspx");
        }

    }
}