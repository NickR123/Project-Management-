<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffDefault.aspx.cs" Inherits="Buzztronic.StaffDefault" %>

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
        <asp:ListBox ID="LstStaff" runat="server" style="z-index: 1; left: 460px; top: 146px; position: absolute; height: 174px; width: 341px"></asp:ListBox>
        <asp:Label ID="LblError" runat="server" style="z-index: 1; left: 464px; top: 333px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 461px; top: 390px; position: absolute"></asp:TextBox>
        <asp:Label ID="LblFirstName" runat="server" style="z-index: 1; left: 463px; top: 365px; position: absolute; width: 167px;" Text="Please enter a First Name"></asp:Label>
        <asp:Button ID="BtnApply" runat="server" style="z-index: 1; left: 464px; top: 427px; position: absolute; width: 91px; height: 27px" Text="Apply" />
        <asp:Button ID="BtnDisplayAll" runat="server" style="z-index: 1; top: 427px; position: absolute; left: 560px; height: 27px" Text="Display All" />
        <asp:Button ID="BtnAdd" runat="server" style="z-index: 1; left: 464px; top: 467px; position: absolute; width: 55px; height: 23px" Text="Add" OnClick="BtnAdd_Click" />
        <asp:Button ID="BtnEdit" runat="server" style="z-index: 1; top: 466px; position: absolute; height: 24px; width: 56px; left: 520px" Text="Edit" />
        <asp:Button ID="BtnDelete" runat="server" style="z-index: 1; left: 580px; top: 465px; position: absolute" Text="Delete" />
    </form>
</body>
</html>
