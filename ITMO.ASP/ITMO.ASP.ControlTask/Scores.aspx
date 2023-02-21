<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Scores.aspx.cs" Inherits="ITMO.ASP2023.FinalTask.Scores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <div><h2>Scores Sum: <asp:Label ID="Label1" runat="server"></asp:Label></h2></div>
    <asp:SqlDataSource
        ID="SqlDataSource2" 
        runat="server" 
            connectionString="data source=(localdb)\MSSQLLocalDB;Integrated Security=True;AttachDBFilename=|DataDirectory|\Students.mdf" providerName="System.Data.SqlClient"
            SelectCommand="
            SELECT SUM(Score)
            From [dbo].[Students]">
    </asp:SqlDataSource>

    <div><h2>Scores Table</h2></div>
    <p></p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="FirstName" HeaderText="First Name"/>
            <asp:BoundField DataField="LastName" HeaderText="Last Name"/>         
            <asp:BoundField DataField="Score" HeaderText="Score" SortExpression="Score" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource
        ID="SqlDataSource1" 
        runat="server" 
            connectionString="data source=(localdb)\MSSQLLocalDB;Integrated Security=True;AttachDBFilename=|DataDirectory|\Students.mdf" providerName="System.Data.SqlClient"
            SelectCommand="
            SELECT 
            FirstName as [FirstName],  
            LastName as [LastName],
            Score as [Score]
            From [dbo].[Students]">
    </asp:SqlDataSource>
</asp:Content>
