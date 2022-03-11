<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniSatis.aspx.cs" Inherits="EntityAspProje.Satis.YeniSatis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
        Ürün Seçin:
    <div>
        <asp:DropDownList ID="Drurun" runat="server" CssClass="form-control"></asp:DropDownList>
    </div>
        <br />
        Müşteri Seçin:
    <div>
        <asp:DropDownList ID="Drmusteri" runat="server" CssClass="form-control"></asp:DropDownList>
    </div>
        <br />
        Personel Seçin:
    <div>
        <asp:DropDownList ID="Drpersonel" runat="server" CssClass="form-control"></asp:DropDownList>
    </div>
        <br />
        Fiyat:
        <div>
            <asp:TextBox ID="Txtfiyat" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Btnsatis" runat="server" Text="Satış Yap" CssClass="btn btn-primary" OnClick="Btnsatis_Click" />
        </div>
    </form>
</asp:Content>
