<%@ Page Title="" Language="C#" MasterPageFile="~/Pessoas/Pessoas.Master" AutoEventWireup="true" CodeBehind="PessoasConsulta.aspx.cs" Inherits="SGPDS.Pessoas.PessoasConsulta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div><h3>PESSOAS CADASTRADAS</h3></div>
        <div>
    <asp:GridView ID="gvPessoasCadastradas" class="table table-hover" GridLines="None" runat="server" 
                 AutoGenerateColumns="False" 
        DataKeyNames="ID" DataSourceID="SqlDataSource_PessoasConsulta">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" />
            <asp:BoundField DataField="cpf" HeaderText="cpf" SortExpression="cpf" />
            <asp:BoundField DataField="rg" HeaderText="rg" SortExpression="rg" />
            <asp:CommandField SelectText="detalhar" ShowSelectButton="True" />
        </Columns>

    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource_PessoasConsulta" runat="server" ConnectionString="<%$ ConnectionStrings:SGAPS_Local %>" SelectCommand="SELECT ID, nome, cpf, rg FROM USUARIO.SGPDS_USUARIO_CADASTRO"></asp:SqlDataSource>
    </div>
    </div>
</asp:Content>
