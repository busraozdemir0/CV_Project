using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV_Project
{
    public partial class HakkimdaGuncelle : System.Web.UI.Page
    {
        CVEntityEntities db = new CVEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var deger = db.TBLHAKKIMDA.Find(id);
                Txtadsoyad.Text = deger.ADSOYAD;
                Txtegitim.Text = deger.EGITIM;
                Txtisdeneyim.Text = deger.ISDENEYIMLERI;
                Txtmeslek.Text = deger.MESLEK;
                //Txtgorsel.Text = deger.GORSELURL;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            var deger = db.TBLHAKKIMDA.Find(id);

            HttpPostedFile yuklenecekDosya = FileUpload1.PostedFile;
            if (yuklenecekDosya != null)
            {
                FileInfo dosyaBilgisi = new FileInfo(FileUpload1.FileName);
                string klasor = "Resimler";

                string dosyaAdi = dosyaBilgisi.Name.Substring(0, dosyaBilgisi.Name.Length - dosyaBilgisi.Extension.Length);
                dosyaAdi += "-" + Guid.NewGuid().ToString().Replace("-", "") + dosyaBilgisi.Extension;
                string yuklemeYeri = Server.MapPath("~/" + klasor + "/" + dosyaAdi);
                FileUpload1.SaveAs(yuklemeYeri);

                string kayitYeri = klasor + "/" + dosyaAdi;
                deger.GORSELURL = kayitYeri;
            }

            deger.ADSOYAD = Txtadsoyad.Text;
            deger.EGITIM = Txtegitim.Text;
            deger.ISDENEYIMLERI = Txtisdeneyim.Text;
            deger.MESLEK = Txtmeslek.Text;
            db.SaveChanges();
            Response.Redirect("Hakkimda.aspx");
        }
    }
}