<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Plantilla_Agrobelen.Master" CodeBehind="WebReporteKardex.aspx.vb" Inherits="WEB_Sistema_Agrobelen.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style10 {
            width: 153px;
        }
        .auto-style12 {
            width: 196px;
        }
        .auto-style13 {
            width: 100%;
        }
        .auto-style15 {
        width: 134px;
    }
    .auto-style16 {
        width: 119px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style13">
        <tr>
            <td class="auto-style10">Ingrese Almacen:</td>
            <td class="auto-style16">
                <asp:DropDownList ID="cmbAlmacen" runat="server" Height="33px" Width="333px">
                </asp:DropDownList>
            </td>
            <td class="auto-style12">Ingrese ID de Producto:</td>
            <td class="auto-style15">

                <asp:TextBox ID="txtID" runat="server" Width="244px"></asp:TextBox>

            </td>
            <td>

                <asp:Button CssClass="btn btn-P" ID="btnBuscar" runat="server" Text="Buscar" />

            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="5">

                <asp:GridView ID="gvDatos" runat="server" Width="1140px">
                </asp:GridView>

            </td>
        </tr>
    </table>
</asp:Content>
