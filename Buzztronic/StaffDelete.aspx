<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffDelete.aspx.cs" Inherits="Buzztronic.StaffDelete" %>

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
        <asp:Label ID="LblStaffNo" runat="server" style="z-index: 1; left: 495px; top: 180px; position: absolute" Text="Are you sure you want to remove this staff member?"></asp:Label>
        <asp:Button ID="BtnNo" runat="server" style="z-index: 1; top: 215px; position: absolute; width: 76px; left: 653px; height: 23px; bottom: 426px" Text="No" />
        <asp:Button ID="BtnYes" runat="server" style="z-index: 1; left: 557px; top: 215px; position: absolute; width: 76px; height: 23px; margin-top: 0px" Text="Yes" OnClick="BtnYes_Click" />
    </form>
</body>
</html>
