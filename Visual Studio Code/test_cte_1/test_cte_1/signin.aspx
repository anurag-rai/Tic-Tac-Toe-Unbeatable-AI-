<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signin.aspx.cs" Inherits="test_cte_1.signin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign-in</title>
    <link rel="stylesheet" type="text/css" href="trystyle.css">
</head>
<body>
    <div id="header">
        <h1>SIGN-IN</h1>
     </div>

    <!-- the navigation bar on the left -->
    <div id="navbar">
        <ul>
            <li><a href="default.aspx"> Main page </a></li>
		    <li><a href="signup.aspx"> New user?? Sign-Up! </a></li>
		    <li><a href="about.html"> About </a></li>
            <li><a href="features.html"> Main Features </a></li>
        </ul>
	</div>
    <form id="form1" runat="server">

    <!-- the main body -->
    <div>
        <p>
            Name:
            <asp:TextBox ID="namebox" runat="server"></asp:TextBox>
        </p>
        
        <p>
            Password:
            <asp:TextBox ID="passbox" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
        
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign-in" />
    
        <br />
    
    </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
