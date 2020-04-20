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
    public partial class Summary : System.Web.UI.Page
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


            var TMACost = (from emp in db.AIncomes where emp.ATime >= startOfMonth && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var LMACost = (from emp in db.AIncomes where emp.ATime < startOfMonth && emp.ATime >= startOfMonth.AddMonths(-1) && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var TYACost = (from emp in db.AIncomes where emp.ATime >= startOfYear && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var LYACost = (from emp in db.AIncomes where emp.ATime < startOfYear && emp.ATime >= startOfYear.AddYears(-1) && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;

            Label1.Text = TMACost.ToString();
            Label2.Text = LMACost.ToString();
            Label3.Text = TYACost.ToString();
            Label4.Text = LYACost.ToString();

            var TMOCost = (from emp in db.Outcomes where emp.OTime >= startOfMonth && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var LMOCost = (from emp in db.Outcomes where emp.OTime < startOfMonth && emp.OTime >= startOfMonth.AddMonths(-1) && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var TYOCost = (from emp in db.Outcomes where emp.OTime >= startOfYear && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
            var LYOCost = (from emp in db.Outcomes where emp.OTime < startOfYear && emp.OTime >= startOfYear.AddYears(-1) && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;

            Label5.Text = TMOCost.ToString();
            Label6.Text = LMOCost.ToString();
            Label7.Text = TYOCost.ToString();
            Label8.Text = LYOCost.ToString();

            var TMTCost = TMACost - TMOCost;
            var LMTCost = LMACost - LMOCost;
            var TYTCost = TYACost - TYOCost;
            var LYTCost = LYACost - LYOCost;

            Label9.Text = TMTCost.ToString();
            Label10.Text = LMTCost.ToString();
            Label11.Text = TYTCost.ToString();
            Label12.Text = LYTCost.ToString();




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
            var OutcomeJanuary = (from emp in db.Outcomes where emp.OTime >= StartJanuary && emp.OTime <= EndJanuary && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeFebruary = (from emp in db.AIncomes where emp.ATime >= StartFebruary && emp.ATime <= StartFebruary && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeFebruary = (from emp in db.Outcomes where emp.OTime >= StartFebruary && emp.OTime <= EndFebruary && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeMarch = (from emp in db.AIncomes where emp.ATime >= StartMarch && emp.ATime <= EndMarch && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeMarch = (from emp in db.Outcomes where emp.OTime >= StartMarch && emp.OTime <= EndMarch && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeApril = (from emp in db.AIncomes where emp.ATime >= StartApril && emp.ATime <= EndApril && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeApril = (from emp in db.Outcomes where emp.OTime >= StartApril && emp.OTime <= EndApril && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeMay = (from emp in db.AIncomes where emp.ATime >= StartMay && emp.ATime <= EndMay && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeMay = (from emp in db.Outcomes where emp.OTime >= StartMay && emp.OTime <= EndMay && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeJune = (from emp in db.AIncomes where emp.ATime >= StartJune && emp.ATime <= EndJune && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeJune = (from emp in db.Outcomes where emp.OTime >= StartJune && emp.OTime <= EndJune && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeJuly = (from emp in db.AIncomes where emp.ATime >= StartJuly && emp.ATime <= EndJuly && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeJuly = (from emp in db.Outcomes where emp.OTime >= StartJuly && emp.OTime <= EndJuly && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeAugust = (from emp in db.AIncomes where emp.ATime >= StartAugust && emp.ATime <= EndAugust && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeAugust = (from emp in db.Outcomes where emp.OTime >= StartAugust && emp.OTime <= EndAugust && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeSeptember = (from emp in db.AIncomes where emp.ATime >= StartSeptember && emp.ATime <= EndSeptember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeSeptember = (from emp in db.Outcomes where emp.OTime >= StartSeptember && emp.OTime <= EndSeptember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeOctober = (from emp in db.AIncomes where emp.ATime >= StartOctober && emp.ATime <= EndOctober && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeOctober = (from emp in db.Outcomes where emp.OTime >= StartOctober && emp.OTime <= EndOctober && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeNovember = (from emp in db.AIncomes where emp.ATime >= StartNovember && emp.ATime <= EndNovember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeNovember = (from emp in db.Outcomes where emp.OTime >= StartNovember && emp.OTime <= EndNovember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeDecember = (from emp in db.AIncomes where emp.ATime >= StartDecember && emp.ATime <= EndDecember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeDecember = (from emp in db.Outcomes where emp.OTime >= StartDecember && emp.OTime <= EndDecember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var query1 =
            from ord in db.Summaries
            where ord.ID == 1
            select ord;

            foreach (Summary ord in query1)
            {
                ord.Amount = IncomeJanuary - OutcomeJanuary;
            }
            var query2 =
            from ord in db.Summaries
            where ord.ID == 2
            select ord;

            foreach (Summary ord in query2)
            {
                ord.Amount = IncomeFebruary - OutcomeFebruary;
            }
            var query3 =
            from ord in db.Summaries
            where ord.ID == 3
            select ord;

            foreach (Summary ord in query3)
            {
                ord.Amount = IncomeMarch - OutcomeMarch;
            }
            var query4 =
            from ord in db.Summaries
            where ord.ID == 4
            select ord;

            foreach (Summary ord in query4)
            {
                ord.Amount = IncomeApril - OutcomeApril;
            }
            var query5 =
            from ord in db.Summaries
            where ord.ID == 5
            select ord;

            foreach (Summary ord in query5)
            {
                ord.Amount = IncomeMay - OutcomeMay;
            }
            var query6 =
            from ord in db.Summaries
            where ord.ID == 6
            select ord;

            foreach (Summary ord in query6)
            {
                ord.Amount = IncomeJune - OutcomeJune;
            }
            var query7 =
            from ord in db.Summaries
            where ord.ID == 7
            select ord;

            foreach (Summary ord in query7)
            {
                ord.Amount = IncomeJuly - OutcomeJuly;
            }
            var query8 =
            from ord in db.Summaries
            where ord.ID == 8
            select ord;

            foreach (Summary ord in query8)
            {
                ord.Amount = IncomeAugust - OutcomeAugust;
            }
            var query9 =
            from ord in db.Summaries
            where ord.ID == 9
            select ord;

            foreach (Summary ord in query9)
            {
                ord.Amount = IncomeSeptember - OutcomeSeptember;
            }
            var query10 =
            from ord in db.Summaries
            where ord.ID == 10
            select ord;

            foreach (Summary ord in query10)
            {
                ord.Amount = IncomeOctober - OutcomeOctober;
            }
            var query11 =
            from ord in db.Summaries
            where ord.ID == 11
            select ord;

            foreach (Summary ord in query11)
            {
                ord.Amount = IncomeNovember - OutcomeNovember;
            }

            var query12 =
          from ord in db.Summaries
          where ord.ID == 12
          select ord;

            foreach (Summary ord in query12)
            {
                ord.Amount = IncomeDecember - OutcomeDecember;
            }
            db.SubmitChanges();


            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection(connection);
                SqlDataAdapter da = new SqlDataAdapter("select * from Summary", con);
                DataSet ds = new DataSet();
                con.Open();
                da.Fill(ds);
                con.Close();
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _sGenerateXML += "<chart caption='สรุปยอดกำไร/(ขาดทุน)ของทุกเดือนประจำปี' subcaption='' xAxisName='เดือน' yAxisName='Amount' yAxisMinValue='1000' numberPrefix='฿' showValues='0' alternateHGridColor='0000FF' alternateHGridAlpha='30' divLineColor='CC33CC' divLineAlpha='50' canvasBorderColor='FF0000' baseFontColor='FFRRFF' lineColor='Ff0000'>";
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
                    var Cost2 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost3 = Cost1 - Cost2;
                    Label13.Text = Cost1.ToString();
                    Label14.Text = Cost2.ToString();
                    Label15.Text = Cost3.ToString();

                }
                else
                {
                    var idYear2 = new DateTime(y1, m1 + 1, 1);
                    var Cost1 = (from emp in db.AIncomes where emp.ATime >= idYear && emp.ATime < idYear2 && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
                    var Cost2 = (from emp in db.Outcomes where emp.OTime >= idYear && emp.OTime < idYear2 && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;
                    var Cost3 = Cost1 - Cost2;
                    Label13.Text = Cost1.ToString();
                    Label14.Text = Cost2.ToString();
                    Label15.Text = Cost3.ToString();
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
            var OutcomeJanuary = (from emp in db.Outcomes where emp.OTime >= StartJanuary && emp.OTime <= EndJanuary && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeFebruary = (from emp in db.AIncomes where emp.ATime >= StartFebruary && emp.ATime <= StartFebruary && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeFebruary = (from emp in db.Outcomes where emp.OTime >= StartFebruary && emp.OTime <= EndFebruary && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeMarch = (from emp in db.AIncomes where emp.ATime >= StartMarch && emp.ATime <= EndMarch && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeMarch = (from emp in db.Outcomes where emp.OTime >= StartMarch && emp.OTime <= EndMarch && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeApril = (from emp in db.AIncomes where emp.ATime >= StartApril && emp.ATime <= EndApril && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeApril = (from emp in db.Outcomes where emp.OTime >= StartApril && emp.OTime <= EndApril && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeMay = (from emp in db.AIncomes where emp.ATime >= StartMay && emp.ATime <= EndMay && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeMay = (from emp in db.Outcomes where emp.OTime >= StartMay && emp.OTime <= EndMay && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeJune = (from emp in db.AIncomes where emp.ATime >= StartJune && emp.ATime <= EndJune && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeJune = (from emp in db.Outcomes where emp.OTime >= StartJune && emp.OTime <= EndJune && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeJuly = (from emp in db.AIncomes where emp.ATime >= StartJuly && emp.ATime <= EndJuly && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeJuly = (from emp in db.Outcomes where emp.OTime >= StartJuly && emp.OTime <= EndJuly && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeAugust = (from emp in db.AIncomes where emp.ATime >= StartAugust && emp.ATime <= EndAugust && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeAugust = (from emp in db.Outcomes where emp.OTime >= StartAugust && emp.OTime <= EndAugust && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeSeptember = (from emp in db.AIncomes where emp.ATime >= StartSeptember && emp.ATime <= EndSeptember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeSeptember = (from emp in db.Outcomes where emp.OTime >= StartSeptember && emp.OTime <= EndSeptember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeOctober = (from emp in db.AIncomes where emp.ATime >= StartOctober && emp.ATime <= EndOctober && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeOctober = (from emp in db.Outcomes where emp.OTime >= StartOctober && emp.OTime <= EndOctober && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeNovember = (from emp in db.AIncomes where emp.ATime >= StartNovember && emp.ATime <= EndNovember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeNovember = (from emp in db.Outcomes where emp.OTime >= StartNovember && emp.OTime <= EndNovember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var IncomeDecember = (from emp in db.AIncomes where emp.ATime >= StartDecember && emp.ATime <= EndDecember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.ACost).Sum() ?? 0;
            var OutcomeDecember = (from emp in db.Outcomes where emp.OTime >= StartDecember && emp.OTime <= EndDecember && emp.username.Contains(Session["username"].ToString()) select (decimal?)emp.OCost).Sum() ?? 0;


            var query1 =
            from ord in db.Summaries
            where ord.ID == 1
            select ord;

            foreach (Summary ord in query1)
            {
                ord.Amount = IncomeJanuary - OutcomeJanuary;
            }
            var query2 =
            from ord in db.Summaries
            where ord.ID == 2
            select ord;

            foreach (Summary ord in query2)
            {
                ord.Amount = IncomeFebruary - OutcomeFebruary;
            }
            var query3 =
            from ord in db.Summaries
            where ord.ID == 3
            select ord;

            foreach (Summary ord in query3)
            {
                ord.Amount = IncomeMarch - OutcomeMarch;
            }
            var query4 =
            from ord in db.Summaries
            where ord.ID == 4
            select ord;

            foreach (Summary ord in query4)
            {
                ord.Amount = IncomeApril - OutcomeApril;
            }
            var query5 =
            from ord in db.Summaries
            where ord.ID == 5
            select ord;

            foreach (Summary ord in query5)
            {
                ord.Amount = IncomeMay - OutcomeMay;
            }
            var query6 =
            from ord in db.Summaries
            where ord.ID == 6
            select ord;

            foreach (Summary ord in query6)
            {
                ord.Amount = IncomeJune - OutcomeJune;
            }
            var query7 =
            from ord in db.Summaries
            where ord.ID == 7
            select ord;

            foreach (Summary ord in query7)
            {
                ord.Amount = IncomeJuly - OutcomeJuly;
            }
            var query8 =
            from ord in db.Summaries
            where ord.ID == 8
            select ord;

            foreach (Summary ord in query8)
            {
                ord.Amount = IncomeAugust - OutcomeAugust;
            }
            var query9 =
            from ord in db.Summaries
            where ord.ID == 9
            select ord;

            foreach (Summary ord in query9)
            {
                ord.Amount = IncomeSeptember - OutcomeSeptember;
            }
            var query10 =
            from ord in db.Summaries
            where ord.ID == 10
            select ord;

            foreach (Summary ord in query10)
            {
                ord.Amount = IncomeOctober - OutcomeOctober;
            }
            var query11 =
            from ord in db.Summaries
            where ord.ID == 11
            select ord;

            foreach (Summary ord in query11)
            {
                ord.Amount = IncomeNovember - OutcomeNovember;
            }

            var query12 =
          from ord in db.Summaries
          where ord.ID == 12
          select ord;

            foreach (Summary ord in query12)
            {
                ord.Amount = IncomeDecember - OutcomeDecember;
            }
            db.SubmitChanges();


            if (IsPostBack)
            {
                SqlConnection con = new SqlConnection(connection);
                SqlDataAdapter da = new SqlDataAdapter("select * from Summary", con);
                DataSet ds = new DataSet();
                con.Open();
                da.Fill(ds);
                con.Close();
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _sGenerateXML += "<chart caption='สรุปยอดกำไร/(ขาดทุน)ของทุกเดือนประจำปี' subcaption='' xAxisName='เดือน' yAxisName='Amount' yAxisMinValue='1000' numberPrefix='฿' showValues='0' alternateHGridColor='0000FF' alternateHGridAlpha='30' divLineColor='CC33CC' divLineAlpha='50' canvasBorderColor='FF0000' baseFontColor='FFRRFF' lineColor='Ff0000'>";
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