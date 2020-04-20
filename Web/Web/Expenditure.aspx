<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Expenditure.aspx.cs" Inherits="Web.Expenditure" %>

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
    <style type="text/css">
        .auto-style9 {
            width: 200px;
        }
        .auto-style11 {
            width: 200px;
        }
        .auto-style12 {
            width: 200px;
        }
        .auto-style13 {
            width: 200px;
        }
        .auto-style14 {
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
                    <li><a href="Login.aspx">ออกจากระบบ</a></li>
                </ul>
                    </div>
            </div>
        </div>
    </nav>
    <br /><br />
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>ดูกราฟสรุปยอดรวมรายจ่ายของทุกเดือนประจำปี</b>
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem>2012</asp:ListItem>
                <asp:ListItem>2013</asp:ListItem>
                <asp:ListItem>2014</asp:ListItem>
                <asp:ListItem Selected="True">2015</asp:ListItem>
            </asp:DropDownList>
            <br />
             <br />
    <table class="table table-striped">
        <thead>
            <tr>
                <th class="auto-style13">ประเภท</th>
                <th class="auto-style14">เดือนนี้</th>
                <th class="auto-style11">เดือนที่แล้ว</th>
                <th class="auto-style12">ปีนี้</th>
                <th class="auto-style9">ปีที่แล้ว</th>
                <th>เดือนที่ค้นหาโดยระบุ</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td class="auto-style13">การศึกษา</td>
                <td class="auto-style14">
                    <asp:Label ID="Label12" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:Label ID="Label23" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:Label ID="Label34" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:Label ID="Label1" runat="server" Text="0"></asp:Label>
                </td>            
                <td>
                    <asp:Label ID="Label45" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">ค่าซ่อม/ดูแลรักษา</td>
                <td class="auto-style14">
                    <asp:Label ID="Label13" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:Label ID="Label24" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:Label ID="Label35" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:Label ID="Label2" runat="server" Text="0"></asp:Label>
                </td>           
                <td>
                    <asp:Label ID="Label46" runat="server" Text="0"></asp:Label>
                </td> 
            </tr>
            <tr>
                <td class="auto-style13">ค่าเดินทาง/ค่าน้ำมันรถ</td>
                <td class="auto-style14">
                    <asp:Label ID="Label14" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:Label ID="Label25" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:Label ID="Label36" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:Label ID="Label3" runat="server" Text="0"></asp:Label>
                </td>            
                <td>
                    <asp:Label ID="Label47" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">ค่าน้ำ/ไฟ/โทรศัพท์</td>
                <td class="auto-style14">
                    <asp:Label ID="Label15" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:Label ID="Label26" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:Label ID="Label37" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:Label ID="Label4" runat="server" Text="0"></asp:Label>
                </td>            
                <td>
                    <asp:Label ID="Label48" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">บริจาค/ของขวัญ</td>
                <td class="auto-style14">
                    <asp:Label ID="Label16" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:Label ID="Label27" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:Label ID="Label38" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:Label ID="Label5" runat="server" Text="0"></asp:Label>
                </td>            
                <td>
                    <asp:Label ID="Label49" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">บันเทิง/พักผ่อน</td>
                <td class="auto-style14">
                    <asp:Label ID="Label17" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:Label ID="Label28" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:Label ID="Label39" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:Label ID="Label6" runat="server" Text="0"></asp:Label>
                </td>            
                <td>
                    <asp:Label ID="Label50" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">ภาษี/ประกันภัย/ดอกเบี้ย</td>
                <td class="auto-style14">
                    <asp:Label ID="Label18" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:Label ID="Label29" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:Label ID="Label40" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:Label ID="Label7" runat="server" Text="0"></asp:Label>
                </td>            
                <td>
                    <asp:Label ID="Label51" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">สุขภาพ/ออกกำลังกาย</td>
                <td class="auto-style14">
                    <asp:Label ID="Label19" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:Label ID="Label30" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:Label ID="Label41" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:Label ID="Label8" runat="server" Text="0"></asp:Label>
                </td>            
                <td>
                    <asp:Label ID="Label52" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">เสื้อผ้า/เครื่องใช้ส่วนตัว</td>
                <td class="auto-style14">
                    <asp:Label ID="Label20" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:Label ID="Label31" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:Label ID="Label42" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:Label ID="Label9" runat="server" Text="0"></asp:Label>
                </td>         
                <td>
                    <asp:Label ID="Label53" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">อื่นๆ</td>
                <td class="auto-style14">
                    <asp:Label ID="Label21" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:Label ID="Label32" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:Label ID="Label43" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:Label ID="Label10" runat="server" Text="0"></asp:Label>
                </td>         
                <td>
                    <asp:Label ID="Label54" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">รวม</td>
                <td class="auto-style14">
                    <asp:Label ID="Label22" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:Label ID="Label33" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:Label ID="Label44" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:Label ID="Label11" runat="server" Text="0"></asp:Label>
                </td>         
                <td>
                    <asp:Label ID="Label55" runat="server" Text="0"></asp:Label>
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
&nbsp;ปี
                <asp:DropDownList ID="DropDownList3" runat="server">
                    <asp:ListItem>2012</asp:ListItem>
                    <asp:ListItem>2013</asp:ListItem>
                    <asp:ListItem>2014</asp:ListItem>
                    <asp:ListItem Selected="True">2015</asp:ListItem>
                </asp:DropDownList>
            &nbsp;<asp:Button ID="Button1" runat="server" Text="ค้นหา" OnClick="Button1_Click" />
            </p>
        </form>
</body>
</html>
