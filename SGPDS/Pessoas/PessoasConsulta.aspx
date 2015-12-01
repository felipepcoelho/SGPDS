<%@ Page Title="" Language="C#" MasterPageFile="~/Pessoas/Pessoas.Master" AutoEventWireup="true" CodeBehind="PessoasConsulta.aspx.cs" Inherits="SGPDS.Pessoas.PessoasConsulta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="right">
            <asp:Button ID="bNovo" runat="server" class="btn btn-primary" Text="NOVO" OnClick="bNovo_Click" />
        </div>
        <div class="form-inline">
            <div class="control-group">
                <div>
                    <h3>PESSOAL</h3>
                    <p><strong>CONSULTA</strong></p>
                </div>
            </div>
            <div class="control-group">
                <div class="space-10"></div>

                <div class="space-10"></div>
                <div>
                    <div class="form-search">
                        <a class="label label-info">Filtrar por:</a>
                        <asp:DropDownList ID="ddlPesquisar" class="dropdown" runat="server">
                            <asp:ListItem>Nome</asp:ListItem>
                            <asp:ListItem>Cpf</asp:ListItem>
                            <asp:ListItem>Rg</asp:ListItem>
                        </asp:DropDownList>
                        <asp:TextBox ID="tbPesquisar" class="input-medium search-query" runat="server"></asp:TextBox>
                        <asp:Button ID="bPesquisar" runat="server" class="btn" Text="PESQUISAR" />
                    </div>
                </div>
                <div class="space-30"></div>
                <div>
                    <asp:Panel ID="pComDados" runat="server" Visible =" false">
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
                    </asp:Panel>
                    <asp:Panel ID="pSemDados" runat="server" Visible =" false">
                        <div class="alert">
                            Não há registros no momento!!
                        </div>
                    </asp:Panel>
                </div>
                <asp:SqlDataSource ID="SqlDataSource_PessoasConsulta" runat="server" ConnectionString="<%$ ConnectionStrings:SGAPS_Local %>" SelectCommand="SELECT ID, nome, cpf, rg FROM USUARIO.SGPDS_USUARIO_CADASTRO"></asp:SqlDataSource>
            </div>
        </div>
    </div>
</asp:Content>
