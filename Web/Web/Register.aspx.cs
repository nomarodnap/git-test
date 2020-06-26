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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "") { Label1.Text = "กรุณากรอกข้อมูลให้ครบช่อง"; }

            else { 

                using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString))
                {
                    if (TextBox2.Text == TextBox3.Text)
                    {
                        con.Open();

                        bool exists = false;

                        using (SqlCommand cmd = new SqlCommand("select count(*) from Member where username = @username", con))
                        {
                            cmd.Parameters.AddWithValue("UserName", TextBox1.Text);
                            exists = (int)cmd.ExecuteScalar() > 0;
                        }

                        if (exists)
                        { Label1.Text = "มีสมาชิกนี้ใช้ชื่อนี้แล้ว"; }
                        else
                        {
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO Member values (@username, @password)", con))
                            {
                                cmd.Parameters.AddWithValue("username", TextBox1.Text);
                                cmd.Parameters.AddWithValue("password", TextBox2.Text);
                                cmd.ExecuteNonQuery();
                                Session["username"] = TextBox1.Text;
                                Response.Redirect("Default.aspx");
                            }
                        }

                        con.Close();
                    }
                    else Label1.Text = "ยืนยันรหัสผิด";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }


        }
    }

