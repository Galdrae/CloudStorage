<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CloudStorage._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Cloud Storage</h1>
        <p class="lead">Welcome to Cloud Storage! A Safe and Secure file storage service for you!</p>
        <p><a href="" class="btn btn-primary btn-large">Register &raquo;</a></p>
    </div>

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
