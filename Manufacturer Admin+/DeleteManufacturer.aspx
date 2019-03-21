<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteManufacturer.aspx.cs" Inherits="DeleteManufacturer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDelete" runat="server" Text="Are you sure want to delete this Manufacturer?"></asp:Label>
        <p>
            <asp:Button ID="btnYes" runat="server" Text="Yes" Width="119px" />
            <asp:Button ID="btnNo" runat="server" style="margin-left: 23px" Text="No" Width="136px" OnClick="btnNo_Click" />
        </p>
    </form>
</body>
</html>
