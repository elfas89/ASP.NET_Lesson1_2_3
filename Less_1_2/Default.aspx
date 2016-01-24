<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Less_1_2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:Label ID="Label1" runat="server" Text="Label"><p>test text</p></asp:Label>


    </div>

        <%--<asp:Label ID="LabelInfo" runat="server" EnableViewState="true"></asp:Label>--%>


                <br></br>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br></br>
        <asp:Button ID="Button" runat="server" Text="Кнопка!" OnClick="Button_Click" />

    </form>
</body>
</html>
