using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class KategoriSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["KATEGORIID"].ToString());
            BonusAspDBEntities1 db = new BonusAspDBEntities1();
            var deger = db.TBL_KATEGORI.Find(id);
            db.TBL_KATEGORI.Remove(deger);
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");
        }
    }
}