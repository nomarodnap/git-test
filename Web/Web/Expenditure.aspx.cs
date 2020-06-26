using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using InfoSoftGlobal;

namespace Web
{
    public partial class Expenditure : System.Web.UI.Page
    {
        string _sGenerateXML = "";
        string connection = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        DatabaseDataContext db = new DatabaseDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null) { Response.Redirect("Login.aspx"); }

            var now = DateTime.Now;
            var startOfMonth = new DateTime(now.Year, now.Month, 1);
            var startOfYear = new DateTime(now.Year, 1, 1);

            //this month
            var TMOCost = (from emp in db.Outcomes where emp.OTime >= startOfMonth && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TMOCostA = (from emp in db.Outcomes where emp.OTime >= startOfMonth && emp.OType.Contains("การศึกษา") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TMOCostB = (from emp in db.Outcomes where emp.OTime >= startOfMonth && emp.OType.Contains("ค่าซ่อม/ดูแลรักษา") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TMOCostC = (from emp in db.Outcomes where emp.OTime >= startOfMonth && emp.OType.Contains("ค่าเดินทาง/ค่าน้ำมันรถ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TMOCostD = (from emp in db.Outcomes where emp.OTime >= startOfMonth && emp.OType.Contains("ค่าน้ำ/ไฟ/โทรศัพท์") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TMOCostE = (from emp in db.Outcomes where emp.OTime >= startOfMonth && emp.OType.Contains("บริจาค/ของขวัญ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TMOCostF = (from emp in db.Outcomes where emp.OTime >= startOfMonth && emp.OType.Contains("บันเทิง/พักผ่อน") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TMOCostG = (from emp in db.Outcomes where emp.OTime >= startOfMonth && emp.OType.Contains("ภาษี/ประกันภัย/ดอกเบี้ย") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TMOCostH = (from emp in db.Outcomes where emp.OTime >= startOfMonth && emp.OType.Contains("สุขภาพ/ออกกำลังกาย") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TMOCostI = (from emp in db.Outcomes where emp.OTime >= startOfMonth && emp.OType.Contains("เสื้อผ้า/เครื่องใช้ส่วนตัว") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TMOCostJ = (from emp in db.Outcomes where emp.OTime >= startOfMonth && emp.OType.Contains("อื่นๆ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;

            Label12.Text = TMOCostA.ToString();
            Label13.Text = TMOCostB.ToString();
            Label14.Text = TMOCostC.ToString();
            Label15.Text = TMOCostD.ToString();
            Label16.Text = TMOCostE.ToString();
            Label17.Text = TMOCostF.ToString();
            Label18.Text = TMOCostG.ToString();
            Label19.Text = TMOCostH.ToString();
            Label20.Text = TMOCostI.ToString();
            Label21.Text = TMOCostJ.ToString();
            Label22.Text = TMOCost.ToString();

            //LAST month
            var LMOCost = (from emp in db.Outcomes where emp.OTime < startOfMonth && emp.OTime >= startOfMonth.AddMonths(-1) && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var LMOCostA = (from emp in db.Outcomes where emp.OTime < startOfMonth && emp.OTime >= startOfMonth.AddMonths(-1) && emp.OType.Contains("การศึกษา") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var LMOCostB = (from emp in db.Outcomes where emp.OTime < startOfMonth && emp.OTime >= startOfMonth.AddMonths(-1) && emp.OType.Contains("ค่าซ่อม/ดูแลรักษา") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var LMOCostC = (from emp in db.Outcomes where emp.OTime < startOfMonth && emp.OTime >= startOfMonth.AddMonths(-1) && emp.OType.Contains("ค่าเดินทาง/ค่าน้ำมันรถ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var LMOCostD = (from emp in db.Outcomes where emp.OTime < startOfMonth && emp.OTime >= startOfMonth.AddMonths(-1) && emp.OType.Contains("ค่าน้ำ/ไฟ/โทรศัพท์") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var LMOCostE = (from emp in db.Outcomes where emp.OTime < startOfMonth && emp.OTime >= startOfMonth.AddMonths(-1) && emp.OType.Contains("บริจาค/ของขวัญ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var LMOCostF = (from emp in db.Outcomes where emp.OTime < startOfMonth && emp.OTime >= startOfMonth.AddMonths(-1) && emp.OType.Contains("บันเทิง/พักผ่อน") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var LMOCostG = (from emp in db.Outcomes where emp.OTime < startOfMonth && emp.OTime >= startOfMonth.AddMonths(-1) && emp.OType.Contains("ภาษี/ประกันภัย/ดอกเบี้ย") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var LMOCostH = (from emp in db.Outcomes where emp.OTime < startOfMonth && emp.OTime >= startOfMonth.AddMonths(-1) && emp.OType.Contains("สุขภาพ/ออกกำลังกาย") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var LMOCostI = (from emp in db.Outcomes where emp.OTime < startOfMonth && emp.OTime >= startOfMonth.AddMonths(-1) && emp.OType.Contains("เสื้อผ้า/เครื่องใช้ส่วนตัว") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var LMOCostJ = (from emp in db.Outcomes where emp.OTime < startOfMonth && emp.OTime >= startOfMonth.AddMonths(-1) && emp.OType.Contains("อื่นๆ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;

            Label23.Text = LMOCostA.ToString();
            Label24.Text = LMOCostB.ToString();
            Label25.Text = LMOCostC.ToString();
            Label26.Text = LMOCostD.ToString();
            Label27.Text = LMOCostE.ToString();
            Label28.Text = LMOCostF.ToString();
            Label29.Text = LMOCostG.ToString();
            Label30.Text = LMOCostH.ToString();
            Label31.Text = LMOCostI.ToString();
            Label32.Text = LMOCostJ.ToString();
            Label33.Text = LMOCost.ToString();

            //this YEAR
            var TYOCost = (from emp in db.Outcomes where emp.OTime >= startOfYear && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TYOCostA = (from emp in db.Outcomes where emp.OTime >= startOfYear && emp.OType.Contains("การศึกษา") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TYOCostB = (from emp in db.Outcomes where emp.OTime >= startOfYear && emp.OType.Contains("ค่าซ่อม/ดูแลรักษา") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TYOCostC = (from emp in db.Outcomes where emp.OTime >= startOfYear && emp.OType.Contains("ค่าเดินทาง/ค่าน้ำมันรถ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TYOCostD = (from emp in db.Outcomes where emp.OTime >= startOfYear && emp.OType.Contains("ค่าน้ำ/ไฟ/โทรศัพท์") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TYOCostE = (from emp in db.Outcomes where emp.OTime >= startOfYear && emp.OType.Contains("บริจาค/ของขวัญ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TYOCostF = (from emp in db.Outcomes where emp.OTime >= startOfYear && emp.OType.Contains("บันเทิง/พักผ่อน") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TYOCostG = (from emp in db.Outcomes where emp.OTime >= startOfYear && emp.OType.Contains("ภาษี/ประกันภัย/ดอกเบี้ย") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TYOCostH = (from emp in db.Outcomes where emp.OTime >= startOfYear && emp.OType.Contains("สุขภาพ/ออกกำลังกาย") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TYOCostI = (from emp in db.Outcomes where emp.OTime >= startOfYear && emp.OType.Contains("เสื้อผ้า/เครื่องใช้ส่วนตัว") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TYOCostJ = (from emp in db.Outcomes where emp.OTime >= startOfYear && emp.OType.Contains("อื่นๆ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;

            Label34.Text = TYOCostA.ToString();
            Label35.Text = TYOCostB.ToString();
            Label36.Text = TYOCostC.ToString();
            Label37.Text = TYOCostD.ToString();
            Label38.Text = TYOCostE.ToString();
            Label39.Text = TYOCostF.ToString();
            Label40.Text = TYOCostG.ToString();
            Label41.Text = TYOCostH.ToString();
            Label42.Text = TYOCostI.ToString();
            Label43.Text = TYOCostJ.ToString();
            Label44.Text = TYOCost.ToString();




            //last year
            var OCost = (from emp in db.Outcomes where emp.OTime < startOfYear && emp.OTime >= startOfYear.AddYears(-1) && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var OCostA = (from emp in db.Outcomes where emp.OTime < startOfYear && emp.OTime >= startOfYear.AddYears(-1) && emp.OType.Contains("การศึกษา") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var OCostB = (from emp in db.Outcomes where emp.OTime < startOfYear && emp.OTime >= startOfYear.AddYears(-1) && emp.OType.Contains("ค่าซ่อม/ดูแลรักษา") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var OCostC = (from emp in db.Outcomes where emp.OTime < startOfYear && emp.OTime >= startOfYear.AddYears(-1) && emp.OType.Contains("ค่าเดินทาง/ค่าน้ำมันรถ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var OCostD = (from emp in db.Outcomes where emp.OTime < startOfYear && emp.OTime >= startOfYear.AddYears(-1) && emp.OType.Contains("ค่าน้ำ/ไฟ/โทรศัพท์") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var OCostE = (from emp in db.Outcomes where emp.OTime < startOfYear && emp.OTime >= startOfYear.AddYears(-1) && emp.OType.Contains("บริจาค/ของขวัญ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var OCostF = (from emp in db.Outcomes where emp.OTime < startOfYear && emp.OTime >= startOfYear.AddYears(-1) && emp.OType.Contains("บันเทิง/พักผ่อน") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var OCostG = (from emp in db.Outcomes where emp.OTime < startOfYear && emp.OTime >= startOfYear.AddYears(-1) && emp.OType.Contains("ภาษี/ประกันภัย/ดอกเบี้ย") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var OCostH = (from emp in db.Outcomes where emp.OTime < startOfYear && emp.OTime >= startOfYear.AddYears(-1) && emp.OType.Contains("สุขภาพ/ออกกำลังกาย") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var OCostI = (from emp in db.Outcomes where emp.OTime < startOfYear && emp.OTime >= startOfYear.AddYears(-1) && emp.OType.Contains("เสื้อผ้า/เครื่องใช้ส่วนตัว") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var OCostJ = (from emp in db.Outcomes where emp.OTime < startOfYear && emp.OTime >= startOfYear.AddYears(-1) && emp.OType.Contains("อื่นๆ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;

            Label1.Text = OCostA.ToString();
            Label2.Text = OCostB.ToString();
            Label3.Text = OCostC.ToString();
            Label4.Text = OCostD.ToString();
            Label5.Text = OCostE.ToString();
            Label6.Text = OCostF.ToString();
            Label7.Text = OCostG.ToString();
            Label8.Text = OCostH.ToString();
            Label9.Text = OCostI.ToString();
            Label10.Text = OCostJ.ToString();
            Label11.Text = OCost.ToString();



            var StartJanuary = new DateTime(now.Year, 1, 1);
            var EndJanuary = new DateTime(now.Year, 1, 31);
            var StartFebruary = new DateTime(now.Year, 2, 1);
            var EndFebruary = new DateTime(now.Year, 2, 28);
            var StartMarch = new DateTime(now.Year, 3, 1);
            var EndMarch = new DateTime(now.Year, 3, 31);
            var StartApril = new DateTime(now.Year, 4, 1);
            var EndApril = new DateTime(now.Year, 4, 30);
            var StartMay = new DateTime(now.Year, 5, 1);
            var EndMay = new DateTime(now.Year, 5, 31);
            var StartJune = new DateTime(now.Year, 6, 1);
            var EndJune = new DateTime(now.Year, 6, 30);
            var StartJuly = new DateTime(now.Year, 7, 1);
            var EndJuly = new DateTime(now.Year, 7, 31);
            var StartAugust = new DateTime(now.Year, 8, 1);
            var EndAugust = new DateTime(now.Year, 8, 31);
            var StartSeptember = new DateTime(now.Year, 9, 1);
            var EndSeptember = new DateTime(now.Year, 9, 30);
            var StartOctober = new DateTime(now.Year, 10, 1);
            var EndOctober = new DateTime(now.Year, 10, 31);
            var StartNovember = new DateTime(now.Year, 11, 1);
            var EndNovember = new DateTime(now.Year, 11, 30);
            var StartDecember = new DateTime(now.Year, 12, 1);
            var EndDecember = new DateTime(now.Year, 12, 31);


            var OutcomeJanuary = (from emp in db.Outcomes where emp.OTime >= StartJanuary && emp.OTime <= EndJanuary && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeFebruary = (from emp in db.Outcomes where emp.OTime >= StartFebruary && emp.OTime <= EndFebruary && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;

            var OutcomeMarch = (from emp in db.Outcomes where emp.OTime >= StartMarch && emp.OTime <= EndMarch && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeApril = (from emp in db.Outcomes where emp.OTime >= StartApril && emp.OTime <= EndApril && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeMay = (from emp in db.Outcomes where emp.OTime >= StartMay && emp.OTime <= EndMay && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeJune = (from emp in db.Outcomes where emp.OTime >= StartJune && emp.OTime <= EndJune && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeJuly = (from emp in db.Outcomes where emp.OTime >= StartJuly && emp.OTime <= EndJuly && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeAugust = (from emp in db.Outcomes where emp.OTime >= StartAugust && emp.OTime <= EndAugust && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeSeptember = (from emp in db.Outcomes where emp.OTime >= StartSeptember && emp.OTime <= EndSeptember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeOctober = (from emp in db.Outcomes where emp.OTime >= StartOctober && emp.OTime <= EndOctober && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeNovember = (from emp in db.Outcomes where emp.OTime >= StartNovember && emp.OTime <= EndNovember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeDecember = (from emp in db.Outcomes where emp.OTime >= StartDecember && emp.OTime <= EndDecember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var query1 =
from ord in db.Expenditures
where ord.ID == 1
select ord;

            foreach (Expenditure ord in query1)
            {
                ord.Amount = OutcomeJanuary;
            }
            var query2 =
from ord in db.Expenditures
where ord.ID == 2
select ord;

            foreach (Expenditure ord in query2)
            {
                ord.Amount = OutcomeFebruary;
            }
            var query3 =
from ord in db.Expenditures
where ord.ID == 3
select ord;

            foreach (Expenditure ord in query3)
            {
                ord.Amount = OutcomeMarch;
            }
            var query4 =
from ord in db.Expenditures
where ord.ID == 4
select ord;

            foreach (Expenditure ord in query4)
            {
                ord.Amount = OutcomeApril;
            }
            var query5 =
from ord in db.Expenditures
where ord.ID == 5
select ord;

            foreach (Expenditure ord in query5)
            {
                ord.Amount = OutcomeMay;
            }
            var query6 =
from ord in db.Expenditures
where ord.ID == 6
select ord;

            foreach (Expenditure ord in query6)
            {
                ord.Amount = OutcomeJune;
            }
            var query7 =
from ord in db.Expenditures
where ord.ID == 7
select ord;

            foreach (Expenditure ord in query7)
            {
                ord.Amount = OutcomeJuly;
            }
            var query8 =
from ord in db.Expenditures
where ord.ID == 8
select ord;

            foreach (Expenditure ord in query8)
            {
                ord.Amount = OutcomeAugust;
            }
            var query9 =
from ord in db.Expenditures
where ord.ID == 9
select ord;

            foreach (Expenditure ord in query9)
            {
                ord.Amount = OutcomeSeptember;
            }
            var query10 =
from ord in db.Expenditures
where ord.ID == 10
select ord;

            foreach (Expenditure ord in query10)
            {
                ord.Amount = OutcomeOctober;
            }
            var query11 =
from ord in db.Expenditures
where ord.ID == 11
select ord;

            foreach (Expenditure ord in query11)
            {
                ord.Amount = OutcomeNovember;
            }

            var query12 =
          from ord in db.Expenditures
          where ord.ID == 12
          select ord;

            foreach (Expenditure ord in query12)
            {
                ord.Amount = OutcomeDecember;
            }
            db.SubmitChanges();


            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection(connection);
                SqlDataAdapter da = new SqlDataAdapter("select * from Expenditure", con);
                DataSet ds = new DataSet();
                con.Open();
                da.Fill(ds);
                con.Close();
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _sGenerateXML += "<chart caption='สรุปยอดรวมรายจ่ายของทุกเดือนประจำปี' subcaption='' xAxisName='เดือน' yAxisName='Amount' yAxisMinValue='1000' numberPrefix='฿' showValues='0' alternateHGridColor='0000FF' alternateHGridAlpha='30' divLineColor='CC33CC' divLineAlpha='50' canvasBorderColor='FF0000' baseFontColor='FFRRFF' lineColor='Ff0000'>";
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            _sGenerateXML += "<set label='" + dr["Months"].ToString().Trim() + "' value='" + dr["Amount"].ToString().Trim() + "'/>";
                        }
                        _sGenerateXML += "</chart>";

                        Literal1.Text = FusionCharts.RenderChartHTML("FusionCharts/Line.swf", "", _sGenerateXML.ToString(), "Monthly Sales Report", "1000", "300", false);
                        Literal1.Visible = true;
                    }
                }








            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            {
                int m1 = Convert.ToInt32(DropDownList1.SelectedValue);
                int y1 = Convert.ToInt32(DropDownList3.SelectedValue);
                DatabaseDataContext db = new DatabaseDataContext();
                var idYear = new DateTime(y1, m1, 1);
                if (m1 + 1 > 12)
                {
                    var idYear2 = new DateTime(y1 + 1, 1, 1);
                    var Cost1 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost2 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("การศึกษา") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost3 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("ค่าซ่อม/ดูแลรักษา") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost4 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("ค่าเดินทาง/ค่าน้ำมันรถ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost5 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("ค่าน้ำ/ไฟ/โทรศัพท์") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost6 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("บริจาค/ของขวัญ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost7 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("บันเทิง/พักผ่อน") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost8 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("ภาษี/ประกันภัย/ดอกเบี้ย") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost9 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("สุขภาพ/ออกกำลังกาย") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost10 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("เสื้อผ้า/เครื่องใช้ส่วนตัว") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost11 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("อื่นๆ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;

                    Label45.Text = Cost2.ToString();
                    Label46.Text = Cost3.ToString();
                    Label47.Text = Cost4.ToString();
                    Label48.Text = Cost5.ToString();
                    Label49.Text = Cost6.ToString();
                    Label50.Text = Cost7.ToString();
                    Label51.Text = Cost8.ToString();
                    Label52.Text = Cost9.ToString();
                    Label53.Text = Cost10.ToString();
                    Label54.Text = Cost11.ToString();
                    Label55.Text = Cost1.ToString();

                }
                else
                {
                    var idYear2 = new DateTime(y1, m1 + 1, 1);
                    var Cost1 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost2 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("การศึกษา") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost3 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("ค่าซ่อม/ดูแลรักษา") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost4 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("ค่าเดินทาง/ค่าน้ำมันรถ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost5 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("ค่าน้ำ/ไฟ/โทรศัพท์") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost6 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("บริจาค/ของขวัญ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost7 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("บันเทิง/พักผ่อน") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost8 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("ภาษี/ประกันภัย/ดอกเบี้ย") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost9 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("สุขภาพ/ออกกำลังกาย") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost10 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("เสื้อผ้า/เครื่องใช้ส่วนตัว") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost11 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.OType.Contains("อื่นๆ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;

                    Label45.Text = Cost2.ToString();
                    Label46.Text = Cost3.ToString();
                    Label47.Text = Cost4.ToString();
                    Label48.Text = Cost5.ToString();
                    Label49.Text = Cost6.ToString();
                    Label50.Text = Cost7.ToString();
                    Label51.Text = Cost8.ToString();
                    Label52.Text = Cost9.ToString();
                    Label53.Text = Cost10.ToString();
                    Label54.Text = Cost11.ToString();
                    Label55.Text = Cost1.ToString();

                }











            }
        }


        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int yyy = Convert.ToInt32(DropDownList2.SelectedValue);
            var StartJanuary = new DateTime(yyy, 1, 1);
            var EndJanuary = new DateTime(yyy, 1, 31);
            var StartFebruary = new DateTime(yyy, 2, 1);
            var EndFebruary = new DateTime(yyy, 2, 28);
            var StartMarch = new DateTime(yyy, 3, 1);
            var EndMarch = new DateTime(yyy, 3, 31);
            var StartApril = new DateTime(yyy, 4, 1);
            var EndApril = new DateTime(yyy, 4, 30);
            var StartMay = new DateTime(yyy, 5, 1);
            var EndMay = new DateTime(yyy, 5, 31);
            var StartJune = new DateTime(yyy, 6, 1);
            var EndJune = new DateTime(yyy, 6, 30);
            var StartJuly = new DateTime(yyy, 7, 1);
            var EndJuly = new DateTime(yyy, 7, 31);
            var StartAugust = new DateTime(yyy, 8, 1);
            var EndAugust = new DateTime(yyy, 8, 31);
            var StartSeptember = new DateTime(yyy, 9, 1);
            var EndSeptember = new DateTime(yyy, 9, 30);
            var StartOctober = new DateTime(yyy, 10, 1);
            var EndOctober = new DateTime(yyy, 10, 31);
            var StartNovember = new DateTime(yyy, 11, 1);
            var EndNovember = new DateTime(yyy, 11, 30);
            var StartDecember = new DateTime(yyy, 12, 1);
            var EndDecember = new DateTime(yyy, 12, 31);


            var OutcomeJanuary = (from emp in db.Outcomes where emp.OTime >= StartJanuary && emp.OTime <= EndJanuary && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeFebruary = (from emp in db.Outcomes where emp.OTime >= StartFebruary && emp.OTime <= EndFebruary && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;

            var OutcomeMarch = (from emp in db.Outcomes where emp.OTime >= StartMarch && emp.OTime <= EndMarch && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeApril = (from emp in db.Outcomes where emp.OTime >= StartApril && emp.OTime <= EndApril && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeMay = (from emp in db.Outcomes where emp.OTime >= StartMay && emp.OTime <= EndMay && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeJune = (from emp in db.Outcomes where emp.OTime >= StartJune && emp.OTime <= EndJune && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeJuly = (from emp in db.Outcomes where emp.OTime >= StartJuly && emp.OTime <= EndJuly && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeAugust = (from emp in db.Outcomes where emp.OTime >= StartAugust && emp.OTime <= EndAugust && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeSeptember = (from emp in db.Outcomes where emp.OTime >= StartSeptember && emp.OTime <= EndSeptember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeOctober = (from emp in db.Outcomes where emp.OTime >= StartOctober && emp.OTime <= EndOctober && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeNovember = (from emp in db.Outcomes where emp.OTime >= StartNovember && emp.OTime <= EndNovember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var OutcomeDecember = (from emp in db.Outcomes where emp.OTime >= StartDecember && emp.OTime <= EndDecember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var query1 =
from ord in db.Expenditures
where ord.ID == 1
select ord;

            foreach (Expenditure ord in query1)
            {
                ord.Amount = OutcomeJanuary;
            }
            var query2 =
from ord in db.Expenditures
where ord.ID == 2
select ord;

            foreach (Expenditure ord in query2)
            {
                ord.Amount = OutcomeFebruary;
            }
            var query3 =
from ord in db.Expenditures
where ord.ID == 3
select ord;

            foreach (Expenditure ord in query3)
            {
                ord.Amount = OutcomeMarch;
            }
            var query4 =
from ord in db.Expenditures
where ord.ID == 4
select ord;

            foreach (Expenditure ord in query4)
            {
                ord.Amount = OutcomeApril;
            }
            var query5 =
from ord in db.Expenditures
where ord.ID == 5
select ord;

            foreach (Expenditure ord in query5)
            {
                ord.Amount = OutcomeMay;
            }
            var query6 =
from ord in db.Expenditures
where ord.ID == 6
select ord;

            foreach (Expenditure ord in query6)
            {
                ord.Amount = OutcomeJune;
            }
            var query7 =
from ord in db.Expenditures
where ord.ID == 7
select ord;

            foreach (Expenditure ord in query7)
            {
                ord.Amount = OutcomeJuly;
            }
            var query8 =
from ord in db.Expenditures
where ord.ID == 8
select ord;

            foreach (Expenditure ord in query8)
            {
                ord.Amount = OutcomeAugust;
            }
            var query9 =
from ord in db.Expenditures
where ord.ID == 9
select ord;

            foreach (Expenditure ord in query9)
            {
                ord.Amount = OutcomeSeptember;
            }
            var query10 =
from ord in db.Expenditures
where ord.ID == 10
select ord;

            foreach (Expenditure ord in query10)
            {
                ord.Amount = OutcomeOctober;
            }
            var query11 =
from ord in db.Expenditures
where ord.ID == 11
select ord;

            foreach (Expenditure ord in query11)
            {
                ord.Amount = OutcomeNovember;
            }

            var query12 =
          from ord in db.Expenditures
          where ord.ID == 12
          select ord;

            foreach (Expenditure ord in query12)
            {
                ord.Amount = OutcomeDecember;
            }
            db.SubmitChanges();


            if (IsPostBack)
            {
                SqlConnection con = new SqlConnection(connection);
                SqlDataAdapter da = new SqlDataAdapter("select * from Expenditure", con);
                DataSet ds = new DataSet();
                con.Open();
                da.Fill(ds);
                con.Close();
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _sGenerateXML += "<chart caption='สรุปยอดรวมรายจ่ายของทุกเดือนประจำปี' subcaption='' xAxisName='เดือน' yAxisName='Amount' yAxisMinValue='1000' numberPrefix='฿' showValues='0' alternateHGridColor='0000FF' alternateHGridAlpha='30' divLineColor='CC33CC' divLineAlpha='50' canvasBorderColor='FF0000' baseFontColor='FFRRFF' lineColor='Ff0000'>";
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            _sGenerateXML += "<set label='" + dr["Months"].ToString().Trim() + "' value='" + dr["Amount"].ToString().Trim() + "'/>";
                        }
                        _sGenerateXML += "</chart>";

                        Literal1.Text = FusionCharts.RenderChartHTML("FusionCharts/Line.swf", "", _sGenerateXML.ToString(), "Monthly Sales Report", "1000", "300", false);
                        Literal1.Visible = true;
                    }
                }
            }
        }

    }
}