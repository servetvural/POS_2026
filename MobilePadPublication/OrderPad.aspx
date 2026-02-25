<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderPad.aspx.cs" Inherits="MobilePad.OrderPad" %>

<%@ Register Src="Header.ascx" TagName="Header" TagPrefix="uc1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Pad</title>
    <link href="main.css" rel="stylesheet" />
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
</head>
<body class="OrderPadBody">
    <form id="form1" runat="server">
        <div>
            <uc1:Header ID="Header1" runat="server" />
            <br />
            <table>
                <tr>
                    <td>
                        <asp:DataList ID="dlHoldOrders" runat="server" CellSpacing="10" CellPadding="10"
                            RepeatLayout="Flow" RepeatDirection="Horizontal" ItemStyle-VerticalAlign="Top" OnItemCommand="dlHoldOrders_ItemCommand">

                            <ItemStyle VerticalAlign="Top"></ItemStyle>

                            <ItemTemplate>

                                <asp:Button ID="lblHoldOrder" runat="server" Height="50" CssClass="HoldOrder"
                                    Text='<%# DataBinder.Eval(Container.DataItem,"CalculatedValue","{0:c2}") %>' CommandArgument='<%# DataBinder.Eval(Container.DataItem, "IID") %>'></asp:Button>

                            </ItemTemplate>

                        </asp:DataList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DataList ID="dlEntityList" runat="server" CellSpacing="10" CellPadding="10" OnItemCommand="dlEntityList_ItemCommand"
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
                        Text='<%# DataBinder.Eval(Container.DataItem,"ButtonText") %>' CommandArgument='<%# DataBinder.Eval(Container.DataItem, "IID") %>'></asp:Button>
                </ItemTemplate>
            </asp:DataList>

            <br />
            <br />
            <asp:DataGrid ID="dgDisplay" runat="server"
                AutoGenerateColumns="False" CellPadding="3"
                CssClass="ODGrid" BorderWidth="0"
                OnItemCommand="dgDisplay_ItemCommand" Width="300px" PageSize="20" GridLines="Horizontal">
                <SelectedItemStyle CssClass="ODSelected" />
                <HeaderStyle CssClass="ODHeader" />
                <FooterStyle CssClass="ODFooter" />
                <ItemStyle Height="40px" />
                <Columns>
                    <asp:BoundColumn DataField="IID" ReadOnly="True" Visible="false">
                        <HeaderStyle Width="0px" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="ParentOrderIID" ReadOnly="True" Visible="false">
                        <HeaderStyle Width="0px" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="EntityIID" HeaderText="EntityIID" ReadOnly="True" Visible="false">
                        <HeaderStyle Width="0px" />
                        <ItemStyle Width="0px" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="TopItem" HeaderText="TopItem" ReadOnly="True" Visible="false">
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
                    <asp:BoundColumn DataField="CalculationRatio" HeaderText="CalculationRatio" ReadOnly="True"
                        Visible="False">
                        <HeaderStyle Width="0px" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="Price" HeaderText="Price" ReadOnly="True" Visible="false">
                        <HeaderStyle Width="0px" />
                        <ItemStyle CssClass="DisplayButton" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="CalculatedValue" HeaderText="Totals">
                        <HeaderStyle HorizontalAlign="Right" Width="65px" />
                        <ItemStyle HorizontalAlign="Right" Wrap="False" CssClass="DisplayButton" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="OrderGroupIID" HeaderText="OrderGroupIID" ReadOnly="True"
                        Visible="False">
                        <HeaderStyle Width="0px" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="SizeBarItemIID" HeaderText="SizeBarItemIID" ReadOnly="True"
                        Visible="false">
                        <HeaderStyle Width="0px" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="DivisionalOrderGroupIID" HeaderText="DivisionalOrderGroupIID"
                        ReadOnly="True" Visible="false">
                        <HeaderStyle Width="0px" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="DivisionText" HeaderText="DivisionText" ReadOnly="True"
                        Visible="false">
                        <HeaderStyle Width="0px" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="EntityButtonIID" HeaderText="EntityButtonIID" ReadOnly="True"
                        Visible="false">
                        <HeaderStyle Width="0px" />
                    </asp:BoundColumn>


                </Columns>

                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" Mode="NumericPages" />
            </asp:DataGrid>
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
            <br />

            <asp:Button ID="btnCashPayment" runat="server" CssClass="LoginLabel"
                Height="40px" OnClick="btnCashPayment_Click" Text="CASH  PAYMENT"
                Width="300px" />

            <br />

            <asp:Button ID="btnHold" runat="server" CssClass="LoginLabel"
                Height="40px" OnClick="btnHold_Click" Text="HOLD"
                Width="300px" />

            <br />
            <asp:Label ID="lblStore" runat="server" CssClass="OrderPadStoreHeader"></asp:Label>

        </div>

    </form>
</body>
</html>
