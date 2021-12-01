<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="WebApplication1.Login" %>
<div class="login">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>
        <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="btnLogin" runat="server" Text="Entrar" OnClick="btnLogin_Click" />
    </div>
        <br />
        <br />
        <br />
        <br />
    <div>
        <asp:Label ID="lblMensagem" runat="server" Text="[Mensagem]"></asp:Label>
        <br />
        <br />
        <br />
    </div>
</div>


