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
    $conn = mysqli_connect('localhost', 'root', '', 'sportshop') or die('Lỗi kết nối!'.mysqli_connect_error());
    $sql_ct="select * from dathang";
    $run=$conn->query($sql_ct);
    $row=$run->fetch_array();
  ?>
  <div style="display: flex;">
      
      <table width="500px" border="1" style="border-collapse:collapse; margin:auto; margin-top:50px; margin-bottom:50px">
        <tr>
          <td colspan="2" style="padding:10px;"><div align="center"><h3><?php echo $row['namee'] ?></h3></div></td>
        </tr>
        <tr>
            <td colspan="2" style="padding:10px;"><div align="center"><h3><?php echo $row['dtnhan'] ?></h3></div></td>
        </tr>
        <tr>
          <td colspan="2" style="padding:10px;"><div align="center"><h3><?php echo $row['diachinhan'] ?></h3></div></td>
        </tr>
        <tr>
        <td colspan="2" style="padding:10px;"><div align="center"><h3><?php echo $row['soluong'] ?></h3></div></td>
        </tr>
        <tr>
          <td colspan="2" style="padding:10px;"><div align="center"><h3><?php echo $row['size'] ?></h3></div></td>
        </tr>
        <tr>
        <td colspan="2" style="padding:10px;"><div align="center"><h3><?php echo $row['pttt'] ?></h3></div></td>
        </tr>
      </table>
  </div>
</div>
</body>
</html>