<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="test_cte_1.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign-Up</title>
    <link rel="stylesheet" type="text/css" href="trystyle.css">
</head>
<body>
    <div id="header">
        <h1>SIGN-UP</h1>
     </div>

    <!-- The navigation bar on the left -->
    <div id="navbar">
        <ul>
            <li><a href="default.aspx"> Main page </a></li>
		    <li><a href="signin.aspx"> Already have an account? Login </a></li>
            <li><a href="about.html"> About </a></li>
            <li><a href="features.html"> Main Features </a></li>
        </ul>
	</div>
    <form id="form1" runat="server">
        <div>
            <p>
                Name*: <asp:TextBox ID="namebox" runat="server"></asp:TextBox>
                <asp:Label ID="name_label" runat="server"></asp:Label>
            </p>
            <p>
                E-mail id: <asp:TextBox ID="mailbox" runat="server"></asp:TextBox>
            </p>
            <p>
                Password*: <asp:TextBox ID="passbox1" runat="server" TextMode="Password"></asp:TextBox>
            </p>
            <p>
                Re-type Password: <asp:TextBox ID="passbox2" runat="server" TextMode="Password"></asp:TextBox>
            </p> 
            <p>
                <asp:Label ID="pass_label" runat="server"></asp:Label>
            </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="signup_button" runat="server" OnClick="signup_button_Click" Text="Sign-Up" />
            </p>
            </div>      
        </form>
        <p>
            [The * signifies a required field]
        </p>
</body>
</html>
