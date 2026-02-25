<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="MobilePad.Reports" %>

<%@ Register src="Header.ascx" tagname="Header" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="main.css" rel="stylesheet" type="text/css" />
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
    <style type="text/css">
        .auto-style1 {
            width: 300px;
        }
        .auto-style2 {
            width: 135px;
            height:40px;
        }
        .auto-style3 {
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:Header ID="Header1" runat="server" />
    
        <br />
    
    </div>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">User Name</td>
            <td class="auto-style3">
                <asp:Label ID="lblUserName" runat="server" CssClass="LoginLabel"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Number of Orders</td>
            <td class="auto-style3">
                <asp:Label ID="lblNumberOfOrders" runat="server" CssClass="LoginLabel"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Order Total</td>
            <td class="auto-style3">
                <asp:Label ID="lblOrderTotal" runat="server" CssClass="LoginLabel"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Session Total</td>
            <td class="auto-style3">
                <asp:Label ID="lblSessionTotal" runat="server" CssClass="LoginLabel"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Personal Sale Percentage</td>
            <td class="auto-style3">
                <asp:Label ID="lblPercentage" runat="server" CssClass="LoginLabel"></asp:Label>
            </td>
        </tr>
        </table>
    </form>
    </body>
</html>
