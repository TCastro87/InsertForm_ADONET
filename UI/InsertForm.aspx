<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertForm.aspx.cs" Inherits="UI.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div align ="center">
        
            <tr>
                <td>
                    <asp:Label ID="LblNome" runat="server" Text="Nome:" ForeColor="#000099"></asp:Label>
                    <asp:TextBox ID="TBoxNome" runat="server" MaxLength="100"></asp:TextBox>
                </td>                    
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LblEnd" runat="server" Text="Email:" ForeColor="#000099"></asp:Label>
                    <asp:TextBox ID="TboxEnd" runat="server" MaxLength="50"></asp:TextBox>
                </td>                    
            </tr>
                    
            
       <br /><br /><br />
        <asp:Button ID="Cadastrar" runat="server" Text="Incluir" OnClick="BotaoInCluir" />

        <br /><br /><br />
        <asp:Label ID="LblResult" runat="server" Text="Label" Visible="False" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
              
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:String_Sql %>" SelectCommand="SELECT [Nome], [Email] FROM [Users]"></asp:SqlDataSource>
    </div>

</asp:Content>
