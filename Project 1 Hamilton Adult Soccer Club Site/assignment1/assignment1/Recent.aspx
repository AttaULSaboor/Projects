<%@ Page Title="Recent Scores" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Recent.aspx.cs" Inherits="assignment1.Recent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2><%: Title %></h2>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" CssClass="table-condensed" DataSourceID="recentSqlDataSource" ForeColor="Black">
        <Columns>
            <asp:BoundField DataField="game_date" DataFormatString="{0:d}" HeaderText="Date" SortExpression="game_date"></asp:BoundField>
            <asp:BoundField DataField="team_name" HeaderText="Home" SortExpression="team_name" />
            <asp:BoundField DataField="home_team_score" HeaderText="Score" SortExpression="home_team_score">
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="team_name1" HeaderText="Away" SortExpression="team_name1" />
            <asp:BoundField DataField="away_team_score" HeaderText="Score" SortExpression="away_team_score">
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="Gray" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
     </asp:GridView>
     <asp:SqlDataSource ID="recentSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:HASCConnectionString1 %>" SelectCommand="select [game_date], [home_team_score], [away_team_score], t.team_name, t1.team_name
from games g INNER join teams t on  g.[home_team_id] = t.team_id 
Inner Join teams t1 on g.away_team_id = t1.team_id
where [away_team_score] IS NOT NULL and [home_team_score] IS NOT NULL 
ORDER BY [game_date] desc"></asp:SqlDataSource>
</asp:Content>
