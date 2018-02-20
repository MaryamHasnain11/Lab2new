using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace lms
{
	public partial class issueArtifact : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{

		}

		protected void issue_Click(object sender, EventArgs e)
		{
			OleDbConnection con = new OleDbConnection();
			OleDbCommand cmd = new OleDbCommand();
			con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
			+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\Lab2new\\lms\\lms\\App_Data\\Database2.accdb";
			cmd.Connection = con;

			string sql = "INSERT into ArtifactIssued([UserId],[ArtifactID]) values(5, 4)";

			con.Open();
			cmd.CommandText = sql;
			cmd.ExecuteNonQuery();
			Server.Transfer("user.aspx");
			con.Close();
		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			OleDbDataReader reader;
			OleDbConnection con = new OleDbConnection();
			OleDbCommand cmd = new OleDbCommand();
			con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
			+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\Lab2new\\lms\\lms\\App_Data\\Database2.accdb";
			cmd.Connection = con;

			int artifactID = int.Parse(TextBox2.Text);

			string sqlSelect = "SELECT * FROM ArtifactIssued WHERE UserID=5 AND ArtifactID=" + artifactID + "";
			con.Open();
			cmd.CommandText = sqlSelect;
			reader = cmd.ExecuteReader();

			//Check if User Have Already Issued That Artifact
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					ArtifactStatus.Controls.Add(new Literal { Text = "You Already Have Issued This Book" });
				}
			}
			//If User Has not Issued the Artifact
			else
			{
				reader.Close();
				con.Close();



				con.Open();
				//Decrement Available Value in Artifacts Table And Check Type of Artifact
				string sqlAvailable = "SELECT Available, Type FROM Artifacts WHERE ID=" + artifactID + "";
				cmd.CommandText = sqlAvailable;
				reader = cmd.ExecuteReader();
				string availCount = "";
				string type = "";
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						availCount = reader.GetString(0);
						type = reader.GetString(1);
					}
				}
				else
				{
					Console.WriteLine("No rows found.");
				}
				reader.Close();
				con.Close();
				int availableCount = int.Parse(availCount);
				if (availableCount == 0)
				{
					ArtifactStatus.Controls.Add(new Literal { Text = "Sorry Artifact is not Available Right Now" });
				}
				else
				{
					//Check the Types of Artifact

					//If Artifact Type in Book
					if (type == "Book")
					{
						//Check How Many Books Does User Owns
						con.Open();
						string booksCount = "SELECT COUNT(*) FROM ArtifactIssued INNER JOIN Artifacts ON Artifacts.ID=ArtifactIssued.ArtifactID WHERE ArtifactIssued.UserID=5 AND Artifacts.Type='Book'";
						cmd.CommandText = booksCount;
						Int32 count = (Int32)cmd.ExecuteScalar();
						con.Close();
						if (count < 3)
						{
							availableCount--;
							con.Open();
							string updateAvailCount = "UPDATE Artifacts SET Available= " + availableCount + " WHERE ID=" + artifactID + "";
							cmd.CommandText = updateAvailCount;
							cmd.ExecuteNonQuery();
							con.Close();
							con.Open();

							string sqlInsert = "INSERT into ArtifactIssued([UserID],[ArtifactID],[Return_Date],[Issued_Date],[Type]) values(5, " + artifactID + ", #" + DateTime.Today.AddDays(30) + "#, #" + DateTime.Today + "#, 'Book')";
							cmd.CommandText = sqlInsert;
							cmd.ExecuteNonQuery();
							con.Close();
							Server.Transfer("user.aspx");
						}
						else
						{
							ArtifactStatus.Controls.Add(new Literal { Text = "Sorry You Cannot Issue More than 3 BOOKS" });

						}
					}

					//If Artifact Type in Dvds
					if (type == "Journal")
					{
						//Check How Many Books Does User Owns
						con.Open();
						string booksCount = "SELECT COUNT(*) FROM ArtifactIssued INNER JOIN Artifacts ON Artifacts.ID=ArtifactIssued.ArtifactID WHERE ArtifactIssued.UserID=5 AND Artifacts.Type='Journal'";
						cmd.CommandText = booksCount;
						Int32 count = (Int32)cmd.ExecuteScalar();
						con.Close();
						if (count < 2)
						{
							availableCount--;
							con.Open();
							string updateAvailCount = "UPDATE Artifacts SET Available= " + availableCount + " WHERE ID=" + artifactID + "";
							cmd.CommandText = updateAvailCount;
							cmd.ExecuteNonQuery();
							con.Close();
							con.Open();
							string sqlInsert = "INSERT into ArtifactIssued([UserID],[ArtifactID],[Return_Date],[Issued_Date],[Type]) values(5, " + artifactID + ", #" + DateTime.Today.AddDays(15) + "#, #" + DateTime.Today + "#, 'Journal')";
							cmd.CommandText = sqlInsert;
							cmd.ExecuteNonQuery();
							con.Close();
							Server.Transfer("user.aspx");
						}
						else
						{
							ArtifactStatus.Controls.Add(new Literal { Text = "Sorry You Cannot Issue More than 2 Journals" });

						}
					}


				}

			}

		} }
	}




