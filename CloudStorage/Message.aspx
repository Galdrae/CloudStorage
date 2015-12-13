<%@ Page Title="" Language="C#" MasterPageFile="~/Site(LoggedIn).Master" AutoEventWireup="true" CodeBehind="Message.aspx.cs" Inherits="CloudStorage.Message" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h3>Send a message</h3>
        <br />
        <asp:TextBox runat="server" placeholder="Send to" ID="tbSendTo" CssClass="form-control" ToolTip="Enter recipient's username" />
        <asp:RequiredFieldValidator runat="server" ControlToValidate="tbSendTo"
            CssClass="text-danger" ErrorMessage="Please enter recipient's name." />
        <asp:TextBox runat="server" placeholder="Subject" ID="tbSubject" CssClass="form-control" Width="600px" TextMode="MultiLine" />
        <asp:RequiredFieldValidator runat="server" ControlToValidate="tbSubject"
            CssClass="text-danger" ErrorMessage="Please enter subject title." />
        <asp:TextBox runat="server" placeholder="Enter message" ID="tbMessage" CssClass="form-control" Width="850px" TextMode="MultiLine" Height="150px" />
        <asp:RequiredFieldValidator runat="server" ControlToValidate="tbMessage"
            CssClass="text-danger" ErrorMessage="Please enter message." />
        <br />
        <asp:Button ID="btnSend" runat="server" Text="Send message" class="btn btn-primary btn-large" OnClick="btnSend_Click" />
        <asp:Button ID="btnClear" runat="server" Text="Clear" class="btn btn-primary btn-large" CausesValidation="False" OnClick="btnClear_Click" />
        <br />
        <asp:Label ID="lbMessage" runat="server" Text=""></asp:Label>
    </div>
    <div class="jumbotron">
        <h3>Sent Messages</h3>
        <br />
    <asp:GridView ID="gvOutbox" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="MessageID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="MessageID" HeaderText="No." InsertVisible="False" ReadOnly="True" SortExpression="MessageID" />
            <asp:BoundField DataField="SentTo" HeaderText="Recipient" SortExpression="SentTo" >
            <HeaderStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="SentFrom" HeaderText="From" SortExpression="SentFrom" >
            <HeaderStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="Subject" HeaderText="Subject" SortExpression="Subject" />
            <asp:BoundField DataField="Message" HeaderText="Message" SortExpression="Message" Visible="False" />
            <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" >
            <HeaderStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" >
            <HeaderStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="encryption" HeaderText="encryption" SortExpression="encryption" Visible="False" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Message] WHERE ([SentFrom] = @SentFrom)">
        <SelectParameters>
            <asp:SessionParameter DefaultValue="UserName" Name="SentFrom" SessionField="UserName" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
        </div>
</asp:Content>
