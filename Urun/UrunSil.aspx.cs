using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class UrunSil : System.Web.UI.Page
    {
        BonusAspDBEntities1 db = new BonusAspDBEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["URUNID"].ToString());
            var urunid = db.TBL_URUNLER.Find(id);
            urunid.DURUM = false;
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}