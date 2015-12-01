<%@ Page Title="" Language="C#" MasterPageFile="~/Pessoas/Pessoas.Master" AutoEventWireup="true" CodeBehind="PessoasCadastro.aspx.cs" Inherits="SGPDS.Pessoas.PessoasCadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:Panel ID="pAlert" runat="server" Visible="false">
            <asp:Button ID="bAlertClose" runat="server" class="close" Text="x" OnClick="bAlertClose_Click" />
            <asp:Label ID="lAlert" runat="server"></asp:Label>
        </asp:Panel>
        <div class="form-inline">
            <div class="control-group">
                <div>
                    <h3>PESSOAL</h3>
                    <p><strong>CADASTRO</strong></p>
                </div>
            </div>
            <div class="space-30"></div>
            <div class="control-group">
                <strong>1 - Dados gerais</strong>
                <hr />
                <dl class="dl-horizontal">
                    <dt>Nome</dt>
                    <dd>
                        <asp:TextBox ID="tbNome" runat="server" class="input-large" MaxLength="200"></asp:TextBox></dd>
                    <dt>Idade</dt>
                    <dd>
                        <asp:TextBox ID="tbIdade" runat="server" class="input-large" MaxLength="3"></asp:TextBox></dd>
                    <dt>Data Nascimento</dt>
                    <dd>
                        <asp:TextBox ID="tbDataNascimento" runat="server" class="input-large" MaxLength="11"></asp:TextBox></dd>
                    <dt>CPF</dt>
                    <dd>
                        <asp:TextBox ID="tbCpf" runat="server" class="input-large" MaxLength="20"></asp:TextBox></dd>
                    <dt>RG</dt>
                    <dd>
                        <asp:TextBox ID="tbRg" runat="server" class="input-large" MaxLength="20"></asp:TextBox></dd>
                </dl>
            </div>
            <div class="control-group">
                <strong>2 - Dados para contato</strong>
                <hr />
                <dl class="dl-horizontal">
                    <dt>Tel. Residencial</dt>
                    <dd>
                        <asp:TextBox ID="tbTelFixo" runat="server" class="input-large" MaxLength="11"></asp:TextBox></dd>
                    <dt>Tel. Celular</dt>
                    <dd>
                        <asp:TextBox ID="tbTelCelular" runat="server" class="input-large" MaxLength="11"></asp:TextBox></dd>
                    <dt>E-mail</dt>
                    <dd>
                        <asp:TextBox ID="tbEmail" runat="server" class="control-label" for="inputEmail" MaxLength="200"></asp:TextBox></dd>
                </dl>

            </div>

            <div class="control-group">
                <strong>2 - Tipo de usuário</strong>
                <hr />
                    <asp:DropDownList ID="ddlUsuarioTipo" CssClass="dropdown" runat="server" DataSourceID="SqlDataSource_UsuarioTipo" DataTextField="descricao" DataValueField="ID"></asp:DropDownList>
                    <asp:SqlDataSource runat="server" ID="SqlDataSource_UsuarioTipo" ConnectionString='<%$ ConnectionStrings:SGAPS_Local %>' SelectCommand="SELECT ID, descricao FROM USUARIO.SGPDS_USUARIO_TIPO ORDER BY descricao"></asp:SqlDataSource>
            </div>
            <div class="control-group">
                <strong>3 - Endereço</strong>
                <hr />
                <div class="form-search">
                         <a class="label label-info">Pesquisar por CEP:</a>
                        <asp:TextBox ID="tbPesquisarEndereco" class="input-medium search-query" runat="server"></asp:TextBox>
                        <asp:Button ID="bPesquisarEndereco" runat="server" class="btn" Text="PESQUISAR" OnClick="bPesquisarEndereco_Click" />
                    </div>
                <asp:Panel ID="pComDados" runat="server" Visible ="false">
                <dl class="dl-horizontal">
                    <dt>ESTADO:</dt>
                    <dd> <asp:Label ID="lEstadoCep" runat="server" ></asp:Label></dd>
                    <dt>CIDADE:</dt>
                    <dd> <asp:Label ID="lCidadeCep" runat="server" ></asp:Label></dd>
                    <dt>BAIRRO</dt>
                    <dd> <asp:Label ID="lBairoCep" runat="server" ></asp:Label></dd>
                    <dt>LOGRADOURO</dt>
                    <dd> <asp:Label ID="lLogradouroCep" runat="server" ></asp:Label></dd>
                </dl>
                    </asp:Panel>
                <asp:Panel ID="pSemDados" runat="server" Visible ="false">
                    <div class="alert">
                           Nenhum endereço relacionado a este CEP!
                        </div>
                </asp:Panel>
            </div>
             <div>
                <asp:Button ID="bCadastrar" runat="server" CssClass="btn btn-success" Text="CADASTRAR" OnClick="bCadastrar_Click" />
            </div>
        </div>
    </div>
</asp:Content>
