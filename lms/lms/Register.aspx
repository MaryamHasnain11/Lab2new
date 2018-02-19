<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="lms.Register" %>

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
			width:316px;
			position:relative;
			left:385px;
			top:68px;
			height: 250px;
		}
		.d {background-color:black;
			color:bisque
		}
		</style>
</head>
<body class="b">
	<center>
	<h2 class="d">Register Yourself<br /></h2></center>
    <form class="f" id="form1" runat="server">
      
		<p>
			&nbsp;</p>
		<p>
			First Name&nbsp;
			<asp:TextBox ID="TextBox1" value="" runat="server" required></asp:TextBox>
		</p>
		<p>
			Last Name&nbsp;&nbsp;
			<asp:TextBox ID="TextBox2"  runat="server" required></asp:TextBox>
		</p>
    	<p>
			Username&nbsp;&nbsp;&nbsp;
			<asp:TextBox ID="TextBox3" runat="server" required></asp:TextBox>
		</p>
		<p>
			Password&nbsp;&nbsp;&nbsp;
			<asp:TextBox ID="TextBox4"   TextMode="Password" runat="server" OnTextChanged="TextBox2_TextChanged" required></asp:TextBox>
		</p>
		<p>
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    	<asp:ImageButton  ImageUrl="images/res.png" ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" Width="113px" Height="47px" />
		</p>
		<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		</p>
    </form>
</body>
</html>
