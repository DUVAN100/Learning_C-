<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formulario1.aspx.cs" Inherits="excersice5_discontStudent.formulario1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 254px;
        }
        .auto-style3 {
            width: 254px;
            height: 4px;
        }
        .auto-style4 {
            height: 4px;
        }
        .auto-style5 {
            width: 228px;
        }
        .auto-style6 {
            height: 4px;
            width: 228px;
        }
        .auto-style7 {
            width: 254px;
            height: 23px;
        }
        .auto-style8 {
            width: 228px;
            height: 23px;
        }
        .auto-style9 {
            height: 23px;
        }
        .auto-style10 {
            width: 254px;
            height: 26px;
        }
        .auto-style11 {
            width: 228px;
            height: 26px;
        }
        .auto-style12 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" BorderStyle="Double" Text="type your number of course:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtnumbercourse" runat="server" BorderColor="Aqua" BorderStyle="Solid"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" BorderStyle="Double" Text="type the average of the courses:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtaverage" runat="server" BorderColor="Aqua" BorderStyle="Solid"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="Label3" runat="server" BorderStyle="Double" Text="type the cost for course:"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtcost" runat="server" BorderColor="Aqua" BorderStyle="Solid"></asp:TextBox>
                </td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" BorderStyle="Inset" OnClick="Button1_Click" Text="calcular" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" BorderColor="Black" BorderStyle="Double" Text="your total cost is of:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="respuesta" runat="server" BorderColor="#99FF33" BorderStyle="Solid"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8"></td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
