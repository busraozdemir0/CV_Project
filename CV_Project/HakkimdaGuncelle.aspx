﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="HakkimdaGuncelle.aspx.cs" Inherits="CV_Project.HakkimdaGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="container">
        <h4>Hakkımda Güncelleme Sayfası</h4>
        <br />
         <asp:Label ID="Label1" runat="server" Text="Adı Soyadı"></asp:Label>
         <br />
        <asp:TextBox ID="Txtadsoyad" runat="server" CssClass="form-control" placeholder="Adsoyad"></asp:TextBox>       
         <br />
         <asp:Label ID="Label2" runat="server" Text="Eğitim"></asp:Label>
         <br />
          <asp:TextBox ID="Txtegitim" runat="server" CssClass="form-control" placeholder="egitim" Height="100px"></asp:TextBox>   
        <br />
          <asp:Label ID="Label3" runat="server" Text="İş Deneyimleri"></asp:Label>
         <br />
         <asp:TextBox ID="Txtisdeneyim" runat="server" CssClass="form-control" placeholder="is deneyimi" Height="100px"></asp:TextBox>   
        <br />
           <asp:Label ID="Label4" runat="server" Text="Meslek"></asp:Label>
         <br />
        <asp:TextBox ID="Txtmeslek" runat="server" CssClass="form-control" placeholder="meslek" Height="100px"></asp:TextBox>   
        <br />
            <asp:Label ID="Label5" runat="server" Text="Görsel URL"></asp:Label><p>-->Görseli hızlı resim sitesine yükleyip urlsini buraya yapıştırabilirsiniz. </p>

        <asp:TextBox ID="Txtgorsel" runat="server" CssClass="form-control" placeholder="görsel"></asp:TextBox>   
        <br />
        
        <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="Button1_Click" />        
    </div>
    <br />

</asp:Content>
