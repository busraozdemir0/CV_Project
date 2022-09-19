<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniYetenek.aspx.cs" Inherits="CV_Project.YeniYetenek" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <h4>Yetenek Ekleme Sayfası</h4>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Yetenek Açıklama"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Yetenek">
        </asp:TextBox>
        <br />
         <asp:Label ID="Label2" runat="server" Text="Yetenek Derecesi"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Derece">
        </asp:TextBox>

        <br />
        <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-info" OnClick="Button1_Click" />
    </div>

</asp:Content>
