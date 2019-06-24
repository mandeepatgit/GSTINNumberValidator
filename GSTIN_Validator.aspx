<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GSTIN_Validator.aspx.cs" Inherits="GSTINNumberValidator.GSTIN_Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td >
                        <asp:Label ID="lblGSTINValidator" runat="server" Text="Enter GSTIN Number"></asp:Label>
                    </td>
                    <td >
                        <asp:TextBox ID="txtGSTINValidator" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnValidate" runat="server" Text="Validate" OnClick="btn_Validate_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
