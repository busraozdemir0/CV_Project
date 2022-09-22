<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Adres.aspx.cs" Inherits="CV_Project.Adres" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div class="container">
        <table class="table table-hover" style="margin-left: 20px; margin-right: 20px">
            <tr class="success">
                <th hidden>ID</th>
                <th>Telefon</th>
                <th>Mail</th>
                <th>Adres</th>
                <th>Konum</th>
                <th>Sil</th>
                <th>Güncelle</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td hidden><%# Eval("ID") %></td>
                        <td><%# Eval("TELEFON") %></td>
                        <td><%# Eval("MAIL") %></td>
                        <td><%# Eval("ADRES") %></td>
                        <td><%# Eval("KONUM") %></td>

                        <td><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "AdresSil.aspx?ID="+Eval("ID") %>' CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                        
                        <td><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "AdresGuncelle.aspx?ID="+Eval("ID") %>' CssClass="btn btn-success">Güncelle</asp:HyperLink></td>
                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <a href="AdresEkle.aspx" class="btn btn-primary" style="margin-left:20px">Adres Ekle</a>

    </div>
</asp:Content>