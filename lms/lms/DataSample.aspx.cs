using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace lms
{
	public partial class DataSample : System.Web.UI.Page
	{
		private void Page_Load(object sender, System.EventArgs e)
		{
			//Use a string variable to hold the ConnectionString.
			string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;"
			+ "Data Source=C:\\Users\\Intag\\Documents\\Database1.accdb";

			//Create an OleDbConnection object, 
			//and then pass in the ConnectionString to the constructor.
			OleDbConnection cn = new OleDbConnection(connectString);

			//Open the connection.
			cn.Open();

			//Use a variable to hold the SQL statement.
			string selectString = "SELECT ID, Name, Author FROM Artifacts";

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
			TableHeaderCell contactNameHeading = new TableHeaderCell();
			contactNameHeading.Text = " Name";
			contactNameHeading.HorizontalAlign = HorizontalAlign.Left;
			tableHeading.Cells.Add(contactNameHeading);

			//Create and add the cells that contain the Phone column heading text.
			TableHeaderCell phoneHeading = new TableHeaderCell();
			phoneHeading.Text = "Author";
			phoneHeading.HorizontalAlign = HorizontalAlign.Left;
			tableHeading.Cells.Add(phoneHeading);

			DisplayTable.Rows.Add(tableHeading);

			//Loop through the resultant data selection and add the data value
			//for each respective column in the table.
			while (reader.Read())
			{
				TableRow detailsRow = new TableRow();
				TableCell customerIDCell = new TableCell();
				customerIDCell.Text = reader["ID"].ToString();
				detailsRow.Cells.Add(customerIDCell);

				TableCell contactNameCell = new TableCell();
				contactNameCell.Text = reader["Name"].ToString();
				detailsRow.Cells.Add(contactNameCell);

				TableCell phoneCell = new TableCell();
				phoneCell.Text = reader["Author"].ToString();
				detailsRow.Cells.Add(phoneCell);

				DisplayTable.Rows.Add(detailsRow);

			}

			//Close the reader and the related connection.
			reader.Close();
			cn.Close();
		}
	}
}