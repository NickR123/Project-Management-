<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnStaff.aspx.cs" Inherits="Buzztronic.AnStaff" %>

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
        <asp:Label ID="LblStaffNo" runat="server" style="z-index: 1; left: 418px; top: 166px; position: absolute" Text="Staff No"></asp:Label>
        <asp:Label ID="LblFirstName" runat="server" style="z-index: 1; left: 417px; top: 204px; position: absolute" Text="First Name"></asp:Label>
        <asp:Label ID="LblLastName" runat="server" style="z-index: 1; left: 416px; top: 239px; position: absolute" Text="Last Name"></asp:Label>
        <asp:Label ID="LblStaffAddress" runat="server" style="z-index: 1; left: 414px; top: 270px; position: absolute" Text="Staff Address"></asp:Label>
        <asp:Label ID="LblStaffPhoneNo" runat="server" style="z-index: 1; left: 404px; top: 305px; position: absolute; right: 770px" Text="Staff Phone No"></asp:Label>
        <asp:Label ID="lblStaffPostCode" runat="server" style="z-index: 1; left: 414px; top: 338px; position: absolute" Text="Staff PostCode"></asp:Label>
        <asp:TextBox ID="TxtStaffNo" runat="server" style="z-index: 1; left: 482px; top: 164px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TxtFirstName" runat="server" style="z-index: 1; left: 492px; top: 203px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TxtLastName" runat="server" style="z-index: 1; left: 489px; top: 239px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TxtStaffAddress" runat="server" style="z-index: 1; left: 501px; top: 269px; position: absolute; width: 251px"></asp:TextBox>
        <asp:TextBox ID="TxtStaffPhoneNo" runat="server" style="z-index: 1; left: 513px; top: 302px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TxtStaffPostCode" runat="server" style="z-index: 1; left: 513px; top: 337px; position: absolute"></asp:TextBox>
        <asp:Label ID="LblError" runat="server" style="z-index: 1; left: 416px; top: 378px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="BtnOkay" runat="server" style="z-index: 1; left: 412px; top: 412px; position: absolute" Text="Okay" />
        <asp:Button ID="BtnCancel" runat="server" style="z-index: 1; left: 470px; top: 412px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
