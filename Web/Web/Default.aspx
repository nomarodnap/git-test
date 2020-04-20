<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web.Default" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/Default.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/modernizr-2.6.2.js"></script>


    <script lang=Javascript>
      <!--
    function isNumberKey(evt) {
        var charCode = (evt.which) ? evt.which : event.keyCode
        if (charCode > 31 && (charCode < 48 || charCode > 57))
            return false;

        return true;
    }
    //-->
   </script>


    <script lang="javascript" type="text/javascript">
        function ControlDIV1() {
            if (document.getElementById('div1').style.display == 'none') {
                document.getElementById('div1').style.display = 'block';
                document.getElementById('cmdControl1').value = '-';
            }
            else {
                document.getElementById('div1').style.display = 'none';
                document.getElementById('cmdControl1').value = '+';
            }
        }
    </script>
        <script lang="javascript" type="text/javascript">
            function ControlDIV2() {
                if (document.getElementById('div2').style.display == 'none') {
                    document.getElementById('div2').style.display = 'block';
                    document.getElementById('cmdControl2').value = '-';
                }
                else {
                    document.getElementById('div2').style.display = 'none';
                    document.getElementById('cmdControl2').value = '+';
                }
            }
    </script>


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
    <br /><br />    <br /><br />
            
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            
            <%--<input id="cmdControl1" type="button" value="-" onclick="ControlDIV1()" />--%> <b>บันทึกรายรับ
            </b> 
            &nbsp;<div id="div1" > <div class="CenterColumn">
            &nbsp;&nbsp;&nbsp; กรอกรายรับ&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:DropDownList ID="ddlIncome" runat="server" Height="22px" Width="170px" AutoPostBack="true">
                <asp:ListItem >การลงทุน/ดอกเบี้ยเงินฝาก</asp:ListItem>
                <asp:ListItem >ของขวัญ/เสี่ยงโชค</asp:ListItem>
                <asp:ListItem >เงินเดือน/ค่าจ้าง</asp:ListItem>
                <asp:ListItem >อื่นๆ</asp:ListItem>

            </asp:DropDownList>            
            &nbsp;&nbsp;&nbsp;            
            <asp:TextBox runat="server" ID="txtItem" runat="server" value="รายการ" ForeColor="GrayText" onblur="if(this.value=='')this.value=this.defaultValue;"   onfocus="if(this.value==this.defaultValue)this.value='';this.style.color = 'black'" Width="340px"></asp:Textbox>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox runat="server" ID="txtCost" runat="server" value="จำนวนเงิน" ForeColor="GrayText" onkeypress="return isNumberKey(event)" onblur="if(this.value=='')this.value=this.defaultValue;"   onfocus="if(this.value==this.defaultValue)this.value='';this.style.color = 'black'" Width="80px"></asp:Textbox>
                


            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="cmdAdd1" runat="server" Text="เพิ่มข้อมูล" OnClick="cmdAdd1_Click" />

 
                <br />

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    
                <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="AID" DataSourceID="AIcome" Width="842px" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="ATime" HeaderText="วัน/เวลา" SortExpression="ATime" />
                        <asp:BoundField DataField="AType" HeaderText="ประเภท" SortExpression="AType" />
                        <asp:BoundField DataField="AItem" HeaderText="รายการ" SortExpression="AItem" />
                        <asp:BoundField DataField="ACost" HeaderText="จำนวนเงิน" SortExpression="ACost" />
                        <asp:CommandField ShowEditButton="True" />
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
                <asp:LinqDataSource ID="AIcome" runat="server" ContextTypeName="Web.DatabaseDataContext" EnableDelete="True" EnableUpdate="True" EntityTypeName="" OrderBy="AID desc" TableName="AIncomes" Where="username == @username">
                    <WhereParameters>
                        <asp:SessionParameter Name="username" SessionField="username" Type="String" />
                    </WhereParameters>
                </asp:LinqDataSource>
                    
                    </div>
                <br />
                </div>
          
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <%--<input id="cmdControl2" type="button" value="-" onclick="ControlDIV2()" />--%> <b>บันทึกรายจ่าย</b>
            <div id="div2">
                <div class="CenterColumn">
                        &nbsp;&nbsp;&nbsp; กรอกรายจ่าย&nbsp;&nbsp;

            <asp:DropDownList ID="DropDownList2" runat="server" Height="22px" Width="170px">
                <asp:ListItem>การศึกษา</asp:ListItem>
                <asp:ListItem>ค่าซ่อม/ดูแลรักษา	</asp:ListItem>
                <asp:ListItem>ค่าเดินทาง/ค่าน้ำมันรถ	</asp:ListItem>
                <asp:ListItem>ค่าน้ำ/ไฟ/โทรศัพท์	</asp:ListItem>
                <asp:ListItem>บริจาค/ของขวัญ	</asp:ListItem>
                <asp:ListItem>บันเทิง/พักผ่อน	</asp:ListItem>
                <asp:ListItem>ภาษี/ประกันภัย/ดอกเบี้ย	</asp:ListItem>
                <asp:ListItem>สุขภาพ/ออกกำลังกาย	</asp:ListItem>
                <asp:ListItem>เสื้อผ้า/เครื่องใช้ส่วนตัว	</asp:ListItem>
                <asp:ListItem>อื่นๆ</asp:ListItem>

            </asp:DropDownList>            
            &nbsp;&nbsp;&nbsp;            
            <asp:TextBox runat="server" ID="TextBox3" value="รายการ" ForeColor="GrayText" onblur="if(this.value=='')this.value=this.defaultValue;"   onfocus="if(this.value==this.defaultValue)this.value='';this.style.color = 'black'" Width="340px" ></asp:Textbox>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox runat="server" ID="TextBox4"  value="จำนวนเงิน" ForeColor="GrayText" onkeypress="return isNumberKey(event)" onblur="if(this.value=='')this.value=this.defaultValue;"   onfocus="if(this.value==this.defaultValue)this.value='';this.style.color = 'black'" Width="80"></asp:Textbox>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="เพิ่มข้อมูล" OnClick="Button2_Click" />

                

                <%--</div>--%>

            &nbsp;&nbsp;&nbsp;&nbsp;
                                        
        
 
                        <br />
