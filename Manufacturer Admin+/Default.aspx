<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstManufacturers" runat="server" Height="165px" Width="283px" style="margin-left: 4px"></asp:ListBox>
            <br />
            <br />
&nbsp;<asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblPleaseEnterManufacturerNo" runat="server" Text="Please Enter a Manufacturer No"></asp:Label>
            <br />
            <asp:TextBox ID="txtManufacturerNo" runat="server" Height="21px" Width="186px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" Text="Apply" Width="152px" OnClick="btnApply_Click" />
            <asp:Button ID="btnDisplayAll" runat="server" style="margin-left: 4px" Text="Display All" Width="133px" OnClick="btnDisplayAll_Click" />
            <br />
            <br />
        </div>
        <asp:Button ID="btnAdd" runat="server" style="margin-left: 2px" Text="Add" Width="99px" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" Width="86px" OnClick="btnEdit_Click" style="margin-left: 2px" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="95px" OnClick="btnDelete_Click" style="margin-left: 2px" />
        <br />
    </form>
</body>
</html>
