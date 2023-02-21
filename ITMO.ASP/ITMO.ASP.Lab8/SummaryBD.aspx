<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SummaryBD.aspx.cs" Inherits="ITMO.ASP2023.Task01.SummaryBD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Список участников<asp:GridView ID="GridView1" runat="server" DataSourceID="LinqDataSource1">
    </asp:GridView>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="ITMO.ASP2023.Task01.SampleContext" TableName="GuestResponses">
    </asp:LinqDataSource>
</h2>
</asp:Content>
