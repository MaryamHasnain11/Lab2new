<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="lms.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style>
		.b {
			background-image:url("images/libbg.jpg");
			background-attachment:fixed;
			
		}
		.f {
			background-color:bisque;
			width:500px;
			position:relative;
			left:300px;
			top:100px;
		}
		.d {background-color:black;
			color:bisque
		}
	</style>
</head>
<body class="b">
	<center><h2 class="d" >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Login to your Account</h2></center>
	
    <form class="f" id="form1" runat="server" >
		<center>
       
			<p>
				&nbsp;</p>
			<p>
			Username:&nbsp;
			<asp:TextBox ID="TextBox1" runat="server" required ></asp:TextBox>
		</p>
			<p>
				&nbsp;</p>
		<p>
			Password:&nbsp;
			<asp:TextBox ID="TextBox2"   TextMode="Password" runat="server" required></asp:TextBox>
		</p>
			<p>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:ImageButton ImageUrl="images/login1.png" ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" Height="47px" Width="138px" />
			</p>

		</center></form>
</body>
</html>
