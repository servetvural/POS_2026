<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderList.aspx.cs" Inherits="MobilePad.OrderList" %>

<%@ Register src="Header.ascx" tagname="Header" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="main.css" rel="stylesheet" type="text/css" />
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:Header ID="Header1" runat="server" />
      <br />

        &nbsp;<asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>

        <asp:DataList ID="dlOrders" runat="server" CellSpacing="4" 
                RepeatColumns="1" RepeatDirection="Horizontal" OnItemCommand="dlOrders_ItemCommand">
                <ItemStyle HorizontalAlign="Center" CssClass="EntityButtonOut" />
                <ItemTemplate>
                    <asp:Label ID="OrderIID" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "IID") %>'
                        Visible="False">
                    </asp:Label>
                    <asp:LinkButton ID="OrderText" runat="server" Height="35" Width="300" CssClass="EntityButton"
                        Text='<%# DataBinder.Eval(Container.DataItem,"OrderDate","{0:HH:mm}") + "&nbsp;&nbsp;&nbsp;====&nbsp;&nbsp;&nbsp;" + DataBinder.Eval(Container.DataItem,"CalculatedValue","{0:c2}")%>'>
                    </asp:LinkButton>
                </ItemTemplate>
            </asp:DataList>

        <br />
&nbsp;
        <asp:Button ID="btnScoope" runat="server" Height="35px" OnClick="btnScoope_Click" Text="ALL ORDERS" Width="300px" />

        <br />
        </div>
    </form>
</body>
</html>
