<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnProduct.aspx.cs" Inherits="Buzztronic.AnProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheetBuzzTronic.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblProductNo" runat="server" style="z-index: 1; left: 418px; top: 166px; position: absolute" Text="Product No"></asp:Label>
        <asp:Label ID="lblProductName" runat="server" style="z-index: 1; left: 417px; top: 204px; position: absolute" Text="Product Name"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 416px; top: 239px; position: absolute" Text="Description"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 414px; top: 270px; position: absolute" Text="Price"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 410px; top: 320px; position: absolute" Text="Active" />
        <asp:TextBox ID="txtProductNo" runat="server" style="z-index: 1; left: 513px; top: 166px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtProductName" runat="server" style="z-index: 1; left: 514px; top: 206px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 512px; top: 234px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 513px; top: 270px; position: absolute; width: 251px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 416px; top: 378px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOkay" runat="server" style="z-index: 1; left: 412px; top: 412px; position: absolute" Text="Okay" OnClick="btnOkay_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 470px; top: 412px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>