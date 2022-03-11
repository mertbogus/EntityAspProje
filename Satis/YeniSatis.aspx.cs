using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Satis
{
    public partial class YeniSatis : System.Web.UI.Page
    {
        BonusAspDBEntities1 db = new BonusAspDBEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var urn = (from x in db.TBL_URUNLER select new { x.URUNID ,x.URUNAD }).ToList();
                Drurun.DataTextField = "URUNAD";
                Drurun.DataValueField = "URUNID";
                Drurun.DataSource = urn;
                Drurun.DataBind();

                var musteri = (from x in db.TBL_MUSTERI select new { 
                    x.MUSTERIID, 
                    MUSTERİAD=x.MUSTERIAD +" "+ x.MUSTERISOYAD
                }).ToList();
                Drmusteri.DataTextField = "MUSTERİAD";
                Drmusteri.DataValueField = "MUSTERIID";
                Drmusteri.DataSource = musteri;
                Drmusteri.DataBind();

                var prs = (from x in db.TBL_PERSONEL
                               select new
                               {
                                   x.PERSONELID,
                                   x.PERSONELADSOYAD
                               }).ToList();
                Drpersonel.DataTextField = "PERSONELADSOYAD";
                Drpersonel.DataValueField = "PERSONELID";
                Drpersonel.DataSource = prs;
                Drpersonel.DataBind();

            }
        }

        protected void Btnsatis_Click(object sender, EventArgs e)
        {
            TBL_SATIS t = new TBL_SATIS();
            t.URUN = int.Parse(Drurun.SelectedValue);
            t.MUSTERI = int.Parse(Drmusteri.SelectedValue);
            t.PERSONEL = byte.Parse(Drpersonel.SelectedValue);
            t.FIYAT = decimal.Parse(Txtfiyat.Text);
            db.TBL_SATIS.Add(t);
            db.SaveChanges();
            Response.Redirect("Satislar.aspx");
        }
    }
}