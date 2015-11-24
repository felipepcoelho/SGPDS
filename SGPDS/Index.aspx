<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SGPDS.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Le styles -->
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <style type="text/css">
        body {
            padding-top: 40px;
            padding-bottom: 40px;
            background-color: #f5f5f5;
        }

        .form-signin {
            max-width: 300px;
            padding: 19px 29px 29px;
            margin: 0 auto 20px;
            background-color: #fff;
            border: 1px solid #e5e5e5;
            -webkit-border-radius: 5px;
            -moz-border-radius: 5px;
            border-radius: 5px;
            -webkit-box-shadow: 0 1px 2px rgba(0,0,0,.05);
            -moz-box-shadow: 0 1px 2px rgba(0,0,0,.05);
            box-shadow: 0 1px 2px rgba(0,0,0,.05);
        }

            .form-signin .form-signin-heading {
                text-align: center;
            }

            .form-signin .checkbox {
                margin-bottom: 10px;
            }

            .form-signin input[type="text"],
            .form-signin input[type="password"] {
                font-size: 16px;
                height: auto;
                margin-bottom: 15px;
                padding: 7px 9px;
            }
    </style>


    <!-- HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
      <script src="../assets/js/html5shiv.js"></script>
    <![endif]-->

    <!-- Fav and touch icons -->
    <link rel="apple-touch-icon-precomposed" sizes="144x144" href="Content/ico/apple-touch-icon-144-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" sizes="114x114" href="Content/ico/apple-touch-icon-114-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" sizes="72x72" href="Content/ico/apple-touch-icon-72-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" href="Content/ico/apple-touch-icon-57-precomposed.png" />
    <link rel="shortcut icon" href="../assets/ico/favicon.png" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="form-signin">
                <h2 class="form-signin-heading">SGPDS</h2>
                <p style="text-align: center">Sistema de Gerenciamento de Projetos de Desenvolvimento de Software</p>
                <asp:TextBox ID="tbLogin" class="input-block-level" runat="server" placeholder="Login"></asp:TextBox>
                <asp:TextBox ID="tbSenha" class="input-block-level" runat="server" placeholder="Senha" TextMode="Password"></asp:TextBox>
                <label class="checkbox">
                    Lembrar-me
            <asp:CheckBox ID="cbLembrarMe" runat="server" />
                </label>
                <asp:Button ID="bLogar" class="btn btn-large btn-primary" runat="server" Text="ENTRAR" OnClick="bLogar_Click" />
                <p></p>
                <asp:Panel ID="pAlertErro" runat="server" Visible="false">
                    <div class="alert alert-error">
                        <asp:Button ID="bAlertErroClose" runat="server" class="close" Text="x" OnClick="bAlertErroClose_Click" />
                        <strong>ATENÇÃO:</strong> Os dados fornecidos estão incorretos...
                    </div>
                </asp:Panel>

                </div>
        </div>
        <!-- /container -->
        <!-- Le javascript
    ================================================== -->
        <!-- Placed at the end of the document so the pages load faster -->
        <script src="Scripts/bootstrap-alert.js"></script>

    </form>
</body>
</html>
