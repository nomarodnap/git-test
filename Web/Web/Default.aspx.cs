using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;
using System.Web.Configuration;

namespace Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null) { Response.Redirect("Login.aspx"); }



        }


        protected void cmdAdd1_Click(object sender, EventArgs e)
        {




            if ((txtItem.Text.Trim() != "") && (txtCost.Text.Trim() != "") && (txtCost.Text.Trim() != "จำนวนเงิน"))
            {
                DatabaseDataContext db = new DatabaseDataContext();

                var ts = (from t in db.AIncomes
                          orderby t.AID descending
                          select t).Take(1);
                int LastAID = 0;
                if (ts.Count() > 0)
                {
                    var CurrentAID = ts.FirstOrDefault().AID;
                    int RunningAID;
                    RunningAID = CurrentAID;
                    RunningAID++;
                    LastAID = RunningAID;
                }
                else { LastAID = 1; }

                AIncome p = new AIncome();
                p.AID = LastAID;
                p.ATime = DateTime.Now;
                p.AType = ddlIncome.SelectedItem.Text;
                p.AItem = txtItem.Text.Trim();
                p.ACost = decimal.Parse(txtCost.Text);
                p.username = Session["username"].ToString();

                
                db.AIncomes.InsertOnSubmit(p);
                db.SubmitChanges();
                GridView2.DataBind();
                txtItem.Text = "";
                txtCost.Text = "";


            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if ((TextBox3.Text.Trim() != "") && (TextBox4.Text.Trim() != "") && (TextBox4.Text.Trim() != "จำนวนเงิน"))
            {
                DatabaseDataContext db = new DatabaseDataContext();

                var ts = (from t in db.Outcomes
                          orderby t.OID descending
                          select t).Take(1);
                int LastOID = 0;
                if (ts.Count() > 0)
                {
                    var CurrentOID = ts.FirstOrDefault().OID;
                    int RunningOID;
                    RunningOID = CurrentOID;
                    RunningOID++;
                    LastOID = RunningOID;
                }
                else { LastOID = 1; }

                Outcome w = new Outcome();
                w.OID = LastOID;
                w.OTime = DateTime.Now;
                w.OType = DropDownList2.SelectedItem.Text;
                w.OItem = TextBox3.Text.Trim();
                w.OCost = decimal.Parse(TextBox4.Text);
                w.username = Session["username"].ToString();


                db.Outcomes.InsertOnSubmit(w);
                db.SubmitChanges();
                GridView3.DataBind();
                TextBox4.Text = "";
                TextBox3.Text = "";
            }





        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}