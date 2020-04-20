<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Web.Register" %>

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
    <link href="Content/Style.css" rel="stylesheet" />
    <style type="text/css">
    <link href="/Content/Site.css" rel="stylesheet"/>
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 20px;
        }
        .auto-style3 {
            width: 271px;
        }
        .auto-style4 {
            height: 20px;
            width: 123px;
        }
        .auto-style6 {
            width: 123px;
            height: 22px;
        }
        .auto-style7 {
            height: 22px;
        }
        .auto-style8 {
            width: 123px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="LOGIN">
           <table>
            <tr>
                <td class="auto-style8"><b>USERNAME:</b></td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="185px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"><b>PASSWORD:</b></td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server" Width="185px" Textmode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8"><b>RE-PASSWORD:</b></td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Width="185px" Textmode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label1" runat="server" BorderColor="Red" ForeColor="Red"></asp:Label>
                </td>
            </tr>
                   <td class="auto-style8"></td>
                   <td class="auto-style3">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="CANCLE" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SIGN UP" />
                </td>
        </table>
        </div>
    </form>
</body>
</html>
