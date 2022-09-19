<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yetenekler.aspx.cs" Inherits="CV_Project.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <table class="table table-hover" style="margin-left: 20px; margin-right: 20px">
            <tr class="success">
                <th hidden>ID</th>
                <th>Yetenek</th>
                <th>Derece</th>
                <th>Sil</th>
                <th>Güncelle</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td hidden><%# Eval("ID") %></td>
                        <td><%# Eval("YETENEK") %></td>
                        <td><%# Eval("DERECE") %></td>

                        <td><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "YetenekSil.aspx?ID="+Eval("ID") %>' CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                        
                        <td><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "YetenekGuncelle.aspx?ID="+Eval("ID") %>' CssClass="btn btn-success">Güncelle</asp:HyperLink></td>
                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>

        </table>
        <a href="YeniYetenek.aspx" class="btn btn-primary" style="margin-left:20px">Yeni Yetenek Ekle</a>
    </div>
</asp:Content>
