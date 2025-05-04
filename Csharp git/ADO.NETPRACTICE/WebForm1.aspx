<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ADO.NETPRACTICE.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 302px; top: 335px; position: absolute" Text="Update" OnClick="Button2_Click"/>
            <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 272px; top: 281px; position: absolute" ></asp:TextBox>
            <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox6_TextChanged" style="z-index: 1; left: 26px; top: 282px; position: absolute"></asp:TextBox>
        </div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 540px; top: 179px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 537px; top: 226px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 537px; top: 276px; position: absolute"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 586px; top: 335px; position: absolute" Text="Insert"  OnClick="Button1_Click"/>
            <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 934px; top: 159px; position: absolute; height: 152px; width: 232px">
            </asp:GridView>
            <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 272px; top: 222px; position: absolute"></asp:TextBox>
        </p>
        <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 72px; top: 341px; position: absolute" Text="Scalar" OnClick="Button3_Click" />
    </form>
</body>
</html>
