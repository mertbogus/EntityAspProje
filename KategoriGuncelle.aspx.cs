using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class KategoriGuncelle : System.Web.UI.Page
    {
        BonusAspDBEntities1 db = new BonusAspDBEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int id = int.Parse(Request.QueryString["KATEGORIID"].ToString());
                Txtid.Text = id.ToString();
                var ktgr = db.TBL_KATEGORI.Find(id);
                TxtKategoriad.Text = ktgr.KATEGORIAD;
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["KATEGORIID"].ToString());
            var kategori = db.TBL_KATEGORI.Find(id);
            kategori.KATEGORIAD = TxtKategoriad.Text;
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");
        }
    }
}