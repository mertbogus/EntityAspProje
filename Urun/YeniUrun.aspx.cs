using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class YeniUrun : System.Web.UI.Page
    {
        BonusAspDBEntities1 db = new BonusAspDBEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var kate = (from x in db.TBL_KATEGORI select new { x.KATEGORIID, x.KATEGORIAD }).ToList();
                DropDownList1.DataTextField = "KATEGORIAD";
                DropDownList1.DataValueField = "KATEGORIID";
                DropDownList1.DataSource = kate;
                DropDownList1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBL_URUNLER urun = new TBL_URUNLER();
            urun.URUNAD = Txturunad.Text;
            urun.URUNMARKA = Txtmarka.Text;
            urun.KATEGORI = byte.Parse(DropDownList1.SelectedValue);
            urun.URUNFIYAT = decimal.Parse(Txtfiyat.Text);
            urun.URUNSTOK = short.Parse(Txtstoksayisi.Text);
            urun.DURUM = true;
            db.TBL_URUNLER.Add(urun);
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");

        }
    }
}