&nbsp;<asp:GridView ID="GridView3" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="OID" DataSourceID="Outcome" Width="843px" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="OTime" HeaderText="วัน/เวลา" SortExpression="OTime" />
                                <asp:BoundField DataField="OType" HeaderText="ประเภท" SortExpression="OType" />
                                <asp:BoundField DataField="OItem" HeaderText="รายการ" SortExpression="OItem" />
                                <asp:BoundField DataField="OCost" HeaderText="จำนวนเงิน" SortExpression="OCost" />
                                <asp:CommandField ShowEditButton="True" />
                                <asp:CommandField ShowDeleteButton="True" />
                            </Columns>
                            <EditRowStyle BackColor="#7C6F57" />
                            <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#E3EAEB" />
                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F8FAFA" />
                            <SortedAscendingHeaderStyle BackColor="#246B61" />
                            <SortedDescendingCellStyle BackColor="#D4DFE1" />
                            <SortedDescendingHeaderStyle BackColor="#15524A" />
                        </asp:GridView>
                        <asp:LinqDataSource ID="Outcome" runat="server" ContextTypeName="Web.DatabaseDataContext" EnableDelete="True" EnableUpdate="True" EntityTypeName="" OrderBy="OID desc" TableName="Outcomes" Where="username == @username">
                            <WhereParameters>
                                <asp:SessionParameter Name="username" SessionField="username" Type="String" />
                            </WhereParameters>
                        </asp:LinqDataSource>
                    </div>
                </div>
        </form>




</body>
</html>
