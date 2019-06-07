<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_CICWEBIntegration.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<table border="0" cellpadding="2" cellspacing="0">
    <tr>
        <td>University Code:</td>
        <td><asp:TextBox ID="txtName" runat="server" /></td>
    </tr>
    
    <tr>
        <td></td>
        <td><asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="Submit" /></td>
    </tr>
    <tr>
        <td valign = "top">Output:
        </td>
        <td style = "width:255px;word-break:break-all">
            <asp:Label ID="lblOutput" runat="server" Font-Names="courier new" />
        </td>
    </tr>
</table>
    </form>
</body>
</html>
