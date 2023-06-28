<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chitietsanpham.aspx.cs" Inherits="webbanhangnhom8.chitietsanpham" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    body {
        color: #333;
    }
    
    label {
        color: #555;
    }
    
    input[type="text"], textarea {
        color: #888;
    }
    
    button {
        color: #fff;
        background-color: #337ab7;
        border-color: #2e6da4;
        padding: 6px 12px;
        margin-top: 10px;
    }
</style>
</head>
<body>
    <style>
		body {
			font-family: Arial, sans-serif;
			background-color: #f0f0f0;
			margin: 0;
			padding: 0;
		}
		
		table {
			margin: 20px auto;
			border-collapse: collapse;
			box-shadow: 0 0 20px rgba(0, 0, 0, 0.1);
			background-color: #fff;
		}
		
		td {
			padding: 10px;
			vertical-align: top;
		}
		
		td.auto-style1 {
			width: 350px;
		}
		
		#Image1 {
			display: block;
			margin: 0 auto;
			box-shadow: 0 0 10px rgba(0, 0, 0, 0.3);
		}
		
		label {
			display: block;
			font-weight: bold;
			margin-bottom: 5px;
		}
		
		input[type=text] {
			width: 100%;
			padding: 8px;
			border: 1px solid #ccc;
			border-radius: 4px;
			box-sizing: border-box;
			margin-bottom: 10px;
		}
		
		button {
			background-color: #4CAF50;
			color: white;
			padding: 10px 20px;
			border: none;
			border-radius: 4px;
			cursor: pointer;
			float: right;
		}
		
		button:hover {
			background-color: #45a049;
		}
	</style>
    <form id="form1" runat="server">
        <table>
        <tr>
            <td>
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/anh/" + Eval("hinhanh")  %>' Height="400px" Width="300px" />
            </td>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Mã Hàng:"></asp:Label>
                <asp:Label ID="txtmahang" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Tên Hàng:"></asp:Label>
            <asp:Label ID="txttenhang" runat="server" Text=""></asp:Label>
            <br />
                <asp:Label ID="Label3" runat="server" Text="Số Lượng:"></asp:Label>
                <asp:TextBox ID="txtsoluong" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label5" runat="server" Text="Chi Tiết:"></asp:Label>
            <asp:Label ID="txtchitiet" runat="server" Text=""></asp:Label>
            <br />
                <asp:Label ID="Label4" runat="server" Text="Đơn Giá:"></asp:Label>
            <asp:Label ID="txtdongia" runat="server" Text=""></asp:Label>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Thêm vào giỏi hàng" OnClick="Button1_Click" />
             
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
