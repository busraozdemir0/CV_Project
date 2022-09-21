<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="HakkimdaEkle.aspx.cs" Inherits="CV_Project.HakkimdaEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <h4>Hakkımda Ekleme Sayfası</h4>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Adı Soyadı"></asp:Label>
        <br />
        <asp:TextBox ID="Txtadsoyad" runat="server" CssClass="form-control" placeholder="Adı Soyadı"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Eğitim"></asp:Label>
        <br />
        <asp:TextBox ID="Txtegitim" runat="server" CssClass="form-control" placeholder="Eğitim" Height="100px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="İş Deneyimleri"></asp:Label>
        <br />
        <asp:TextBox ID="Txtisdeneyim" runat="server" CssClass="form-control" placeholder="İş Deneyimi" Height="100px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Meslek"></asp:Label>
        <br />
        <asp:TextBox ID="Txtmeslek" runat="server" CssClass="form-control" placeholder="Meslek" Height="100px"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Görsel Yükle"></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" required="Dosya Seçin!"/>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="Button1_Click" />

    </div>
    <br />



</asp:Content>
