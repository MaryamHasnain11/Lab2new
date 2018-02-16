using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lms
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			String userName = TextBox1.Text.ToString();
			;
			String pasword = TextBox2.Text.ToString();
			OleDbConnection con = new OleDbConnection();
			//Use a string variable to hold the ConnectionString.
			con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
			+ "Data Source=C:\\Users\\Intag\\Documents\\Database1.accdb";
			string query = @"select count(*) from Users where Username=@userName and Pasword = @pasword;";
			OleDbCommand cmd = new OleDbCommand(query, con);

			con.Open();
			cmd.Parameters.AddWithValue("@userName", TextBox1.Text);
			cmd.Parameters.AddWithValue("@pasword", TextBox2.Text);
			int result = (int)cmd.ExecuteScalar();
			if (result > 0)
			{
				Response.Write("<script>alert('login successful');</script>");
				Response.Redirect("Home.aspx");
			}

			else
			{
				Response.Write("<script>alert('login not successful');</script>");
			}


			con.Close();


		}



	}
}