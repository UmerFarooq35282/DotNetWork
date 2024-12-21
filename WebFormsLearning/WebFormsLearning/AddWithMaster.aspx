<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddWithMaster.aspx.cs" Inherits="WebFormsLearning.AddWithMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>This page added with master page</h1>
    <div class="form-group">
        <asp:Label ID="label1" runat="server" CssClass="form-label">Name </asp:Label>
        <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="NameFieldValidator" runat="server" ErrorMessage="Name field is required" ControlToValidate
            ="txtName" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <asp:Label ID="label2" runat="server" CssClass="form-label">Email </asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="label3" runat="server" CssClass="form-label">Password </asp:Label>
        <asp:TextBox ID="TxtPass" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="label4" runat="server" CssClass="form-label">Message </asp:Label>
        <asp:TextBox ID="txtMessage" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
</asp:Content>
