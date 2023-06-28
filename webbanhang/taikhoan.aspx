<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="taikhoan.aspx.cs" Inherits="webbanhangnhom8.taikhoan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <style>
        h1 {
            text-align: center;
        }
        table {
            border-collapse: collapse;
            width: 100%;
        }
        th, td {
            text-align: left;
            padding: 8px;
        }
        th {
            background-color: #4CAF50;
            color: white;
        }
        tr:nth-child(even) {
            background-color: #f2f2f2;
        }
        form {
            max-width: 600px;
            margin: auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }
        input[type=text], select {
            width: 100%;
            padding: 12px 20px;
            margin: 8px 0;
            display: inline-block;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }
        input[type=submit], input[type=button] {
            background-color: #4CAF50;
            color: white;
            padding: 12px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            float: right;
        }
        input[type=submit]:hover, input[type=button]:hover {
            background-color: #45a049;
        }
    </style>
    <form id="form1" runat="server">
        <div>
            <h1>Danh Sách Tài Khoản</h1>
        </div>
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
                        <asp:ListItem>admin</asp:ListItem>
                        <asp:ListItem>user</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Thêm" runat="server" Text="Thêm" OnClick="Thêm_Click" />
                </td>
                <td>
                    <asp:Button ID="Thoát" runat="server" Text="Thoát" OnClick="Thoát_Click" />
                </td>
               
            </tr>
        </table>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <asp:GridView ID="dgv" runat="server" AutoGenerateColumns="False" Height="264px" Width="869px" OnRowCancelingEdit="dgv_RowCancelingEdit" OnRowDataBound="dgv_RowDataBound" OnRowDeleting="dgv_RowDeleting" OnRowEditing="dgv_RowEditing" OnRowUpdating="dgv_RowUpdating">
            <Columns>
                <asp:TemplateField HeaderText="Tài Khoản">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval ("taikhoan") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="matkhau" HeaderText="Mật Khẩu" />
                <asp:BoundField DataField="fullname" HeaderText="Họ Tên" />
                <asp:BoundField DataField="gioitinh" HeaderText="Giới Tính" />
                <asp:BoundField DataField="quyen" HeaderText="Quyền" />
                <asp:CommandField CancelText="Thoát" DeleteText="Xóa" EditText="Sửa" ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
