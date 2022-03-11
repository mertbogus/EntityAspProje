using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Musteri
{
    public partial class Musteriler : System.Web.UI.Page
    {
        BonusAspDBEntities1 db = new BonusAspDBEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            var musterilistesi = db.TBL_MUSTERI.ToList();
            Repeater1.DataSource = musterilistesi;
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                TBL_MUSTERI mus = new TBL_MUSTERI();
                mus.MUSTERIAD = TextBox1.Text;
                mus.MUSTERISOYAD = TextBox2.Text;
                db.TBL_MUSTERI.Add(mus);
                db.SaveChanges();
                Response.Redirect("Musteriler.aspx");
           
        }
    }
}