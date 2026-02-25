<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="Default.aspx.cs" Inherits="MobilePad.Default"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="main.css" rel="stylesheet" />
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
</head>
<body class="DefaultBody">
    
    <form id="form1" runat="server">
                                    
    <div>
        <table id="Table1" align="center" border="0" cellpadding="3" cellspacing="1" style="z-index: 101;
            left: 8px; width: 250px; top: 8px; height: 296px" width="310">
            <tr>
                <td >
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red" Height="25px"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center">
                   
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"   Wrap="False" Font-Size="X-Large"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <table width="250">
                        <tr>
                            <td>
                                <asp:Button ID="btnCancel" runat="server" CssClass="LoginPad" Height="73px" 
                                    Text="C" Width="125px" onclick="btnCancel_Click" BackColor="Red" />
                            </td>
                            <td>
                                <asp:Button ID="btnLogin" runat="server" CssClass="LoginPad" Height="73px" 
                                    Text="LOGIN" Width="125px" BackColor="#009933" onclick="btnLogin_Click" />

                            </td>
                        </tr>
                       
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                    &nbsp; &nbsp;
                    </td>
            </tr>
        </table>
    
    </div>
        <asp:Label ID="lblDebug" runat="server"></asp:Label>
    </form>
</body>
</html>
