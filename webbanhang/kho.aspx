<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kho.aspx.cs" Inherits="webbanhangnhom8.kho" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
       body {
    font-family: Arial, sans-serif;
    background-color: #f0f0f0;
}

table {
    border-collapse: collapse;
    width: 100%;
    margin-bottom: 20px;
}

th, td {
    padding: 8px;
    text-align: left;
    border: 1px solid #ddd;
}

th {
    background-color: #f2f2f2;
}

input[type=text], input[type=file] {
    padding: 6px 10px;
    border: 1px solid #ccc;
    border-radius: 4px;
    box-sizing: border-box;
    margin-bottom: 10px;
    width: 100%;
}

button {
    background-color: #4CAF50;
    color: white;
    padding: 8px 16px;
    border: none;
    border-radius: 4px;
    cursor: pointer;
}

button:hover {
    background-color: #45a049;
}

img {
    max-width: 200px;
    max-height: 200px;
    border: 1px solid #ddd;
    padding: 5px;
    background-color: #fff;
}

.auto-style1 {
    height: 29px;
    font-weight: bold;
}
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    Mã Hàng:
                </td>
                <td>
                    <asp:TextBox ID="txtma" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    Tên Hàng:
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtten" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Nhà Cung Cấp:
                </td>
                <td>
                    <asp:TextBox ID="txtncc" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Số Lượng:
                </td>
                <td>
                    <asp:TextBox ID="txtsl" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Đơn Giá Nhập:
                </td>
                <td>
                    <asp:TextBox ID="txtdgnhap" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Đơn Giá Bán:
                </td>
                <td>
                    <asp:TextBox ID="txtdgban" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Chi Tiết:
                </td>
                <td>
                    <asp:TextBox ID="txtchitiet" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Hình Ảnh:
                </td>
                <td>
                    <asp:FileUpload ID="txtha" runat="server" />
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Button ID="Thêm" runat="server" Text="Thêm" OnClick="Thêm_Click" />
                </td>
                <td>
                    <asp:Button ID="Thoát" runat="server" Text="Thoát" OnClick="Thoát_Click" />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
               
            </tr>
        </table>
        <asp:GridView ID="dgv" runat="server" AutoGenerateColumns="False" Height="289px" Width="1058px" OnRowCancelingEdit="dgv_RowCancelingEdit" OnRowDataBound="dgv_RowDataBound" OnRowDeleting="dgv_RowDeleting" OnRowEditing="dgv_RowEditing" OnRowUpdating="dgv_RowUpdating">
            <Columns>
                <asp:TemplateField HeaderText="Mã Hàng">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval ("mahang") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="tenhang" HeaderText="Tên Hàng" />
                <asp:BoundField DataField="ncc" HeaderText="Nhà Cung Cấp" />
                <asp:BoundField DataField="soluong" HeaderText="Số Lượng" />
                <asp:BoundField DataField="dongianhap" HeaderText="Đơn Giá Nhập" />
                <asp:BoundField DataField="dongiaban" HeaderText="Đơn Giá Bán" />
                <asp:BoundField DataField="chitiet" HeaderText="Chi Tiết " />
                <asp:TemplateField HeaderText="Hình Ảnh">
                    <ItemTemplate>
                        <asp:Image ID="imgHinhAnh" runat="server" ImageUrl='<%# "~/anh/" + Eval("hinhanh") %>' Width="200" Height="200"/>
                    </ItemTemplate>
                     <EditItemTemplate>
        <asp:FileUpload ID="fuHinhAnh" runat="server" />
        <asp:HiddenField ID="hfHinhAnh" runat="server" Value='<%# Eval("hinhanh") %>' />
    </EditItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
