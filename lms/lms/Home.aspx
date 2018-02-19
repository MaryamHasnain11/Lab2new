<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="lms.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
		<center>
        <div style="border:solid">
			<div>
        	<h3>Welcome to Library System</h3><br />
        </div>
		<div>Search By: &nbsp
			<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
				<asp:ListItem Text="All"></asp:ListItem>
				<asp:ListItem Text="Author"></asp:ListItem>
				<asp:ListItem Text="Title"></asp:ListItem>
				<asp:ListItem Text="Genre"></asp:ListItem>
			</asp:DropDownList>
		&nbsp	<input type="search"  id="search"/><input id="Submit1" type="submit" value="submit" /></div>
 </center> </div>  
	
	<p>
		&nbsp;</p>
		
		
	<div>
		
		
		<asp:Table ID="DisplayTable"  GridLines="Both" HorizontalAlign="Center" BorderStyle="Solid"  runat="server">
			
		</asp:Table><br />
		<asp:Table ID="DisplayTable2"  GridLines="Both" HorizontalAlign="Center" BorderStyle="Solid"  runat="server">
			
		</asp:Table>

		</div>

		
	</form>
	
	</body>
</html>
