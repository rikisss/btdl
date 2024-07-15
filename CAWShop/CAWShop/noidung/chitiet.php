<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Document</title>
</head>
<body>
<div class="grid_column10">
 <?php 
    $conn = mysqli_connect('localhost', 'root', '', 'cawshop') or die('Lỗi kết nối!'.mysqli_connect_error());
    $sql_ct="select * from sanpham where id_sanpham=$_GET[id]";
    $run=$conn->query($sql_ct);
    $row=$run->fetch_array();
  ?>
  <div style="display: flex;">
      <table width="400px" border="0" style="border-collapse:collapse; margin:auto; margin-top:50px; margin-bottom:50px">
        <tr>
          <td style="padding:10px;"><div align="center"><img src="<?php echo $row['hinhanh'] ?>" width="350px" height="350px" /></div></td>
        </tr>
      </table>
      <table width="100%" border="0" style="border-collapse:collapse; margin:auto; margin-top:50px; margin-bottom:50px">
        <tr>
          <td colspan="2" style="padding:10px;"><div align="center"><h3><?php echo $row['tensanpham'] ?></h3></div></td>
        </tr>
        <tr>
          <td colspan="2" style="padding:10px; color:#F00"><div align="center"><h3><?php echo number_format($row['giasanpham'],0,',','.').' VNĐ' ?></h3></div></td>
        </tr>
        <tr>
          <td colspan="2" style="padding:10px; font-size:20px;"><?php echo $row['noidung'] ?></td>
        </tr>
        <tr>
          <td colspan="2" style="padding:20px;">
            <div align="center">
            <img src="images/muangay.gif" name="a" style="height: 70px; width: 120px" onclick="checkLogin()">
            <script>
              function checkLogin() {
                // Check if the user is logged in
                if (<?php echo isset($_SESSION['user']) ? 'true' : 'false' ?>) {
                  // đã đăng nhập sẽ chuyển qua trang đặt hàng
                  window.location.href = "noidung/dathang.php";
                } else {
                  // nếu chưa đăng nhập sẽ chuyển qua trang đăng nhập
                  window.location.href = "noidung/dangnhap.php";
                }
              }
            </script>    
          </td>
        </tr>
      </table>
  </div>
</div>
</body>
</html>