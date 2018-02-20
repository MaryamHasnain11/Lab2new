
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Web.UI.WebControls;
using System.Windows.Forms;
namespace lms
{
	public partial class Search : System.Web.UI.Page

	{
		string bname = "";
		String IssueD = "";
		String S_id;
		String Sname;
		string b_id;


		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{ BindDropDownList(); }
		}


		private void BindDropDownList()
		{
			// Declare a Dictionary to hold all the Options with Value and Text.
			Dictionary<string, string> options = new Dictionary<string, string>();
			options.Add("-1", "All");
			options.Add("1", "Title");
			options.Add("2", "Genre");
			options.Add("3", "Author");

			// Bind the Dictionary to the DropDownList.
			DropDownList1.DataSource = options;
			DropDownList1.DataTextField = "value";
			DropDownList1.DataValueField = "key";
			DropDownList1.DataBind();
		}

		protected void TextBox1_TextChanged(object sender, EventArgs e)
		{


		}

		protected void MakeItCommon()
		{
			List<ListItem> toBeRemoved = new List<ListItem>();
			String check = "";
			int i = 0;
			foreach (var item in CheckBoxList2.Items)
			{

				if (check != item.ToString())
				{
					check = item.ToString();
				}
				else
				{
					toBeRemoved.Add(CheckBoxList2.Items[i]);

				}

				i += 1;
			}


			for (int j = 0; j < toBeRemoved.Count; j++)
			{
				CheckBoxList2.Items.Remove(toBeRemoved[j]);
			}

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			//MessageBox.Show("k");
			OleDbConnection con = new OleDbConnection();
			con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
			+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\Lab2new\\lms\\lms\\App_Data\\Database1.accdb";
			con.Open();
			string selectString = "select Distinct Artifacts.ISBN,Title,Author,Publication,Genre,Type from Artifacts Where " + DropDownList1.SelectedItem.Text.ToString() + " like'" + TextBox1.Text + "%'";
			OleDbCommand cmd = new OleDbCommand(selectString, con);

			cmd.Parameters.AddWithValue("@TextS", DropDownList1.SelectedItem.Text);
			cmd.Parameters.AddWithValue("@Text", TextBox1.Text);
			cmd.Connection = con;


			//MessageBox.Show(DropDownList1.SelectedItem.Text.ToString());

			foreach (DataGridViewColumn column in GridView1.Columns)
				column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

			GridView1.AutoGenerateColumns = true;
			OleDbDataReader dr = cmd.ExecuteReader();
			List<ListItem> toBeRemoved = new List<ListItem>();
			for (int i = 0; i < CheckBoxList2.Items.Count; i++)
			{

				toBeRemoved.Add(CheckBoxList2.Items[i]);
			}

			for (int i = 0; i < toBeRemoved.Count; i++)
			{
				CheckBoxList2.Items.Remove(toBeRemoved[i]);
			}
			CheckBoxList2.DataSource = null;
			GridView1.DataSource = null;
			GridView1.DataBind();
			GridView1.DataSource = dr;
			GridView1.DataBind();
			dr.Close();
			dr = cmd.ExecuteReader();
			while (dr.Read())
			{

				CheckBoxList2.Items.Add(dr[1].ToString() + "\t" + dr[5].ToString());

			}

		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			//j
			OleDbConnection con = new OleDbConnection();
			con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
			+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\Lab2new\\lms\\lms\\App_Data\\Database1.accdb";
			con.Open();
			string selectString = "select Distinct Artifacts.ISBN,Title,Author,Publication,Genre,Type from Artifacts,a Where a.Status='" + "available' and Artifacts.Type='" + "Journal'";
			OleDbCommand cmd = new OleDbCommand(selectString, con);
			MessageBox.Show(DropDownList1.SelectedItem.Text);
			cmd.Parameters.AddWithValue("@TextS", DropDownList1.SelectedItem.Text);
			cmd.Parameters.AddWithValue("@Text", TextBox1.Text);
			cmd.Connection = con;

			foreach (DataGridViewColumn column in GridView1.Columns)
				column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			List<ListItem> toBeRemoved = new List<ListItem>();
			for (int i = 0; i < CheckBoxList2.Items.Count; i++)
			{

				toBeRemoved.Add(CheckBoxList2.Items[i]);
			}

			for (int i = 0; i < toBeRemoved.Count; i++)
			{
				CheckBoxList2.Items.Remove(toBeRemoved[i]);
			}
			GridView1.AutoGenerateColumns = true;
			OleDbDataReader dr = cmd.ExecuteReader();
			CheckBoxList2.DataSource = null;
			GridView1.DataSource = null;
			GridView1.DataBind();
			GridView1.DataSource = dr;
			GridView1.DataBind();
			dr.Close();
			dr = cmd.ExecuteReader();


			while (dr.Read())
			{

				CheckBoxList2.Items.Add(dr[1].ToString());
			}



		}

		private void CheckBoxList2_ItemCheck(object sender, ItemCheckEventArgs e)
		{

		}

