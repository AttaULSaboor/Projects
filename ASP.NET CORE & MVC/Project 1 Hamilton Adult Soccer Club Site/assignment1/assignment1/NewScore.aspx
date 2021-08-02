<%@ Page Title="Enter a New Score" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewScore.aspx.cs" Inherits="assignment1.NewScore" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2><%: Title %></h2>
    <p> referee: <asp:DropDownList
            ID="refereeDropDownList"
            runat="server"
            DataSourceID="refereeSqlDataSource"
            DataTextField="lname"
            DataValueField="referee_id"
            AutoPostBack="True">
                 </asp:DropDownList>
        <asp:SqlDataSource
            runat="server"
            ID="refereeSqlDataSource"
            ConnectionString='<%$ ConnectionStrings:HASCConnectionString1 %>'
            SelectCommand="SELECT [referee_id], [first_name] + ' ' + [last_name] AS lname FROM [referees]">
        </asp:SqlDataSource>
    </p>
    <asp:GridView
        ID="newscoreGridView"
        runat="server"
        AutoGenerateColumns="False"
        DataKeyNames="game_id"
        DataSourceID="newscoreSqlDataSource"
        EmptyDataText="There are no data records to display." AllowPaging="True" AllowSorting="True" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" CssClass="table-condensed" ForeColor="Black">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="game_id" HeaderText="ID" ReadOnly="True" SortExpression="game_id" />
            <asp:BoundField DataField="game_date" HeaderText="Date" SortExpression="game_date" DataFormatString="{0:d}" />
            <asp:BoundField DataField="field" HeaderText="Field" SortExpression="field" />
            <asp:BoundField DataField="home_team_id" HeaderText="Home Team ID" SortExpression="home_team_id" >
            <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>
            <asp:BoundField DataField="home_team_score" HeaderText="Score" SortExpression="home_team_score" />
            <asp:BoundField DataField="away_team_id" HeaderText="Away Team ID" SortExpression="away_team_id" >
            <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>
            <asp:BoundField DataField="away_team_score" HeaderText="Score" SortExpression="away_team_score" />
            <asp:BoundField DataField="game_notes" HeaderText="Game Notes" SortExpression="game_notes" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
    <asp:SqlDataSource
        ID="newscoreSqlDataSource"
        runat="server"
        ConnectionString="<%$ ConnectionStrings:HASCConnectionString1 %>"
        DeleteCommand="DELETE FROM [games] WHERE [game_id] = @game_id"
        InsertCommand="INSERT INTO [games] ([game_id], [game_date], [field], [home_team_id], [home_team_score], [away_team_id], [away_team_score], [referee_id], [game_notes]) VALUES (@game_id, @game_date, @field, @home_team_id, @home_team_score, @away_team_id, @away_team_score, @referee_id, @game_notes)"
        SelectCommand="SELECT [game_id], [game_date], [field], [home_team_id], [home_team_score], [away_team_id], [away_team_score], [referee_id], [game_notes] FROM [games] WHERE ([referee_id] = @referee_id)"
        UpdateCommand="UPDATE [games] SET [game_date] = @game_date, [field] = @field, [home_team_id] = @home_team_id, [home_team_score] = @home_team_score, [away_team_id] = @away_team_id, [away_team_score] = @away_team_score, [referee_id] = @referee_id, [game_notes] = @game_notes WHERE [game_id] = @game_id">
        <DeleteParameters>
            <asp:Parameter Name="game_id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="game_id" Type="Int32" />
            <asp:Parameter DbType="Date" Name="game_date" />
            <asp:Parameter Name="field" Type="String" />
            <asp:Parameter Name="home_team_id" Type="Int32" />
            <asp:Parameter Name="home_team_score" Type="Int32" />
            <asp:Parameter Name="away_team_id" Type="Int32" />
            <asp:Parameter Name="away_team_score" Type="Int32" />
            <asp:Parameter Name="referee_id" Type="Int32" />
            <asp:Parameter Name="game_notes" Type="String" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="refereeDropDownList" PropertyName="SelectedValue" Name="referee_id" Type="Int32"></asp:ControlParameter>
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter DbType="Date" Name="game_date" />
            <asp:Parameter Name="field" Type="String" />
            <asp:Parameter Name="home_team_id" Type="Int32" />
            <asp:Parameter Name="home_team_score" Type="Int32" />
            <asp:Parameter Name="away_team_id" Type="Int32" />
            <asp:Parameter Name="away_team_score" Type="Int32" />
            <asp:Parameter Name="referee_id" Type="Int32" />
            <asp:Parameter Name="game_notes" Type="String" />
            <asp:Parameter Name="game_id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>

</asp:Content>
