<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrainerDashboard.aspx.cs" Inherits="ADO.NETWebApp.TrainerDashboard" MasterPageFile="~/MyLayout.Master" %>

<asp:Content ID="pageContent" runat="server" ContentPlaceHolderID="MainContent">

</asp:Content>










<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
     
        <nav class="navbar navbar-expand-sm bg-light">
            <div class="container-fluid">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl=" ~/Home.aspx" CssClass="nav-link"> Home </asp:HyperLink>
                      </li>
                    <li class="nav-item">
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl=" ~/TrainerDashboard.aspx" CssClass="nav-link"> Trainers </asp:HyperLink>
                    </li>
                </ul>
            </div>
        </nav>

    <form id="form1" runat="server">
        <div>
            <h2>All Trainers</h2>
            <asp:GridView ID="gvTrainers" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView> <%--isase data hume tebular formate me dikhenga--%>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
    </form> 
    <script src="Scripts/bootstrap.bundle.min.js"></script>

</body>
</html>
