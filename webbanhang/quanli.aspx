<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="quanli.aspx.cs" Inherits="webbanhangnhom8.admin.quanli" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 837px;
        }
        .auto-style3 {
            margin-top: 0px;
        }
    </style>
</head>
    
<body>
      <link href="css/Stylead.css" rel="stylesheet" type="text/css" />
   
    <form id="form1" runat="server">

<div id="header">
    <h1>
        Wellcome to ADMIN
    </h1>
</div>
        <div id="body">
            <a href="trangchu.aspx">Đăng Xuất</a>
        </div>
<style>
    table {
        margin: 0 auto; /* Căn giữa bảng */
        border-collapse: collapse; /* Gộp các đường viền trong bảng */
        width: 80%; /* Độ rộng bảng là 80% của phần tử cha */
        font-size: 16px; /* Kích thước chữ */
        text-align: center; /* Căn giữa nội dung của bảng */
    }
    th, td {
        border: 1px solid black; /* Đường viền đen cho các ô */
        padding: 10px; /* Khoảng cách giữa nội dung và đường viền của ô */
    }
    th {
        background-color: lightgray; /* Màu nền cho tiêu đề */
    }
</style>
        <table>
  <tr>
    <td>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="307px" Width="360px" ImageUrl="~/anh/user.jpg" OnClick="ImageButton1_Click" />
      </td>
    <td>
        <asp:ImageButton ID="ImageButton2" runat="server" CssClass="auto-style3" Height="305px" Width="354px" ImageUrl="~/anh/kho.png" OnClick="ImageButton2_Click" />
      </td>
    <td class="auto-style2">
        <asp:ImageButton ID="ImageButton3" runat="server" Height="295px" Width="343px" CssClass="auto-style4" ImageUrl="~/anh/thongke.jpg" OnClick="ImageButton3_Click" />
      </td>
  </tr>
  <tr>
    <td>Quản Lí Tài Khoản</td>
    <td>Quản Lí Sản Phẩm</td>
    <td>Thống Kê</td>
  </tr>
</table>

        
  
    </form>
</body>
</html>
