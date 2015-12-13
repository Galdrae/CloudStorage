<%@ Page Title="" Language="C#" MasterPageFile="~/Site(LoggedIn).Master" AutoEventWireup="true" CodeBehind="Home(LoggedIn).aspx.cs" Inherits="CloudStorage.Home_LoggedIn_" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Cloud Storage</h1>
        <p class="lead">
            <asp:Label ID="lbUserName" runat="server" Text='<%# Session["UserName"].ToString() %>'></asp:Label> Welcome to Cloud Storage!</p>
        <p><a class="btn btn-primary btn-large" id="btnRegister">Go to my files &raquo;</a></p>
    </div>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <div class="row">
        <div class="col-md-4">
            <h2>One Time Password</h2>
            <p>
                A SMS password authentication service.
            </p>
            <p>
                <a class="btn btn-default" href="">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Face Recognition</h2>
            <p>
                Account or file authentication through face recongition.
            </p>
            <p>
                <a class="btn btn-default" href="">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>File Authentication</h2>
            <p>
                Secure file with  authentication or encryption.
            </p>
            <p>
                <a class="btn btn-default" href="">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
