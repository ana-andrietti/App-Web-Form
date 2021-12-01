<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="WebApplication1.Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <script>
        var Validacao = function () {
            var nome = document.getElementById("txtNome")
            var telefone = document.getElementById("txtTelefone")
            var endereco = document.getElementById("txtEndereco")

            if (nome.value == "") {
                alert("Preencha o campo Nome");
                nome.focus;
                return false;
            }

            if (telefone.value == "") {
                alert("Preencha o campo Telefone");
                telefone.focus;
                return false;
            }

            if (endereco.value == "") {
                alert("Preencha o campo Endereço");
                endereco.focus;
                return false;
            }
            return true;
        }
    </script>
    <form id="form1" runat="server" onsubmit="return Validacao()">
        <div>
            <asp:Label ID="Label2" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server" Width="218px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Telefone"></asp:Label>
            <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
            <br />
        </div>
        
        <div>
            <asp:Label ID="Label3" runat="server" Text="Endereço"></asp:Label>
            <asp:TextBox ID="txtEndereco" runat="server" Width="270px"></asp:TextBox>
            <br />
        </div>
        
        <div id="validacao" runat ="server">
            
        </div>
        <asp:Button ID="btnValidar" runat="server" OnClick="btnValidar_Click" Text="Validar" />
        
    </form>
</body>
</html>
