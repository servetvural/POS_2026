<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HoldOrders.ascx.cs" Inherits="MobilePad.HoldOrders" %>
<asp:DataList ID="dlHoldOrders" runat="server" CellSpacing="10" CellPadding="10"
    RepeatLayout="Flow" RepeatDirection="Horizontal" ItemStyle-VerticalAlign="Top" OnItemCommand="dlHoldOrders_ItemCommand">

    <ItemStyle VerticalAlign="Top" HorizontalAlign="Left"></ItemStyle>

    <ItemTemplate>
        <asp:LinkButton ID="lblHoldOrder" runat="server" Height="30" CssClass="HoldOrder"
            Text='<%# DataBinder.Eval(Container.DataItem,"CalculatedValue","{0:c2}") %>' CommandArgument='<%# DataBinder.Eval(Container.DataItem, "IID") %>'></asp:LinkButton>

    </ItemTemplate>

</asp:DataList>