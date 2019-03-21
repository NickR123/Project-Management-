<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="Buzztronic.MainMenu" %>

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
        <p>
            &nbsp;</p>
        <asp:Button ID="BtnStaffMenu" runat="server" OnClick="BtnStaffMenu_Click" style="z-index: 1; left: 750px; top: 266px; position: absolute; height: 51px; width: 216px" Text="Staff Menu" />
        <asp:Button ID="BtnProductMenu" runat="server" OnClick="BtnProductMenu_Click" style="z-index: 1; left: 751px; top: 326px; position: absolute; height: 49px; width: 218px" Text="Product menu" />
        <asp:Button ID="BtnOrderMenu" runat="server" OnClick="BtnOrderMenu_Click" style="z-index: 1; left: 751px; top: 387px; position: absolute; height: 46px; width: 216px" Text="Order Menu" />
        <asp:Button ID="BtnManufacturerMenu" runat="server" OnClick="BtnManufacturerMenu_Click" style="z-index: 1; left: 752px; top: 444px; position: absolute; height: 45px; width: 216px" Text="Manufacturer Menu" />
    </form>
</body>
</html>
