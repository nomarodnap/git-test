﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summary.aspx.cs" Inherits="Web.Summary" %>

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
    <script src="Scripts/jsapi.js"></script>
    <script src="Scripts/jquery-1.10.2.js"></script>
    <style type="text/css">
        .auto-style2 {
            width: 200px;
        }
        .auto-style4 {
            width: 200px;
        }
        .auto-style5 {
            width: 200px;
        }
        .auto-style6 {
            width: 200px;
        }
        .auto-style7 {
            width: 200px;
        }
    </style>


</head>
<body>

        <form id="form1" runat="server">

        <nav>
        <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" 
                            data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    </div>
                <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li><a href="Default.aspx">ข้อมูลการใช้จ่าย</a></li>
                    <li><a href="Summary.aspx">สรุปผล</a></li>
                    <li><a href="Income.aspx">รายรับ</a></li>
                    <li><a href="Expenditure.aspx">รายจ่าย</a></li>
                </ul>
                <ul class="nav navbar-nav navbar-right">
                    <<li><a href="Login.aspx">ออกจากระบบ</a></li>
                </ul>
                    </div>
            </div>
        </div>
    </nav>
    <br /><br />
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <b>ดูกราฟสรุปยอดกำไร/(ขาดทุน)ของทุกเดือนประจำปี</b>
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">

                    <asp:ListItem>2012</asp:ListItem>
                    <asp:ListItem>2013</asp:ListItem>
                    <asp:ListItem>2014</asp:ListItem>
                    <asp:ListItem>2015</asp:ListItem>
                    <asp:ListItem>2016</asp:ListItem>
                    <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                    <asp:ListItem Selected="True">2020</asp:ListItem>
            </asp:DropDownList>
            <br /> <br />


        <table class="table table-striped">
        <thead>
            <tr>
                <th class="auto-style2">ประเภท</th>
                <th class="auto-style6">เดือนนี้</th>
                <th class="auto-style4">เดือนที่แล้ว</th>
                <th class="auto-style5">ปีนี้</th>
                <th class="auto-style7">ปีที่แล้ว</th>
                <th>เดือนที่ค้นหาโดยระบุ</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td class="auto-style2">รายรับ</td>
                <td class="auto-style6">
                    <asp:Label ID="Label1" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label2" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="Label3" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label4" runat="server" Text="0"></asp:Label>
                </td>            
                <td>
                    <asp:Label ID="Label13" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">รายจ่าย</td>
                <td class="auto-style6">
                    <asp:Label ID="Label5" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label6" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="Label7" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label8" runat="server" Text="0"></asp:Label>
                </td>            
                <td>
                    <asp:Label ID="Label14" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">กำไร/(ขาดทุน)</td>
                <td class="auto-style6">
                    <asp:Label ID="Label9" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label10" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="Label11" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label12" runat="server" Text="0"></asp:Label>
                </td>            
                <td>
                    <asp:Label ID="Label15" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
                    </tbody>
    </table>
            

           
            <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <b>ค้นหาโดยระบุ</b> เดือน
                <asp:DropDownList ID="DropDownList1" runat="server" Width="120px">
                    <asp:ListItem Value="1">มกราคม</asp:ListItem>
                    <asp:ListItem Value="2">กุมภาพันธ์</asp:ListItem>
                    <asp:ListItem Value="3">มีนาคม</asp:ListItem>
                    <asp:ListItem Value="4">เมษายน</asp:ListItem>
                    <asp:ListItem Value="5">พฤษภาคม</asp:ListItem>
                    <asp:ListItem Value="6">มิถุนายน</asp:ListItem>
                    <asp:ListItem Value="7">กรกฎาคม</asp:ListItem>
                    <asp:ListItem Value="8">สิงหาคม</asp:ListItem>
                    <asp:ListItem Value="9">กันยายน</asp:ListItem>
                    <asp:ListItem Value="10">ตุลาคม</asp:ListItem>
                    <asp:ListItem Value="11">พฤศจิกายน</asp:ListItem>
                    <asp:ListItem Value="12">ธันวาคม</asp:ListItem>
                </asp:DropDownList>
&nbsp;ปี&nbsp;<asp:DropDownList ID="DropDownList3" runat="server">
                    <asp:ListItem>2012</asp:ListItem>
                    <asp:ListItem>2013</asp:ListItem>
                    <asp:ListItem>2014</asp:ListItem>
                    <asp:ListItem>2015</asp:ListItem>
                    <asp:ListItem>2016</asp:ListItem>
                    <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                    <asp:ListItem Selected="True">2020</asp:ListItem>
                </asp:DropDownList>
&nbsp;<asp:Button ID="Button1" runat="server" Text="ค้นหา" OnClick="Button1_Click" />
            </p>

                        
        </form>




</body>
</html>
