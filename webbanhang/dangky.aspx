<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dangky.aspx.cs" Inherits="webbanhangnhom8.dangky" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>
            Trang Đăng Kí
        </h1>
        <table>
            <tr>
                <td>
                    Tài Khoản:
                </td>
                <td>
                    <asp:TextBox ID="txttk" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Mật Khẩu:
                </td>
                <td>
                    <asp:TextBox ID="txtmk" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                   Nhập lại mật khẩu
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Họ Tên:
                </td>
                <td>
                    <asp:TextBox ID="txthoten" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Giới Tính:
                </td>
                <td>
                    <asp:DropDownList ID="txtgt" runat="server">
                        <asp:ListItem>Nam</asp:ListItem>
                        <asp:ListItem>Nữ</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Quyền:
                </td>
                <td>
                    <asp:DropDownList ID="txtquyen" runat="server">                      
                        <asp:ListItem>user</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Đăng kí" OnClick="Button1_Click" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Đăng Nhập" OnClick="Button2_Click" />
                </td>
                 
            </tr>
            
        </table>
       
        <asp:Label ID="Label1" runat="server"></asp:Label>
       
    </form>
</body>
</html>
