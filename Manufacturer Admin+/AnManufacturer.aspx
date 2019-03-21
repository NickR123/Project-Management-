<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnManufacturer.aspx.cs" Inherits="AnManufacturer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblManufacturerNo" runat="server" Text="ManufacturerNo"></asp:Label>
        :
        <asp:TextBox ID="txtManufacturerNo" runat="server" style="margin-left: 22px" Width="173px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblManufacturerName" runat="server" Text="ManufacturerName:"></asp:Label>
        <asp:TextBox ID="txtManufacturerName" runat="server" style="margin-left: 8px" Width="174px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address:"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="margin-left: 75px" Width="175px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblPostCode" runat="server" Text="PostCode:"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server" style="margin-left: 64px" Width="177px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblTown" runat="server" Text="Town:"></asp:Label>
        <asp:TextBox ID="txtTown" runat="server" style="margin-left: 87px" Width="178px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblTelephoneNo" runat="server" Text="TelephoneNo:"></asp:Label>
        <asp:TextBox ID="txtTelephoneNo" runat="server" style="margin-left: 38px" Width="177px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="margin-left: 86px" Width="175px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblDateAdded" runat="server" Text="DateAdded:"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="margin-left: 48px" Width="181px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkCheck" runat="server" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOk" runat="server" Text="Ok" Width="139px" OnClick="btnOk_Click1" />
        <asp:Button ID="btnCancel" runat="server" style="margin-left: 5px" Text="Cancel" Width="140px" OnClick="btnCancel_Click" />
        <br />
    </form>
</body>
</html>
