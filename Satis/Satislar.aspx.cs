using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Satis
{
    public partial class Satislar : System.Web.UI.Page
    {
        BonusAspDBEntities1 db = new BonusAspDBEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            var satis = (from x in db.TBL_SATIS
                         select new
                         {
                             x.SATISID,
                             MUSTERIAD=x.TBL_MUSTERI.MUSTERIAD +" "+ x.TBL_MUSTERI.MUSTERISOYAD,
                             x.TBL_PERSONEL.PERSONELADSOYAD,
                             x.TBL_URUNLER.URUNAD,
                             x.FIYAT
                         }).ToList();
            Repeater1.DataSource = satis;
            Repeater1.DataBind();
        }
    }
}