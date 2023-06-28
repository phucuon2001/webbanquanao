<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="webbanhangnhom8.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title>  
</head>
<body>
    <style>


body {
  background-image: url('anh/trash.jpg');
  background-repeat: no-repeat;
  color:red;
  background-size: cover;
}
  </style>

    <form id="form1" runat="server">
        
        <table style="margin: 0 auto; width: 50%;">
       
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Tài Khoản"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txttdn" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Mật Khẩu"></asp:Label>
            </td>
             <td>
                 <asp:TextBox ID="txtmk" runat="server"></asp:TextBox>
            </td>
        </tr>
            <tr>
                <td>
                  
                </td>
                <td>
                      <asp:Button ID="Button1" runat="server" Text="Đăng Nhập" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="Đăng Kí" OnClick="Button2_Click" />
                </td>
            </tr>
            <tr>
                <td>
                   
                </td>
                 <td>
                      <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
            </tr>
            </table>

         </form>
</body>
</html>
