<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OpenAuthProviders.ascx.cs" Inherits="CloudStorage.Account.OpenAuthProviders" %>

<div id="socialLoginList">
    <h4>High Security Authentication</h4>
    <hr />
    <asp:ListView runat="server" ID="providerDetails" ItemType="System.String"
        SelectMethod="GetProviderNames" ViewStateMode="Disabled">
        <ItemTemplate>
            <p>
                <button type="submit" class="btn btn-default" name="provider" value="<%#: Item %>"
                    title="Log in using your <%#: Item %> account.">
                    <%#: Item %>
                </button>
            </p>
        </ItemTemplate>
        <EmptyDataTemplate>
            <div>
                <p> Your files are safe with us!</p>
            </div>
        </EmptyDataTemplate>
    </asp:ListView>
</div>
