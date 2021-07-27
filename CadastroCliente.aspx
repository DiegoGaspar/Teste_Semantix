<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCliente.aspx.cs" Inherits="Teste_Semantix.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>Cadastro de Clientes </h2>
    <h2>&nbsp;</h2>
    <p>Nome&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>Telefone&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>Cep
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="Pesquisar" />
    </p>
    <p>Endereço <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>Bairro
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    <p>Cidade
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Salvar" />
        
        <asp:Button runat="server" href="Default.aspx" title="Cancelar" Text="Cancelar" OnClick="Unnamed1_Click"/>
       
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="listaCliente" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="listaCliente" runat="server" ConnectionString="<%$ ConnectionStrings:TesteSemantixConnectionString2 %>" SelectCommand="SELECT [Id], [Nome] FROM [Cliente]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [Cliente] WHERE [Id] = @original_Id AND [Nome] = @original_Nome" InsertCommand="INSERT INTO [Cliente] ([Nome]) VALUES (@Nome)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [Cliente] SET [Nome] = @Nome WHERE [Id] = @original_Id AND [Nome] = @original_Nome">
            <DeleteParameters>
                <asp:Parameter Name="original_Id" Type="Int32" />
                <asp:Parameter Name="original_Nome" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Nome" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nome" Type="String" />
                <asp:Parameter Name="original_Id" Type="Int32" />
                <asp:Parameter Name="original_Nome" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
       
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
