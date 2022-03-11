using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class Logins : System.Web.UI.Page
    {
        BonusAspDBEntities1 db = new BonusAspDBEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBL_ADMIN where x.KULLANICI == TxtKullaniciAd.Text && x.SIFRE == TxtSifre.Text select x;
            if (sorgu.Any())
            {
                Response.Redirect("Kategoriler.aspx");
            }
            else
            {
                Response.Write("HATALI VERİ GİRİŞİ.");
            }

        }
    }
}