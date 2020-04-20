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
    public partial class Income : System.Web.UI.Page
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



            var TMACostt = (from emp in db.AIncomes where emp.ATime >= startOfMonth && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var TMCostAA = (from emp in db.AIncomes where emp.ATime >= startOfMonth && emp.AType.Contains("การลงทุน/ดอกเบี้ยเงินฝาก") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var TMCostBB = (from emp in db.AIncomes where emp.ATime >= startOfMonth && emp.AType.Contains("ของขวัญ/เสี่ยงโชค") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var TMCostCC = (from emp in db.AIncomes where emp.ATime >= startOfMonth && emp.AType.Contains("เงินเดือน/ค่าจ้าง") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var TMCostDD = (from emp in db.AIncomes where emp.ATime >= startOfMonth && emp.AType.Contains("อื่นๆ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;

            Label11.Text = TMCostAA.ToString();
            Label12.Text = TMCostBB.ToString();
            Label13.Text = TMCostCC.ToString();
            Label14.Text = TMCostDD.ToString();
            Label15.Text = TMACostt.ToString();



            //last month



            var LMACostt = (from emp in db.AIncomes where emp.ATime < startOfMonth && emp.ATime >= startOfMonth.AddMonths(-1) && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var LMCostAA = (from emp in db.AIncomes where emp.ATime < startOfMonth && emp.ATime >= startOfMonth.AddMonths(-1) && emp.AType.Contains("การลงทุน/ดอกเบี้ยเงินฝาก") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var LMCostBB = (from emp in db.AIncomes where emp.ATime < startOfMonth && emp.ATime >= startOfMonth.AddMonths(-1) && emp.AType.Contains("ของขวัญ/เสี่ยงโชค") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var LMCostCC = (from emp in db.AIncomes where emp.ATime < startOfMonth && emp.ATime >= startOfMonth.AddMonths(-1) && emp.AType.Contains("เงินเดือน/ค่าจ้าง") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var LMCostDD = (from emp in db.AIncomes where emp.ATime < startOfMonth && emp.ATime >= startOfMonth.AddMonths(-1) && emp.AType.Contains("อื่นๆ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            Label16.Text = LMCostAA.ToString();
            Label17.Text = LMCostBB.ToString();
            Label18.Text = LMCostCC.ToString();
            Label19.Text = LMCostDD.ToString();
            Label20.Text = LMACostt.ToString();





            ////this year

            var ACostt = (from emp in db.AIncomes where emp.ATime >= startOfYear && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var CostAA = (from emp in db.AIncomes where emp.ATime >= startOfYear && emp.AType.Contains("การลงทุน/ดอกเบี้ยเงินฝาก") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var CostBB = (from emp in db.AIncomes where emp.ATime >= startOfYear && emp.AType.Contains("ของขวัญ/เสี่ยงโชค") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var CostCC = (from emp in db.AIncomes where emp.ATime >= startOfYear && emp.AType.Contains("เงินเดือน/ค่าจ้าง") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var CostDD = (from emp in db.AIncomes where emp.ATime >= startOfYear && emp.AType.Contains("อื่นๆ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            Label6.Text = CostAA.ToString();
            Label7.Text = CostBB.ToString();
            Label8.Text = CostCC.ToString();
            Label9.Text = CostDD.ToString();
            Label10.Text = ACostt.ToString();




            ////last year

            var ACost = (from emp in db.AIncomes where emp.ATime < startOfYear && emp.ATime >= startOfYear.AddYears(-1) && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var CostA = (from emp in db.AIncomes where emp.ATime < startOfYear && emp.ATime >= startOfYear.AddYears(-1) && emp.AType.Contains("การลงทุน/ดอกเบี้ยเงินฝาก") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var CostB = (from emp in db.AIncomes where emp.ATime < startOfYear && emp.ATime >= startOfYear.AddYears(-1) && emp.AType.Contains("ของขวัญ/เสี่ยงโชค") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var CostC = (from emp in db.AIncomes where emp.ATime < startOfYear && emp.ATime >= startOfYear.AddYears(-1) && emp.AType.Contains("เงินเดือน/ค่าจ้าง") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var CostD = (from emp in db.AIncomes where emp.ATime < startOfYear && emp.ATime >= startOfYear.AddYears(-1) && emp.AType.Contains("อื่นๆ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            Label1.Text = CostA.ToString();
            Label2.Text = CostB.ToString();
            Label3.Text = CostC.ToString();
            Label4.Text = CostD.ToString();
            Label5.Text = ACost.ToString();

            //

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


            var IncomeJanuary = (from emp in db.AIncomes where emp.ATime >= StartJanuary && emp.ATime <= EndJanuary && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeFebruary = (from emp in db.AIncomes where emp.ATime >= StartFebruary && emp.ATime <= EndFebruary && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeMarch = (from emp in db.AIncomes where emp.ATime >= StartMarch && emp.ATime <= EndMarch && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeApril = (from emp in db.AIncomes where emp.ATime >= StartApril && emp.ATime <= EndApril && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeMay = (from emp in db.AIncomes where emp.ATime >= StartMay && emp.ATime <= EndMay && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeJune = (from emp in db.AIncomes where emp.ATime >= StartJune && emp.ATime <= EndJune && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeJuly = (from emp in db.AIncomes where emp.ATime >= StartJuly && emp.ATime <= EndJuly && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeAugust = (from emp in db.AIncomes where emp.ATime >= StartAugust && emp.ATime <= EndAugust && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeSeptember = (from emp in db.AIncomes where emp.ATime >= StartSeptember && emp.ATime <= EndSeptember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeOctober = (from emp in db.AIncomes where emp.ATime >= StartOctober && emp.ATime <= EndOctober && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeNovember = (from emp in db.AIncomes where emp.ATime >= StartNovember && emp.ATime <= EndNovember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeDecember = (from emp in db.AIncomes where emp.ATime >= StartDecember && emp.ATime <= EndDecember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;

            var query1 =
from ord in db.Incomes
where ord.ID == 1
select ord;

            foreach (Income ord in query1)
            {
                ord.Amount = IncomeJanuary;
            }
            var query2 =
from ord in db.Incomes
where ord.ID == 2
select ord;

            foreach (Income ord in query2)
            {
                ord.Amount = IncomeFebruary;
            }
            var query3 =
from ord in db.Incomes
where ord.ID == 3
select ord;

            foreach (Income ord in query3)
            {
                ord.Amount = IncomeMarch;
            }
            var query4 =
from ord in db.Incomes
where ord.ID == 4
select ord;

            foreach (Income ord in query4)
            {
                ord.Amount = IncomeApril;
            }
            var query5 =
from ord in db.Incomes
where ord.ID == 5
select ord;

            foreach (Income ord in query5)
            {
                ord.Amount = IncomeMay;
            }
            var query6 =
from ord in db.Incomes
where ord.ID == 6
select ord;

            foreach (Income ord in query6)
            {
                ord.Amount = IncomeJune;
            }
            var query7 =
from ord in db.Incomes
where ord.ID == 7
select ord;

            foreach (Income ord in query7)
            {
                ord.Amount = IncomeJuly;
            }
            var query8 =
from ord in db.Incomes
where ord.ID == 8
select ord;

            foreach (Income ord in query8)
            {
                ord.Amount = IncomeAugust;
            }
            var query9 =
from ord in db.Incomes
where ord.ID == 9
select ord;

            foreach (Income ord in query9)
            {
                ord.Amount = IncomeSeptember;
            }
            var query10 =
from ord in db.Incomes
where ord.ID == 10
select ord;

            foreach (Income ord in query10)
            {
                ord.Amount = IncomeOctober;
            }
            var query11 =
from ord in db.Incomes
where ord.ID == 11
select ord;

            foreach (Income ord in query11)
            {
                ord.Amount = IncomeNovember;
            }

            var query12 =
          from ord in db.Incomes
          where ord.ID == 12
          select ord;

            foreach (Income ord in query12)
            {
                ord.Amount = IncomeDecember;
            }
            db.SubmitChanges();


            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection(connection);
                SqlDataAdapter da = new SqlDataAdapter("select * from Income", con);
                DataSet ds = new DataSet();
                con.Open();
                da.Fill(ds);
                con.Close();
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _sGenerateXML += "<chart caption='สรุปยอดรวมรายรับของทุกเดือนประจำปี' subcaption='' xAxisName='เดือน' yAxisName='Amount' yAxisMinValue='1000' numberPrefix='฿' showValues='0' alternateHGridColor='0000FF' alternateHGridAlpha='30' divLineColor='CC33CC' divLineAlpha='50' canvasBorderColor='FF0000' baseFontColor='FFRRFF' lineColor='Ff0000'>";
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
                    var Cost1 = (from emp in db.AIncomes where emp.ATime >= idYear && emp.ATime < idYear2 && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
                    var Cost2 = (from emp in db.AIncomes where emp.ATime >= idYear && emp.ATime < idYear2 && emp.AType.Contains("การลงทุน/ดอกเบี้ยเงินฝาก") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
                    var Cost3 = (from emp in db.AIncomes where emp.ATime >= idYear && emp.ATime < idYear2 && emp.AType.Contains("ของขวัญ/เสี่ยงโชค") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
                    var Cost4 = (from emp in db.AIncomes where emp.ATime >= idYear && emp.ATime < idYear2 && emp.AType.Contains("เงินเดือน/ค่าจ้าง") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
                    var Cost5 = (from emp in db.AIncomes where emp.ATime >= idYear && emp.ATime < idYear2 && emp.AType.Contains("อื่นๆ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
                    Label21.Text = Cost2.ToString();
                    Label22.Text = Cost3.ToString();
                    Label23.Text = Cost4.ToString();
                    Label24.Text = Cost5.ToString();
                    Label25.Text = Cost1.ToString();

                }
                else
                {
                    var idYear2 = new DateTime(y1, m1 + 1, 1);
                    var Cost1 = (from emp in db.AIncomes where emp.ATime >= idYear && emp.ATime < idYear2 && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
                    var Cost2 = (from emp in db.AIncomes where emp.ATime >= idYear && emp.ATime < idYear2 && emp.AType.Contains("การลงทุน/ดอกเบี้ยเงินฝาก") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
                    var Cost3 = (from emp in db.AIncomes where emp.ATime >= idYear && emp.ATime < idYear2 && emp.AType.Contains("ของขวัญ/เสี่ยงโชค") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
                    var Cost4 = (from emp in db.AIncomes where emp.ATime >= idYear && emp.ATime < idYear2 && emp.AType.Contains("เงินเดือน/ค่าจ้าง") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
                    var Cost5 = (from emp in db.AIncomes where emp.ATime >= idYear && emp.ATime < idYear2 && emp.AType.Contains("อื่นๆ") && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
                    Label21.Text = Cost2.ToString();
                    Label22.Text = Cost3.ToString();
                    Label23.Text = Cost4.ToString();
                    Label24.Text = Cost5.ToString();
                    Label25.Text = Cost1.ToString();
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


            var IncomeJanuary = (from emp in db.AIncomes where emp.ATime >= StartJanuary && emp.ATime <= EndJanuary && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeFebruary = (from emp in db.AIncomes where emp.ATime >= StartFebruary && emp.ATime <= EndFebruary && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeMarch = (from emp in db.AIncomes where emp.ATime >= StartMarch && emp.ATime <= EndMarch && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeApril = (from emp in db.AIncomes where emp.ATime >= StartApril && emp.ATime <= EndApril && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeMay = (from emp in db.AIncomes where emp.ATime >= StartMay && emp.ATime <= EndMay && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeJune = (from emp in db.AIncomes where emp.ATime >= StartJune && emp.ATime <= EndJune && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeJuly = (from emp in db.AIncomes where emp.ATime >= StartJuly && emp.ATime <= EndJuly && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeAugust = (from emp in db.AIncomes where emp.ATime >= StartAugust && emp.ATime <= EndAugust && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeSeptember = (from emp in db.AIncomes where emp.ATime >= StartSeptember && emp.ATime <= EndSeptember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeOctober = (from emp in db.AIncomes where emp.ATime >= StartOctober && emp.ATime <= EndOctober && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeNovember = (from emp in db.AIncomes where emp.ATime >= StartNovember && emp.ATime <= EndNovember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var IncomeDecember = (from emp in db.AIncomes where emp.ATime >= StartDecember && emp.ATime <= EndDecember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;

            var query1 =
from ord in db.Incomes
where ord.ID == 1
select ord;

            foreach (Income ord in query1)
            {
                ord.Amount = IncomeJanuary;
            }
            var query2 =
from ord in db.Incomes
where ord.ID == 2
select ord;

            foreach (Income ord in query2)
            {
                ord.Amount = IncomeFebruary;
            }
            var query3 =
from ord in db.Incomes
where ord.ID == 3
select ord;

            foreach (Income ord in query3)
            {
                ord.Amount = IncomeMarch;
            }
            var query4 =
from ord in db.Incomes
where ord.ID == 4
select ord;

            foreach (Income ord in query4)
            {
                ord.Amount = IncomeApril;
            }
            var query5 =
from ord in db.Incomes
where ord.ID == 5
select ord;

            foreach (Income ord in query5)
            {
                ord.Amount = IncomeMay;
            }
            var query6 =
from ord in db.Incomes
where ord.ID == 6
select ord;

            foreach (Income ord in query6)
            {
                ord.Amount = IncomeJune;
            }
            var query7 =
from ord in db.Incomes
where ord.ID == 7
select ord;

            foreach (Income ord in query7)
            {
                ord.Amount = IncomeJuly;
            }
            var query8 =
from ord in db.Incomes
where ord.ID == 8
select ord;

            foreach (Income ord in query8)
            {
                ord.Amount = IncomeAugust;
            }
            var query9 =
from ord in db.Incomes
where ord.ID == 9
select ord;

            foreach (Income ord in query9)
            {
                ord.Amount = IncomeSeptember;
            }
            var query10 =
from ord in db.Incomes
where ord.ID == 10
select ord;

            foreach (Income ord in query10)
            {
                ord.Amount = IncomeOctober;
            }
            var query11 =
from ord in db.Incomes
where ord.ID == 11
select ord;

            foreach (Income ord in query11)
            {
                ord.Amount = IncomeNovember;
            }

            var query12 =
          from ord in db.Incomes
          where ord.ID == 12
          select ord;

            foreach (Income ord in query12)
            {
                ord.Amount = IncomeDecember;
            }
            db.SubmitChanges();


            if (IsPostBack)
            {
                SqlConnection con = new SqlConnection(connection);
                SqlDataAdapter da = new SqlDataAdapter("select * from Income", con);
                DataSet ds = new DataSet();
                con.Open();
                da.Fill(ds);
                con.Close();
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _sGenerateXML += "<chart caption='สรุปยอดรวมรายรับของทุกเดือนประจำปี' subcaption='' xAxisName='เดือน' yAxisName='Amount' yAxisMinValue='1000' numberPrefix='฿' showValues='0' alternateHGridColor='0000FF' alternateHGridAlpha='30' divLineColor='CC33CC' divLineAlpha='50' canvasBorderColor='FF0000' baseFontColor='FFRRFF' lineColor='Ff0000'>";
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