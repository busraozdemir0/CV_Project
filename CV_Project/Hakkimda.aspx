<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Hakkimda.aspx.cs" Inherits="CV_Project.Hakkimda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <table class="table table-hover" style="margin-left: 20px; margin-right: 20px">
            <tr class="success">
                <th hidden>ID</th>
                <th>Ad Soyad</th>
                <th>Eğitim</th>
                <th>İş Deneyimleri</th>
                <th>Meslek</th>
                <th>Görsel Url</th>
                <th>Sil</th>
                <th>Güncelle</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td hidden><%# Eval("ID") %></td>
                        <td><%# Eval("ADSOYAD") %></td>
                        <td><%# Eval("EGITIM") %></td>
                        <td><%# Eval("ISDENEYIMLERI") %></td>
                        <td><%# Eval("MESLEK") %></td>
                        <td><%# Eval("GORSELURL") %></td>

                        <td><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "HakkimdaSil.aspx?ID="+Eval("ID") %>' CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                        
                        <td><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "HakkimdaGuncelle.aspx?ID="+Eval("ID") %>' CssClass="btn btn-success">Güncelle</asp:HyperLink></td>
                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>

    </div>


</asp:Content>
