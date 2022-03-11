using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.LinqKartlar
{
    public partial class İstatistik : System.Web.UI.Page
    {
        BonusAspDBEntities1 db = new BonusAspDBEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TBL_URUNLER.Count().ToString();
            Label2.Text = db.TBL_MUSTERI.Count().ToString();
            Label3.Text = db.TBL_SATIS.Sum(x => x.FIYAT).ToString();
            Label4.Text = db.TBL_KATEGORI.Count().ToString();
            Label5.Text = db.TBL_URUNLER.Count(x => x.DURUM == true).ToString();
            Label6.Text = db.TBL_URUNLER.Count(x => x.DURUM == false).ToString();
            Label7.Text = (from x in db.TBL_URUNLER orderby x.URUNSTOK descending select x.URUNAD).FirstOrDefault();
            Label8.Text = (from y in db.TBL_URUNLER
                           join
       k in db.TBL_KATEGORI
  on y.KATEGORI equals k.KATEGORIID
                           group y by k into g
                           orderby g.Count() descending
                           select g.Key.KATEGORIAD).FirstOrDefault();
        }
    }
}