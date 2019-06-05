<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Produto.aspx.cs" Inherits="Produto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Cadastro de Produtos</p>
        <p>
            Id:<asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        </p>
        <p>
            Nome:<asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        </p>
        <p>
            Descrição:<asp:TextBox ID="txtDesc" runat="server" Height="87px" Width="171px"></asp:TextBox>
        </p>
        <p>
            Preço de custo:<asp:TextBox ID="txtPC" runat="server" Height="16px" Width="171px"></asp:TextBox>
        </p>
        <p>
            Preço de venda:<asp:TextBox ID="txtPV" runat="server" Height="16px" Width="171px"></asp:TextBox>
        </p>
        <p>
            Quantidade:<asp:TextBox ID="txtQuant" runat="server" Height="16px" Width="171px"></asp:TextBox>
        </p>
        <p>
            Un de Medida:<asp:TextBox ID="txtUn" runat="server" Height="16px" Width="171px"></asp:TextBox>
        </p>
        <p>
            Descrição:<asp:DropDownList ID="ddlCategoriaProduto" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </p>
        <p>
            <asp:GridView ID="GridProd" runat="server">
            </asp:GridView>
        </p>
        <p>
            <asp:Button ID="btnGravar" runat="server" Text="Gravar" OnClick="btnGravar_Click" />
            <asp:Button ID="btnCarregar" runat="server" OnClick="btnCarregar_Click" Text="Carregar" />
            <asp:Button ID="btnExcluir" runat="server" OnClick="btnExcluir_Click" Text="Excluir" />
            <asp:Button ID="btnLimpar" runat="server" OnClick="btnLimpar_Click" Text="Limpar" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
