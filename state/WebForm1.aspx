<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="state.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        <div>
            <asp:Label ID="lblCounter" runat="server" Text="Counter: "></asp:Label>
            <asp:Label ID="lblCounterValue" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnIncrement" runat="server" Text="Increment Counter" OnClick="btnIncrement_Click" />
        </div>
    </form>
</body>
</html>
