<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="assignment1.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>

    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="firstNameTextBox" runat="server" CssClass="col-md-6"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="First name is required." ControlToValidate="firstNameTextBox" CssClass="col-md-6" SetFocusOnError="true" 
               Text="<img src='images/error.png' alt='First name is required.' title='Requied.' />" Display="Dynamic" ></asp:RequiredFieldValidator>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="lastNameTextBox" runat="server" CssClass="col-md-6"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Last name is required." ControlToValidate="lastNameTextBox" CssClass="col-md-6" SetFocusOnError="true" 
                Text="<img src='images/error.png' alt='Last name is required.' title='Requied.' />" Display="Dynamic" ></asp:RequiredFieldValidator>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="Label3" runat="server" Text="Division"></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:DropDownList ID="divisionsDropDownList" runat="server" DataSourceID="divisionsSqlDataSource" DataTextField="division_name" DataValueField="division_id" CssClass="col-md-6" ></asp:DropDownList>
            <asp:SqlDataSource runat="server" ID="divisionsSqlDataSource" ConnectionString='<%$ ConnectionStrings:HASCConnectionString1 %>' SelectCommand="SELECT [division_id], [division_name] FROM [divisions]"></asp:SqlDataSource>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="Label4" runat="server" Text="EMAIL"></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="EmailTextBox" runat="server" TextMode="Email" CssClass="col-md-6"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Email is required." ControlToValidate="EmailTextBox" CssClass="col-md-6" SetFocusOnError="true" 
               Text="<img src='images/error.png' alt='Email is required.' title='Requied.' />" Display="Dynamic" ></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailTextBox"
    ForeColor="Red" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
    Display = "Dynamic" ErrorMessage = "Invalid email address"/>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="Label5" runat="server" Text="Birth date"></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="birthDateTextBox" runat="server" TextMode="Date" Columns="8" CssClass="col-md-6"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Birth date is required." ControlToValidate="birthDateTextBox" CssClass="col-md-6" 
               SetFocusOnError="true" 
               Text="<img src='images/error.png' alt='Birth date is required.' title='Requied.' />" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-md-4">
        </div>
        <div class="col-md-6">
            <asp:Button ID="submitButton" runat="server" Text="Submit" />
            <asp:Button ID="cancelButton" runat="server" Text="Cancel" CausesValidation="false" />
        </div>
    </div>
    <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <asp:Literal ID="outputLiteral" runat="server"></asp:Literal>
</asp:Content>
