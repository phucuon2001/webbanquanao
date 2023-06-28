<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="giohang.aspx.cs" Inherits="webbanhangnhom8.giohang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <style>
    /* CSS rules here */
    #GridView1 {
      border-collapse: collapse;
      width: 100%;
      margin-bottom: 20px;
      border: 1px solid #ddd;
      font-size: 16px;
    }
    #GridView1 th,
    #GridView1 td {
      text-align: center;
      padding: 8px;
    }
    #GridView1 th {
      background-color: #4CAF50;
      color: white;
    }
    #GridView1 tr:nth-child(even) {
      background-color: #f2f2f2;
    }
    #GridView1 tr:hover {
      background-color: #ddd;
    }
    #Image1 {
      max-width: 200px;
      max-height: 200px;
      display: block;
      margin: auto;
    }
    #lblTotalPrice {
      display: block;
      text-align: right;
      margin-top: 20px;
      font-weight: bold;
      font-size: 20px;
    }
    #Button1 {
      display: block;
      margin: 20px auto;
      font-size: 20px;
      background-color: #4CAF50;
      color: white;
      border: none;
      padding: 10px 20px;
      border-radius: 5px;
      cursor: pointer;
    }
    #Button1:hover {
      background-color: #3e8e41;
    }
    #Button3 {
      display: block;
      margin: 20px auto 0;
      font-size: 20px;
      background-color: #f44336;
      color: white;
      border: none;
      padding: 10px 20px;
      border-radius: 5px;
      cursor: pointer;
    }
    #Button3:hover {
      background-color: #da190b;
    }
  </style>
    <form id="form1" runat="server">
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Quay lại gian hàng" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="595px" Width="1046px" >
    <Columns>
        <asp:BoundField DataField="mahang" HeaderText="Mã Hàng" />
        <asp:BoundField DataField="soluong" HeaderText="Số lượng" />
        <asp:BoundField DataField="dongia" HeaderText="Đơn Giá" />
        <asp:BoundField DataField="thanhtien" HeaderText="Thành Tiền" />
        <asp:TemplateField HeaderText="Ảnh">
            <ItemTemplate>
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("hinhanh") %>' Height="200px" Width="200px" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
        <asp:Label ID="lblTotalPrice" runat="server" Text="Tổng tiền: "></asp:Label>
        <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Thanh Toán" />
        </p>
    </form>
</body>
</html>
