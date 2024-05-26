<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebRegistraEmpleado.aspx.vb" Inherits="webEjemplo.WebRegistraEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>REGISTRO DE EMPLEADO</title>
    <style type="text/css">
        .auto-style1 {
            width: 571px;
        }
        .auto-style2 {
            width: 330px;
        }
    </style>
    <link href="css/bootstrap.min.css" rel ="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>REGISTRO DE EMPLEADO</h2>
            <table style="width:56%;">
                <tr>
                    <td class="auto-style2">DNI</td>
                    <td class="auto-style1">
                        <asp:TextBox CssClass="form-control" ID="txtDni" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Nombres</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Area de Trabajo</td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="cmbArea" runat="server">
                            <asp:ListItem>--Seleccione--</asp:ListItem>
                            <asp:ListItem>Gerencia</asp:ListItem>
                            <asp:ListItem>Contabilidad</asp:ListItem>
                            <asp:ListItem>Recursos Humanos</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>

                        <asp:Button ID="btnRegistra" CssClass ="btn btn-primary" runat="server" Text="Registrar" />

                    </td>
                    <td>

                        <asp:Button ID="btnRegresar" CssClass ="btn btn-secondary" runat="server" Text="Retornar" />

                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
