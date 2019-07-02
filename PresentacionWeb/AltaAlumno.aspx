<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaAlumno.aspx.cs" Inherits="PresentacionWeb.AltaAluno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 36px;
            width: 415px;
        }
        .auto-style2 {
            width: 335px;
        }
        .auto-style3 {
            height: 36px;
            width: 335px;
        }
        .auto-style4 {
            width: 415px;
        }
        .auto-style5 {
            width: 335px;
            height: 34px;
        }
        .auto-style6 {
            width: 415px;
            height: 34px;
        }
        .auto-style7 {
            width: 335px;
            height: 29px;
        }
        .auto-style8 {
            width: 415px;
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Altas de alumnos:</h2>
            <table class="table">
                <tr>
                    <td class="auto-style7">DNI:</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Apellidos:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Nombres:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnEnviar" CssClass="btn-primary" runat="server" OnClick="BtnEnviar_Click" Text="Enviar" />
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="lblMensaje" runat="server" Text=" "></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
