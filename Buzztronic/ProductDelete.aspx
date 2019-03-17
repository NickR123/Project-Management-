<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDelete.aspx.cs" Inherits="Buzztronic.ProductDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheetBuzzTronic.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblProductNo" runat="server" style="z-index: 1; left: 495px; top: 180px; position: absolute" Text="Are you sure you want to remove this Product?"></asp:Label>
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; top: 215px; position: absolute; width: 76px; left: 653px; height: 23px; bottom: 426px" Text="No" />
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 557px; top: 215px; position: absolute; width: 76px; height: 23px; margin-top: 0px" Text="Yes" OnClick="btnYes_Click" />
    </form>
</body>
</html>
