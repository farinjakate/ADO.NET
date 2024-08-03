<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="StudentDashboard.aspx.cs"
    Inherits="ADONetWebApplication.StudentDashboard" MasterPageFile="~/MyLayout.Master" %>

<asp:Content ID="pageContent" runat="server" ContentPlaceHolderID="MainContentHolder">
    <div>
        <asp:HyperLink ID="LinkCreateStudent" runat="server" NavigateUrl="~/CreateStudent.aspx"> create new student </asp:HyperLink>
    </div>

    <form runat="server">
        <h2> All students</h2>
        <asp:GridView ID="gvStudents" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
 </form>

</asp:Content>