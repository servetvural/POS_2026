<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderPadSimple.aspx.cs" Inherits="MobilePad.OrderPadSimple" MaintainScrollPositionOnPostback="true"  %>

<%@ Register Src="Header.ascx" TagName="Header" TagPrefix="uc1" %>


<%@ Register src="HoldOrders.ascx" tagname="HoldOrders" tagprefix="uc2" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <!--<meta http-equiv="refresh" content="10" />-->
    <title>Order Pad</title>
    <link href="main.css" rel="stylesheet" />
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
        <style type="text/css">
            .auto-style1 {
                width: 288px;
            }
        </style>
</head>
<body class="OrderPadBody">
    <form id="form1" runat="server">
        <div>
            <uc1:Header ID="Header1" runat="server" />
            <br />
            <table>
                <tr>
                        <td >
                            <uc2:HoldOrders ID="HoldOrders1" runat="server" />
                        </td>
                    </tr>
                
                <tr>
                    <td>
                        <asp:DataList ID="dlEntityList" runat="server" CellSpacing="0" CellPadding="0" OnItemCommand="dlEntityList_ItemCommand"
                            RepeatLayout="Flow" RepeatDirection="Horizontal" ItemStyle-VerticalAlign="Top">

                            <ItemStyle VerticalAlign="Top"></ItemStyle>

                            <ItemTemplate>

                                <asp:Button ID="EntityName" runat="server" Height="50" CssClass="Entity"
                                    Text='<%# DataBinder.Eval(Container.DataItem,"EntityName") %>' CommandArgument='<%# DataBinder.Eval(Container.DataItem, "IID") %>'></asp:Button>

                            </ItemTemplate>

                        </asp:DataList>

                    </td>
                </tr>
            </table>



            <asp:DataList ID="dlSIL" runat="server" CellSpacing="10" CellPadding="10" OnItemCommand="dlEntityButtons_ItemCommand"
                RepeatLayout="Flow" RepeatDirection="Horizontal">
                <ItemStyle HorizontalAlign="Center" BorderWidth="3px" />
                <ItemTemplate>

                    <asp:Button ID="EntityButtonName" runat="server" Height="50" CssClass="EntityButton"
                        Text='<%# DataBinder.Eval(Container.DataItem,"EntityButtonName") %>' CommandArgument='<%# DataBinder.Eval(Container.DataItem, "IID") %>'></asp:Button>
                </ItemTemplate>
            </asp:DataList>

            <br />
            <br />
            <asp:DataGrid ID="dgDisplay" runat="server"
                AutoGenerateColumns="False" CellPadding="3"
                CssClass="ODGrid" BorderWidth="0px"
                OnItemCommand="dgDisplay_ItemCommand" Width="300px" PageSize="20" GridLines="Horizontal">
                <SelectedItemStyle CssClass="ODSelected" />
                <HeaderStyle CssClass="ODHeader" />
                <FooterStyle CssClass="ODFooter" />
                <ItemStyle Height="40px" />
                <Columns>
                    <asp:BoundColumn DataField="IID" ReadOnly="True" Visible="false">
                        <HeaderStyle Width="0px" />
                    </asp:BoundColumn>
                    
                    <asp:TemplateColumn HeaderText="Qty">
                        <HeaderStyle Width="20" />
                        <ItemStyle HorizontalAlign="Center" />
                        <ItemTemplate>
                            <asp:LinkButton ID="Linkbutton1" runat="server" CssClass="DisplayButton" Text='<%# DataBinder.Eval(Container.DataItem,"Quantity") %>'
                                Width="100%" Height="100%">
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Your Order">
                        <ItemStyle HorizontalAlign="left" Width="150" />
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemTemplate>
                            <asp:LinkButton ID="buttonlabel" runat="server" CssClass="DisplayButton" Text='<%# DataBinder.Eval(Container.DataItem,"OrderItemText") %>'
                                Width="100%" Height="100%">
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateColumn>
                    
                    <asp:BoundColumn DataField="CalculatedValue" HeaderText="Totals" DataFormatString="{0:c2}">
                        <HeaderStyle HorizontalAlign="Right" Width="65px" />
                        <ItemStyle HorizontalAlign="Right" Wrap="False" CssClass="DisplayButton" />
                    </asp:BoundColumn>
                    


                </Columns>

                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" Mode="NumericPages" />
            </asp:DataGrid>
            <asp:Label ID="Label1" runat="server" CssClass="OrderPadStoreHeader" Text="Order Total  : "></asp:Label>
            <asp:Label ID="lblOrderTotal" runat="server" CssClass="OrderPadStoreHeader" Text="0.00"></asp:Label>
            <br />
            <asp:Button ID="btnPlus" runat="server" CssClass="OrderPadStoreHeader"
                Height="40px" OnClick="btnPlus1_Click" Text="+ 1"
                Width="98px" />

            <asp:Button ID="btnMinus" runat="server" CssClass="OrderPadStoreHeader"
                Height="40px" OnClick="btnMinus1_Click" Text="- 1"
                Width="98px" />

            <asp:Button ID="btnDelete" runat="server" CssClass="OrderPadStoreHeader"
                Height="40px" OnClick="btnDeleteItem_Click" Text="X"
                Width="98px" />

            <br />
            <table  class="auto-style1">
                <tr>
                    <td>

            <asp:Button ID="btnCashPayment" runat="server" CssClass="LoginLabel"
                Height="40px" OnClick="btnCashPayment_Click" Text="CASH  PAYMENT"
                Width="142px" />

                    </td>
                    <td>

            <asp:Button ID="btnHold" runat="server" CssClass="LoginLabel"
                Height="40px" OnClick="btnHold_Click" Text="HOLD"
                Width="142px" />

                    </td>
                </tr>
                <tr>
                    <td>

            <asp:Button ID="btnCloseOrder" runat="server" CssClass="LoginLabel"
                Height="40px" OnClick="btnCloseOrder_Click" Text="CLOSE ORDER"
                Width="142px" Visible="False" />

                    </td>
                    <td>

            <asp:Button ID="btnCancel" runat="server" CssClass="LoginLabel"
                Height="40px" OnClick="btnCancel_Click" Text="CANCEL"
                Width="142px" Visible="False" />

                    </td>
                </tr>
            </table>
            <asp:Label ID="lblStore" runat="server" CssClass="OrderPadStoreHeader"></asp:Label>

            <br />
            <br />
            <asp:Button ID="btnLogout" runat="server" CssClass="LoginLabel" Height="40px" OnClick="btnLogout_Click" Text="LOGOUT" Width="142px" />
            <br />

            <br />

        </div>

    </form>
</body>
</html>
