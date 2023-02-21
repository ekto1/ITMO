<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Rating.aspx.cs" Inherits="ITMO.ASP2023.FinalTask.Rating" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div><h2>Best Students<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>            
            <asp:BoundField DataField="FirstName" HeaderText="First Name" SortExpression="FirstName" />
            <asp:BoundField DataField="LastName" HeaderText="Last Name" SortExpression="LastName" />
            <asp:BoundField DataField="Score" HeaderText="Score" SortExpression="Score" />
        </Columns>
        </asp:GridView>
        <asp:SqlDataSource 
            ID="SqlDataSource1" 
            runat="server" 
            connectionString="data source=(localdb)\MSSQLLocalDB;Integrated Security=True;AttachDBFilename=|DataDirectory|\Students.mdf" providerName="System.Data.SqlClient"
            SelectCommand="SELECT TOP(5)
            FirstName as [FirstName],  
            LastName as [LastName],
            Score as [Score]
            FROM [dbo].[Students]
            Order by Score Desc">
        </asp:SqlDataSource>
        </h2></div><p></p>
    <div><h2>Worst Students<asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
        <Columns>
            <asp:BoundField DataField="FirstName" HeaderText="First Name" SortExpression="First Name" />
            <asp:BoundField DataField="LastName" HeaderText="Last Name" SortExpression="Last Name" />
             <asp:BoundField DataField="Score" HeaderText="Score" SortExpression="Score" />
        </Columns>
        </asp:GridView>
        <asp:SqlDataSource 
            ID="SqlDataSource2" 
            runat="server" 
            connectionString="data source=(localdb)\MSSQLLocalDB;Integrated Security=True;AttachDBFilename=|DataDirectory|\Students.mdf" providerName="System.Data.SqlClient"
            SelectCommand="
            SELECT TOP(5)
            FirstName as [FirstName],  
            LastName as [LastName],
            Score as [Score]
            From [dbo].[Students]
            Order by Score Asc">
        </asp:SqlDataSource>
        </h2></div>
</asp:Content>
