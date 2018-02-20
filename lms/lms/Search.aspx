<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="Search.aspx.cs" Inherits="lms.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 1154px;
        }
    	.b {
    	background-color:blanchedalmond;
    	}
    </style>
</head>
<body class="b">
    <form id="form1" runat="server">
       <div> 
		   Search By:<asp:DropDownList ID="DropDownList1" runat="server" Height="36px" style="margin-left: 3px; margin-top: 0px;" Width="150px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"  AutoPostBack="False">
    <asp:ListItem Text="Author" Value="0" />
    <asp:ListItem Text="Genre" Value="0" />
    <asp:ListItem Text="Title" Value="0" />
            </asp:DropDownList>
 Search :<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 6px" Width="118px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="search" Height="20px" style="margin-left: 17px; margin-top: 0px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		 
		 
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <h3>Select Category</h3>  
		   <asp:Button ID="Button2" runat="server" style="margin-left: 49px; margin-top: 0px;" Text="Journals" Height="24px" OnClick="Button2_Click" Width="60px" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="margin-left: 49px" Text="DVDs" Width="69px" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click1" style="margin-left: 76px" Text="Books" Width="68px" />
            <br />
        </div>
        <br />
        <asp:GridView ID="GridView1" runat="server" Height="200px" 
        OnSelectedIndexChanged="Grid_SelectedIndexChanged" Width="275px" style="margin-top: 189px; display:inline" CellPadding="10">
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:CheckBoxList ID="CheckBoxList2" runat="server" OnSelectedIndexChanged="CheckBoxList2_SelectedIndexChanged">
        </asp:CheckBoxList>
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" style="margin-left: 10px; margin-top: 6px" Text="Issue" Width="70px" />
        <br />
        <br />
        <br />
&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Student Registration number:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 122px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Student Name"></asp:Label>
    </form>
</body>
</html>
