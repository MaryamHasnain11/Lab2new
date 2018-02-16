<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="lms.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	Resgister<br />
		</div>
		<p>
			First Name&nbsp;
			<asp:TextBox ID="TextBox1" value="" runat="server"></asp:TextBox>
		</p>
		<p>
			Last Name&nbsp;&nbsp;
			<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
		</p>
    	<p>
			Username&nbsp;
			<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
		</p>
		<p>
			Password&nbsp;
			<asp:TextBox ID="TextBox4"   TextMode="Password" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
		</p>
		<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
    </form>
</body>
</html>
