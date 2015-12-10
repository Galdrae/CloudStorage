<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CloudStorage.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Create a new account.</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="tbUserName" CssClass="col-md-2 control-label">User name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="tbUserName" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="tbUserName"
                    CssClass="text-danger" ErrorMessage="The user name field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="tbPassword" CssClass="col-md-2 control-label">Password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="tbPassword" TextMode="Password" CssClass="form-control" Width="200px" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="tbPassword"
                    CssClass="text-danger" ErrorMessage="The password field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="tbConfirmPw" CssClass="col-md-2 control-label">Confirm password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="tbConfirmPw" TextMode="Password" CssClass="form-control" Width="200px" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="tbConfirmPw"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                <asp:CompareValidator runat="server" ControlToCompare="tbPassword" ControlToValidate="tbConfirmPw"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
            </div>
        </div>
        <p>_</p>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="tbFirstName" CssClass="col-md-2 control-label">First Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="tbFirstName" CssClass="form-control" Width="230px" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="tbFirstName"
                    CssClass="text-danger" ErrorMessage="The first name field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="tbLastName" CssClass="col-md-2 control-label">Last Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="tbLastName" CssClass="form-control" Width="230px" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="tbLastName"
                    CssClass="text-danger" ErrorMessage="The last name field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="tbBirthDate" CssClass="col-md-2 control-label">Date of Birth</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" CssClass="form-control" MaxLength="10" Width="100px" ID="tbBirthDate" /><asp:Label ID="lbDateFormat" runat="server" Text="(DD/MM/YYYY)" Font-Italic="True" Font-Size="Smaller"></asp:Label>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="tbBirthDate"
                    CssClass="text-danger" ErrorMessage="The date of birth field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="tbContactNo" CssClass="col-md-2 control-label">Contact Number</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="tbContactNo" CssClass="form-control" MaxLength="20" Width="130px" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="tbContactNo"
                    CssClass="text-danger" ErrorMessage="The contact number field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="tbEmail" CssClass="col-md-2 control-label">Email</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="tbEmail" CssClass="form-control" MaxLength="100" Width="600px" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="tbEmail"
                    CssClass="text-danger" ErrorMessage="The email addresss field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ddlSecretQuestion" CssClass="col-md-2 control-label">Secret Question</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="ddlSecretQuestion" runat="server" CssClass="form-control" Width="300px">
                    <asp:ListItem Value="1">What the name of your pet?</asp:ListItem>
                    <asp:ListItem Value="2">What&#39;s your mother&#39;s first name</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ddlSecretQuestion"
                    CssClass="text-danger" ErrorMessage="Please select a secret question." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="tbSecretAnswer" CssClass="col-md-2 control-label">Secret Answer</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="tbSecretAnswer" CssClass="form-control" MaxLength="100" Width="600px" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="tbSecretAnswer"
                    CssClass="text-danger" ErrorMessage="The secret answer field is required." />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-default" /> 
                <asp:Button runat="server" Text="Clear" CssClass="btn btn-default" />
            </div>
        </div>
                <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Label ID="lbErrorMessage" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
