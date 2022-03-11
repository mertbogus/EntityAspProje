using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class KategoriEkle : System.Web.UI.Page
    {
        BonusAspDBEntities1 db = new BonusAspDBEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBL_KATEGORI t = new TBL_KATEGORI();
            t.KATEGORIAD = TextBox1.Text;
            db.TBL_KATEGORI.Add(t);
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");
        }
    }
}