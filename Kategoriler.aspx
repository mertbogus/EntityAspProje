<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Kategoriler.aspx.cs" Inherits="EntityAspProje.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>KATEGORİ ID</th>
            <th>KATEGORİ AD</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("KATEGORIID")%></td>
                    <td><%#Eval("KATEGORIAD")%></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/KategoriSil.aspx?KATEGORIID="+Eval("KATEGORIID") %>' runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink></td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# "~/KategoriGuncelle.aspx?KATEGORIID="+Eval("KATEGORIID") %>' runat="server" CssClass="btn btn-warning">GÜNCELLE</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="KategoriEkle.aspx" class="btn btn-success">Yeni Kategori</a>
</asp:Content>