		protected void Button4_Click(object sender, EventArgs e)
		{

			OleDbConnection con = new OleDbConnection();
			con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
			+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\Lab2new\\lms\\lms\\App_Data\\Database1.accdb";
			con.Open();
			string selectString = "select Distinct Artifacts.ISBN,Title,Author,Publication,Genre,Type from Artifacts,a Where a.Status='" + "available' and Artifacts.Type='" + "DVD'";
			OleDbCommand cmd = new OleDbCommand(selectString, con);
			MessageBox.Show(DropDownList1.SelectedItem.Text);
			cmd.Parameters.AddWithValue("@TextS", DropDownList1.SelectedItem.Text);
			cmd.Parameters.AddWithValue("@Text", TextBox1.Text);
			cmd.Connection = con;
			foreach (DataGridViewColumn column in GridView1.Columns)
				column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			List<ListItem> toBeRemoved = new List<ListItem>();
			for (int i = 0; i < CheckBoxList2.Items.Count; i++)
			{

				toBeRemoved.Add(CheckBoxList2.Items[i]);
			}

			for (int i = 0; i < toBeRemoved.Count; i++)
			{
				CheckBoxList2.Items.Remove(toBeRemoved[i]);
			}
			GridView1.AutoGenerateColumns = true;
			OleDbDataReader dr = cmd.ExecuteReader();


			while (dr.Read())
			{
				CheckBoxList2.Items.Add(dr[1].ToString() + "\t" + dr[5].ToString());
			}
			dr.Close();
			dr = cmd.ExecuteReader();
			GridView1.DataSource = null;
			GridView1.DataBind();
			GridView1.DataSource = dr;
			GridView1.DataBind();




		}

		protected void Button3_Click1(object sender, EventArgs e)
		{

			OleDbConnection con = new OleDbConnection();
			con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
			+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\Lab2new\\lms\\lms\\App_Data\\Database1.accdb";
			con.Open();
			string selectString = "select Distinct Artifacts.ISBN,Title,Author,Publication,Genre,Type from Artifacts,a Where a.Status='" + "available' and Artifacts.Type='" + "Book'";
			OleDbCommand cmd = new OleDbCommand(selectString, con);
			MessageBox.Show(DropDownList1.SelectedItem.Text);
			cmd.Parameters.AddWithValue("@TextS", DropDownList1.SelectedItem.Text);
			cmd.Parameters.AddWithValue("@Text", TextBox1.Text);
			cmd.Connection = con;
			foreach (DataGridViewColumn column in GridView1.Columns)
				column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			List<ListItem> toBeRemoved = new List<ListItem>();
			for (int i = 0; i < CheckBoxList2.Items.Count; i++)
			{

				toBeRemoved.Add(CheckBoxList2.Items[i]);
			}

			for (int i = 0; i < toBeRemoved.Count; i++)
			{
				CheckBoxList2.Items.Remove(toBeRemoved[i]);
			}
			GridView1.AutoGenerateColumns = true;
			OleDbDataReader dr = cmd.ExecuteReader();


			while (dr.Read())
			{


				CheckBoxList2.Items.Add(dr[1].ToString() + "\t" + dr[5].ToString());
			}
			dr.Close();
			dr = cmd.ExecuteReader();
			GridView1.DataSource = null;
			GridView1.DataBind();
			GridView1.DataSource = dr;
			GridView1.DataBind();





		}

		protected void Grid_SelectedIndexChanged(object sender, EventArgs e)
		{
			string pName = GridView1.SelectedRow.Cells[1].Text;
			// Display the first name from the selected row.
			// In this example, the third column (index 2) contains
			// the first name.
			//MessageBox.Show("You selected " + pName + ".");
		}

		protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		protected void Button5_Click(object sender, EventArgs e)
		{
			String book = "";
			MessageBox.Show("mk");
			for (int ix = 0; ix < CheckBoxList2.Items.Count; ++ix)
			{
				if (CheckBoxList2.Items[ix].Selected == true)
				{
					MessageBox.Show(CheckBoxList2.Items[ix].ToString());
					book = CheckBoxList2.Items[ix].ToString();
				}

			}

			OleDbConnection con = new OleDbConnection();
			con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
			+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\Lab2new\\lms\\lms\\App_Data\\Database1.accdb";
			con.Open();
			string selectString = "select Distinct Artifacts.ISBN,Title,Author,Publication,Genre,Type from Artifacts,a Where a.Status='" + "available' and Artifacts.Title='" + book + "'";
			OleDbCommand cmd = new OleDbCommand(selectString, con);
			cmd.Parameters.AddWithValue("@TextS", DropDownList1.SelectedItem.Text);
			cmd.Parameters.AddWithValue("@Text", TextBox1.Text);
			cmd.Connection = con;
			OleDbDataReader dr = cmd.ExecuteReader();


			while (dr.Read())
			{


				bname = dr[1].ToString();
				b_id = dr[0].ToString();
			}

			Response.Redirect("Issue.aspx?bID" + b_id + "&bName=" + bname);
		}

		protected void CheckBoxList2_SelectedIndexChanged(object sender, EventArgs e)
		{
			MessageBox.Show("mk");

		}

		protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}