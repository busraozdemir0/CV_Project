<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdresGuncelle.aspx.cs" Inherits="CV_Project.AdresGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <h4>Adres Güncelleme Sayfası</h4>
        <br />
         <asp:Label ID="Label1" runat="server" Text="Telefon"></asp:Label>
         <br />
        <asp:TextBox ID="Txttelefon" runat="server" CssClass="form-control" placeholder="Telefon"></asp:TextBox>       
         <br />
         <asp:Label ID="Label2" runat="server" Text="E-Mail"></asp:Label>
         <br />
          <asp:TextBox ID="Txtmail" runat="server" CssClass="form-control" placeholder="E-mail"></asp:TextBox>   
        <br />
          <asp:Label ID="Label3" runat="server" Text="Adres"></asp:Label>
         <br />
         <asp:TextBox ID="Txtadres" runat="server" CssClass="form-control" placeholder="Adres" Height="100px"></asp:TextBox>   
        <br />
           <asp:Label ID="Label4" runat="server" Text="Konum"></asp:Label>
         <br />
        <asp:TextBox ID="Txtkonum" runat="server" CssClass="form-control" placeholder="Konum"></asp:TextBox>   
        <br />       
        
        <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="Button1_Click" />        
    </div>
    <br />
</asp:Content>
