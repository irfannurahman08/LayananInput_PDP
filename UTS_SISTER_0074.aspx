<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UTS_SISTER_0074.aspx.cs" Inherits="UTS_SISTER_0074" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Input PDP Positif   &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;: 
        <asp:TextBox ID="txtPDPPositif" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnPDPPositif" runat="server" Text="Input" OnClick="btnPDPPositif_Click" />
        <br />
            <br />
        Input PDP Sembuh&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: 
        <asp:TextBox ID="txtPDPnegatif" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnPDPnegatif" runat="server" Text="Input" OnClick="btnPDPnegatif_Click" />
        <br />
        <br />
        Input PDP Meninggal : <asp:TextBox ID="txtPDPmeninggal" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnPDPmeninggal" runat="server" Text="Input" OnClick="btnPDPmeninggal_Click" />
            <br />
            <br />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="pesan" runat="server" Text="-----"></asp:Label>
        <br />

        <br />

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="Id">
        <Columns>
             <asp:BoundField DataField="id" HeaderText="id" ItemStyle-Width="100px" />
            <asp:TemplateField HeaderText="PDP Positif" ItemStyle-Width="150px">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PDP Sembuh " ItemStyle-Width="150px">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PDP Meninggal" ItemStyle-Width="150px">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        <br />
        <asp:Label ID="total_pdp" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
