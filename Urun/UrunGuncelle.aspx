<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunGuncelle.aspx.cs" Inherits="EntityAspProje.Urun.UrunGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <form runat="server" class="form-group">
        <div>
            <asp:TextBox ID="Txturunad" runat="server" placeholder="ürün Adı" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="Txtmarka" runat="server" placeholder="Ürün Markası" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
        <div>
            <asp:TextBox ID="Txtfiyat" runat="server" placeholder="Fiyat" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="Txtstoksayisi" runat="server" placeholder="Stok Sayısı" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="txtdurum" runat="server" placeholder="Durum" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

            <asp:Button ID="Button1" runat="server" Text="Ürün Güncelle" CssClass="btn btn-warning" OnClick="Button1_Click" />
        </div>
    </form>
</asp:Content>
