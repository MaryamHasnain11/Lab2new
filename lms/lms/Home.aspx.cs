using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lms
{
	public partial class Home : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{//Use a string variable to hold the ConnectionString.
			string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;"
			+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\Lab2new\\lms\\lms\\App_Data\\Database1.accdb";

			//Create an OleDbConnection object, 
			//and then pass in the ConnectionString to the constructor.
			OleDbConnection cn = new OleDbConnection(connectString);

			//Open the connection.
			cn.Open();

			//Use a variable to hold the SQL statement.
			
			string selectString = "SELECT ID, Name, Author, PublicationDate, Genre, Quantity, Type FROM Artifacts WHERE Type='Book' OR Type='CD' Or Type='Journal' ORDER BY Type ASC;";


			//Create an OleDbCommand object.
			//Notice that this line passes in the SQL statement and the OleDbConnection object
			OleDbCommand cmd = new OleDbCommand(selectString, cn);
			
			//Send the CommandText to the connection, and then build an OleDbDataReader.
			//Note: The OleDbDataReader is forward-only.
			OleDbDataReader reader = cmd.ExecuteReader();
	
			//Set a table width.
			DisplayTable.Width = Unit.Percentage(90.00);

			//Create a new row for adding a table heading.
			TableRow tableHeading = new TableRow();

			//Create and add the cells that contain the Customer ID column heading text.
			TableHeaderCell IDHeading = new TableHeaderCell();
			IDHeading.Text = "ID";
			IDHeading.HorizontalAlign = HorizontalAlign.Left;
			tableHeading.Cells.Add(IDHeading);


			//Create and add the cells that contain the Contact Name column heading text.
			TableHeaderCell NameHeading = new TableHeaderCell();
			NameHeading.Text = "Name";
			NameHeading.HorizontalAlign = HorizontalAlign.Left;
			tableHeading.Cells.Add(NameHeading);

			//Create and add the cells that contain the Phone column heading text.
			TableHeaderCell AuthorName = new TableHeaderCell();
			AuthorName.Text = "Author Name";
			AuthorName.HorizontalAlign = HorizontalAlign.Left;
			tableHeading.Cells.Add(AuthorName);


			//Genre
			TableHeaderCell genre = new TableHeaderCell();
			genre.Text = "Genre";
			genre.HorizontalAlign = HorizontalAlign.Left;
			tableHeading.Cells.Add(genre);

			//quantity
			TableHeaderCell qty = new TableHeaderCell();
			qty.Text = "Quantity";
			AuthorName.HorizontalAlign = HorizontalAlign.Left;
			tableHeading.Cells.Add(qty);
			DisplayTable.Rows.Add(tableHeading);
			
			//issue
			TableHeaderCell issue = new TableHeaderCell();
			issue.Text = "Type";
			AuthorName.HorizontalAlign = HorizontalAlign.Left;
			tableHeading.Cells.Add(issue);
			DisplayTable.Rows.Add(tableHeading);
		
			//Loop through the resultant data selection and add the data value
			//for each respective column in the table.
			while (reader.Read())
			{
				TableRow detailsRow = new TableRow();
				TableCell IDCell = new TableCell();
				IDCell.Text = reader["ID"].ToString();
				detailsRow.Cells.Add(IDCell);

				TableCell NameCell = new TableCell();
				NameCell.Text = reader["Name"].ToString();
				detailsRow.Cells.Add(NameCell);

				TableCell AuthorCell = new TableCell();
				AuthorCell.Text = reader["Author"].ToString();
				detailsRow.Cells.Add(AuthorCell);

				

				TableCell GCell = new TableCell();
				GCell.Text = reader["Genre"].ToString();
				detailsRow.Cells.Add(GCell);

				TableCell QCell = new TableCell();
				QCell.Text = reader["Quantity"].ToString();
				detailsRow.Cells.Add(QCell);

				TableCell iss= new TableCell();
				iss.Text = reader["Type"].ToString();
				detailsRow.Cells.Add(iss);
				DisplayTable.Rows.Add(detailsRow);
			
			}
			

			//Close the reader and the related connection.
			reader.Close();
			
			cn.Close();

		}

		protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}