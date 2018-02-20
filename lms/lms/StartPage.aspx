<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartPage.aspx.cs" Inherits="lms.StartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style>
		.bg {
			background-image:url("images/lib2.jpg");
			background-attachment:fixed;
			
			color:white
				
		}
	
	</style>
</head>
<body class="bg">
    <form id="form1" runat="server">
		<br /><br />
        <div>
			<center><h2>Welcome to Library Management System</h2></center>
        </div><br/><br />
		<center>
			Click on Login if you are a returning user <br />
			Click on register if you are a new user
		<div>
			<asp:ImageButton  ImageUrl="images/login1.png" ID="ImageButton1" runat="server" Height="184px" Width="347px" style="margin-bottom: 0px;margin-left:20px" OnClick="ImageButton1_Click" />

			
		<asp:ImageButton  ImageUrl="images/res.png" ID="ImageButton2" runat="server" Height="182px" Width="323px" style="margin-bottom: 0px;margin-left:20px" OnClick="ImageButton2_Click" />
		</div>
	</center>
    </form>
	<p>
		</p>
	</body>
</html>
