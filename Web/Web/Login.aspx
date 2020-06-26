<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/modernizr-2.6.2.js"></script>
    <style type="Content/Style.css">
        .auto-style2 {
            width: 848px;
        }
        .auto-style5 {
            width: 77px;
        }
    </style>
    <style type="text/css">
        .auto-style2 {
            width: 53px;
        }
    </style>
    <link href="Content/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

                <div class="PAGE">
        <div class="LOGIN">
        <table style="width: 100%;">
            <tr>
                <td class="auto-style2"><b>USERNAME:</b></td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="185px" style="margin-left: 0px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><b>PASSWORD:</b></td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server" Width="185px" Textmode="Password" style="margin-left: 0px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Label ID="Label1" runat="server" BorderColor="Red" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="SIGN UP" CssClass="btn-link focus" />
                &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LOGIN" CssClass="btn-link focus" />
                </td>
            </tr>
        </table>

        </div></div>



    






    </form>
</body>
</html>
