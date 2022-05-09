<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formulario1.aspx.cs" Inherits="excersice_3StudentFailOrApprove.formulario1" %>

<!DOCTYPE html>
<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 25px;
        }
        .auto-style4 {
            width: 165px;
        }
        .auto-style5 {
            height: 23px;
            width: 165px;
        }
        .auto-style6 {
            height: 25px;
            width: 165px;
        }
        .auto-style7 {
            width: 161px;
        }
        .auto-style8 {
            height: 23px;
            width: 161px;
        }
        .auto-style9 {
            height: 25px;
            width: 161px;
        }
        .auto-style10 {
            width: 165px;
            height: 26px;
        }
        .auto-style11 {
            width: 161px;
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
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="digite su nombre:" BackColor="#FFFF66" BorderColor="#FF3300" BorderStyle="Groove"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="lblcalone" runat="server" Text="enter your qualification 1:" BackColor="#FFFFCC" BorderColor="#66FFFF" BorderStyle="Ridge"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtcalone" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lblcaltwo" runat="server" Text="enter your qualification 2:" BackColor="#FFFFCC" BorderColor="#66FFFF" BorderStyle="Ridge"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtcaltwo" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="lblcalthree" runat="server" Text="enter your qualification 3:" BackColor="#FFFFCC" BorderColor="#66FFFF" BorderStyle="Ridge"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtcalthree" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="qualificationfinal" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="Failedorapprove" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style8"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>
                    <asp:Button ID="btncalcular" runat="server" OnClick="Button1_Click" Text="calcular" BorderColor="#66FFFF" BorderStyle="Outset" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
