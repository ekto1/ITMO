<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="ITMO.ASP2023.FinalTask.AddStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <div>
        <h1>Student's Data</h1>
        <p></p>
    </div>
    <div>
        <label>First Name:</label>
        <asp:TextBox ID="firstname" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
            ControlToValidate="firstname"
            ErrorMessage="Fill the first name"
            ForeColor="Black">You have to fill this field
        </asp:RequiredFieldValidator>
    </div>
    <div>
        <label>Last Name:</label>
        <asp:TextBox ID="lastname" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
            ControlToValidate="lastname"
            ErrorMessage="Fill the last name"
            ForeColor="Black">You have to fill this field
        </asp:RequiredFieldValidator>
    </div>
    <div>
        <label>Score:</label>&nbsp;
        <asp:DropDownList ID="studentScore" runat="server">
            <asp:ListItem Value="0">0</asp:ListItem>
            <asp:ListItem Value="1">1</asp:ListItem>
            <asp:ListItem Value="2">2</asp:ListItem>
            <asp:ListItem Value="3">3</asp:ListItem>
            <asp:ListItem Value="4">4</asp:ListItem>
            <asp:ListItem Value="5">5</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div>
        <button type="submit">Send</button>
    </div>
</asp:Content>