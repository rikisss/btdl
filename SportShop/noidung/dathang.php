<?php 
 session_start();
 include '../config/connect.php';
 $err = [];
  if(isset($_POST['thanhtoan'])) {
		$namee = $_POST['namee'];
		$emaill = $_POST['emaill'];
		$diachinhan = $_POST['diachinhan'];
    $dtnhan = $_POST['dtnhan'];
    $soluong = $_POST['soluong'];
    $size = $_POST['size'];
    $pttt = $_POST['pttt'];
    $makhuyenmai = $_POST['makhuyenmai'];
		if(empty($namee)) {
			$err['namee'] =  'Bạn chưa nhập tên';
		}
		if(empty($emaill)) {
			$err['emaill'] = 'Bạn chưa nhập email';
		}
		if(empty($diachinhan)) {
			$err['diachinhan'] = 'Bạn chưa nhận địa chỉ';
		}
		if(empty($dtnhan)) {
      $err['dtnhan'] = 'Bạn chưa nhập số điện thoại';
		} 
    if(empty($pttt)) {
      $err['pttt'] = 'Bạn chưa chọn phương thức thanh toán';
		} 
    if(empty($soluong)) {
      $err['soluong'] = 'Bạn chưa nhập số lượng';
		} 
    if(empty($size)) {
      $err['size'] = 'Bạn chưa nhập kích cỡ';
		} 
  
    if($conn -> query("INSERT INTO dathang(namee, emaill, diachinhan, dtnhan, soluong, size, pttt)
     VALUES(N'$namee', N'$emaill', N'$diachinhan', N'$dtnhan', N'$soluong', N'$size', N'$pttt')")){
      echo "<script>alert('Đặt hàng thành công.');</script>";
  }
  else{
      echo "<script>alert('đặt hàng thất bại!');</script>";
  }}

?>
<style>
  table {
    border: 1px solid #b1154a;
    width: 500px;
    margin-top: 100px;
    margin-bottom: 100px;
    border-collapse: collapse;
  }
  table {
    text-align: left;
  }
  td {
    padding: 5px;
    font-size: 20px;
  }

  h2 {
    margin: 0;
  }

  input[type="text"],
  input[type="number"],
  select[name ="lang"] {
    width: 100%;
    padding: 5px;
  }

  input[type ="number"],
  select[name ="size"] {
    width: 30%;
    padding: 5px;
  }

  select[name ="makhuyenmai"] {
    width: 50%;
    padding: 5px;
  }
  select[name ="pttt"] {
    width: auto;
    padding: 5px;
  }

  input[type="submit"] {
    font-size: 20px;
    width: 100%;
    padding: 10px;
    background-color: #4CAF50;
    color: white;
    border: none;
    cursor: pointer;
  }
  .login .has-erros {
    color: red;
    padding-left:5px;
  }
</style>

<form action="" method="POST" role = "form">
<center>
  <table class ="login">
    <tr>
      <td colspan="2">
        <div align="center">
          <h2>Đặt hàng</h2>
        </div>
      </td>
    </tr>
    <tr>
      <td><div align="left">Người nhận hàng:</div></td>
      <td><input type="text" name="namee" />
      <div class="has-erros">
				<span> <?php echo (isset($err['namee']))?$err['namee']:'' ?> </span>
			</div>
      </td>
    </tr>
    <tr>
      <td><div align="left">Email người nhận:</div></td>
      <td>
        <input type="text" name="emaill"/>
        <div class="has-erros">
          <span> <?php echo (isset($err['emaill']))?$err['emaill']:'' ?> </span>
        </div>
      </td>
    </tr>
    <tr>
      <td>
        <div align="left" >Địa chỉ nhận hàng:</div>
      </td>
      <td>
        <input type="text" name="diachinhan" />
        <div class="has-erros">
          <span> <?php echo (isset($err['diachinhan']))?$err['diachinhan']:'' ?> </span>
        </div>
      </td>
    </tr>
    <tr>
      <td>
        <div align="left">Số ĐT nhận:</div>
      </td>
      <td>
        <input type="text" name="dtnhan" />
        <div class="has-erros">
				  <span> <?php echo (isset($err['dtnhan']))?$err['dtnhan']:'' ?> </span>
			  </div>
      </td>
    </tr>
    <tr>
      <td>
        <div align="left">Số lượng:</div>
      </td>
      <td>
        <input type="number" name="soluong" min="1" max="30"/>
        <div class="has-erros">
				  <span> <?php echo (isset($err['soluong']))?$err['soluong']:'' ?> </span>
			  </div>
      </td>
    </tr>
    <tr>
      <td>
        <div align="left">
          <label for ="">Mã khuyến mãi:</label>
        </div>
          <td> 
            <select name="makhuyenmai" id="ma">
              <option value="" checked = "checked"></option>
              <option value="XSSDQWD3Q">XSSDQWD3Q</option>
              <option value="SDQWD4s">SDQWD4S</option>
              <option value="MFJSJKAJ1">MMFJSJKAJ1</option>
              <option value="LJNKJCNJ2">LJNKJCNJ2</option>
              <option value="MKPSDJIA3">MKPSDJIA3</option>
              <option value="XJUNIBFIU3">XJUNIBFIU3</option>
              <option value="JIFOEEFON">JIFOEEFON</option>
            </select> 
          </td>
      </td>     
    </tr>
    <tr>
      <td>
        <div align="left">
          <label for ="">Kích cỡ:</label>
        </div>
          <td> 
            <select name="size" id="lang-select">
              <option value="XS" id = "1"checked = "checked">XS</option>
              <option value="S" id ="2">S</option>
              <option value="M" id="3">M</option>
              <option value="L" id ="4">L</option>
              <option value="1XL"id = "5">1XL</option>
              <option value="2XL" id = "6">2XL</option>
              <option value="3XL" id = "7">3XL</option>
            </select> 
            <div class="has-erros">
              <span> <?php echo (isset($err['size']))?$err['size']:'' ?> </span>
            </div>
          </td>
      </td>     
    </tr>
    <tr>
      <td> <div align="left">Phương thức thanh toán:</div></td>
      <td>
        <select name="pttt" id="lang-select">
          <option value="" id ="1" checked = "checked">Chọn phương thức thanh toán</option>
          <option value="ttknh" id = "2" >Thanh toán khi nhận hàng</option>
          <option value="momo" id = "3" >Ví Momo</option>
          <option value="zalopay" id = "4">Ví Zalopay</option>
          <option value="tk id" id = "5">Thanh toán bằng thẻ ghi nợ/ tài khoản</option>
        </select>
        <div class="has-erros">
				<span> <?php echo (isset($err['pttt']))?$err['pttt']:'' ?> </span>
			</div>
      </td>
    </tr>
    <tr>
      <td colspan="2">
        <div align="center">
          <input type="submit" name="thanhtoan" value="Thanh toán" />
        </div>
      </td>
    </tr>
  </table>
</center>
</form>