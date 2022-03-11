using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class UrunGuncelle : System.Web.UI.Page
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


                int id = int.Parse(Request.QueryString["URUNID"].ToString());
                var urunid = db.TBL_URUNLER.Find(id);
                Txturunad.Text = urunid.URUNAD;
                DropDownList1.SelectedValue = urunid.KATEGORI.ToString();
                Txtmarka.Text = urunid.URUNMARKA;
                Txtfiyat.Text = urunid.URUNFIYAT.ToString();
                Txtstoksayisi.Text = urunid.URUNSTOK.ToString();
                txtdurum.Text = urunid.DURUM.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["URUNID"].ToString());
            var urunguncelle = db.TBL_URUNLER.Find(id);
            urunguncelle.URUNAD = Txturunad.Text;
            urunguncelle.KATEGORI = byte.Parse(DropDownList1.SelectedValue.ToString());
            urunguncelle.URUNMARKA = Txtmarka.Text;
            urunguncelle.URUNFIYAT = decimal.Parse(Txtfiyat.Text);
            urunguncelle.URUNSTOK = short.Parse(Txtstoksayisi.Text);
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}