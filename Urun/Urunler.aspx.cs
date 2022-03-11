using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class Urunler : System.Web.UI.Page
    {
        BonusAspDBEntities1 db = new BonusAspDBEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            var urunler = (from x in db.TBL_URUNLER
                           where x.DURUM==true
                           select new
                           {
                               x.URUNID,
                               x.URUNAD,
                               x.URUNMARKA,
                               x.TBL_KATEGORI.KATEGORIAD,
                               x.URUNFIYAT,
                               x.URUNSTOK
                           }).ToList();
            Repeater1.DataSource = urunler;
            Repeater1.DataBind();
        }
    }
}