<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yetenekler.aspx.cs" Inherits="CV_Project.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <table class="table table-hover" style="margin-left: 20px; margin-right: 20px">
            <tr>
                <th hidden>ID</th>
                <th>Yetenek</th>
                <th>Sil</th>
                <th>Güncelle</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td hidden><%# Eval("ID") %></td>
                        <td><%# Eval("YETENEK") %></td>
                        <td><a href="#" class="btn btn-danger">Sil</a></td>
                        <td><a href="#" class="btn btn-success">Güncelle</a></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>

        </table>
        <a href="YeniYetenek.aspx" class="btn btn-primary" style="margin-left:20px">Yeni Yetenek Ekle</a>
    </div>
</asp:Content>
