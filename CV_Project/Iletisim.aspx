<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="CV_Project.Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <table class="table table-hover" style="margin-left: 20px; margin-right: 20px">
            <tr class="success">
                <th hidden>ID</th>
                <th>Adı Soyadı</th>
                <th>Mail</th>
                <th>Konu</th>
                <th>Mesajı Gör</th>
                <th>Mesajı Sil</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td hidden><%# Eval("ID") %></td>
                        <td><%# Eval("ADSOYAD") %></td>
                        <td><%# Eval("MAIL") %></td>
                        <td><%# Eval("KONU") %></td>
                        <td>
                            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "MesajDetay.aspx?ID="+Eval("ID") %>' CssClass="btn btn-warning" BorderColor="#FF6666">Mesajı Gör</asp:HyperLink>
                        </td>
                         <td>
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "MesajSil.aspx?ID="+Eval("ID") %>' CssClass="btn btn-danger" >Mesajı Sil</asp:HyperLink>
                        </td>

                    </tr>
                </ItemTemplate>
            </asp:Repeater>

        </table>
    </div>

</asp:Content>
