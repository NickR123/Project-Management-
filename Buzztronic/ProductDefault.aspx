<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDefault.aspx.cs" Inherits="Buzztronic.ProductDefault" %>

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
        <asp:ListBox ID="lstProduct" runat="server" style="z-index: 1; left: 460px; top: 146px; position: absolute; height: 174px; width: 341px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 464px; top: 333px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:TextBox ID="txtProductName" runat="server" style="z-index: 1; left: 461px; top: 399px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblProductName" runat="server" style="z-index: 1; left: 463px; top: 365px; position: absolute; width: 167px;" Text="Please enter Product Name"></asp:Label>
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; top: 427px; position: absolute; left: 560px; height: 27px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 464px; top: 467px; position: absolute; width: 55px; height: 23px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 676px; top: 466px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="BtnProductReturn" runat="server" OnClick="BtnProductReturn_Click" style="z-index: 1; left: 9px; top: 17px; position: absolute; width: 129px; height: 47px" Text="Return" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p style="height: 51px">
            <asp:Button ID="btnApply" runat="server" style="z-index: 1; top: 428px; position: absolute; left: 463px; height: 27px" OnClick="btnApply_Click" Text="Apply"  />
        </p>
        <p>
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 580px; top: 465px; position: absolute" OnClick="btnEdit_Click" Text="Edit" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
