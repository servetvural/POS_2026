<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tables.aspx.cs" Inherits="MobilePad.Tables" %>

<%@ Register Src="Header.ascx" TagName="Header" TagPrefix="uc1" %>

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

            <asp:DataList ID="dlTables" runat="server" CellSpacing="1"
                RepeatColumns="3" RepeatDirection="Horizontal" OnItemCommand="dlTables_ItemCommand">
                <ItemStyle HorizontalAlign="Center" CssClass="EntityButtonOut" />
                <ItemTemplate>
                    <asp:Label ID="TableIID" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "IID") %>'
                        Visible="False">
                    </asp:Label>
                    <asp:LinkButton ID="TableName" runat="server" Height="35" Width="100" CssClass="EntityButton"
                        Text='<%# DataBinder.Eval(Container.DataItem,"TableName")%>'>
                    </asp:LinkButton>
                </ItemTemplate>
            </asp:DataList>

        </div>
    </form>
</body>
</html>
