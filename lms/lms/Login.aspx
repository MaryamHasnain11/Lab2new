<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="lms.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			Login
        </div>
		<p>
			Username&nbsp;
			<asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
		</p>
		<p>
			Password&nbsp;
			<asp:TextBox ID="TextBox2"   TextMode="Password" runat="server" ></asp:TextBox>
		</p>
		<asp:Button ID="Button2" runat="server" Text="Login" OnClick="Button2_Click" />
    </form>
</body>
</html>
