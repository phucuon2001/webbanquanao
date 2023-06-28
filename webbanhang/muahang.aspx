<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="muahang.aspx.cs" Inherits="webbanhangnhom8.user.muahang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <link href="css/Stylemuahang.css" rel="stylesheet" type="text/css" />
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txttimkiem" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Tim Kiem" OnClick="Button1_Click" />
           <asp:Button ID="Button2" runat="server" Text="Xem giỏ hàng" OnClick="Button2_Click" />
        </div>

        <asp:DataList ID="DataList1" runat="server" DataKeyField="mahang" RepeatColumns="4" Height="1114px" Width="1447px" OnSelectedIndexChanged="DataList1_SelectedIndexChanged1">
  <ItemTemplate>
      
    <div class="product">
        <div><h3><%# Eval("mahang") %></h3>
        <div><h3><%# Eval("tenhang") %></h3>
        
      <div class="product-image">
        <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/anh/" + Eval("hinhanh") %>' Height="300px" Width="168px" />
      </div>
      <div class="product-info">
        <p><%# Eval("dongiaban") %>VNĐ</p></div><br />
            
        <asp:LinkButton ID="LinkButton" runat="server" CssClass="add-to-cart">Thêm vào giỏ hàng</asp:LinkButton>
            <br />
        <a href='chitietsanpham?mahang=<%# Eval("mahang") %>' class="details-link">Chi tiết sản phẩm</a>
      </div>
    </div>
  </ItemTemplate>
</asp:DataList>

    </form>
</body>
</html>
