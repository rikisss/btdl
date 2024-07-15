<?php
	session_start();
	include '../config/connect.php';
	$err = [];
	if(isset($_SESSION['name'])) {
		header('Location: index.php');
	}
	else if(isset($_POST['reg'])) {
		$name = $_POST['name'];
		$email = $_POST['email'];
		$password= $_POST['password'];
		$rPassword = $_POST['rPassword'];
		if(empty($name)) {
			$err['name'] =  'Bạn chưa nhập tên';
		}
		if(empty($email)) {
			$err['email'] = 'Bạn chưa nhập email';
		}
		if(empty($password)) {
			$err['password'] = 'Bạn chưa nhập mật khẩu';
		}
		if($password != $rPassword) {
			$err['rPassword'] = 'Mật khẩu nhập lại không đúng';
		}
		if(empty($err)) {
			$sql = "INSERT INTO member(name,email,password) VALUES ('$name','$email','$password')";
			$query = mysqli_query($conn, $sql);
			if($query) {
				echo "<script>alert('Đăng kí thành công!') </script>";
				header('location:dangnhap.php');
			}
			else {
				echo "<script>alert('Đăng kí thất bại!') </script>";
			}
		}
	}
?>
<!DOCTYPE html>
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="cssreg.css">
    <title>Đăng ký</title>
    <style>
        html, body {
            height: 100%;
        }
        body {
            background-image: url("images/anh.jpg");
            background-size: cover;
            display: flex;
            align-items: center;
            flex-direction: column;
            justify-content: center;
        }
        .login {
            width: 300px;
            height: auto;
            border: 1px solid grey;
            border-radius: 10px;
            text-align: center;
            background: white;
        }
        h2 {
            color: #868787;
            font-family: sans-serif;
        }
        .login input{
            width: 200px;
            height: 40px;
            margin-bottom : 10px;
            border-radius: 5px;
            border: 1px solid grey;
            padding-left: 5px;
        }
        .login button {
            width: 220px;
            height: 40px;
            margin-bottom: 10px;
            border-radius: 5px;
            border: none;
            background-color: #45a049;
            color: white;
        }
        .login button:hover{
            font-size: 20px;
        }
        .login .has-erros {
            color: red;
            padding-left:5px;
        }
    </style>
</head>
<body>
	<div class = "login">
		<form action="" method="POST" role = "form">
			<h2> Đăng ký</h2>
			<input type="text" placeholder="Nhập tên người dùng" name="name">
			<div class="has-erros">
				<span> <?php echo (isset($err['name']))? $err['name']:'' ?> </span>
			</div>
			<input type="text" placeholder="Nhập email" name="email">
			<div class="has-erros">
				<span> <?php echo (isset($err['email']))?$err['email']:'' ?> </span>
			</div>
			<input type="password" class="form-control" placeholder="Nhập mật khẩu" name="password">
			<div class="has-erros">
				<span> <?php echo (isset($err['password']))?$err['password']:'' ?> </span>
			</div>
			<input type="password" class="form-control" placeholder="Nhập lại mật khẩu" name="rPassword">
			<div class="has-erros">
				<span> <?php echo (isset($err['rPassword']))?$err['rPassword']:'' ?> </span>
			</div>		
			<button type="submit" name="reg" class="btn btn-primary">Đăng ký<b/button>
		</form>
	</div>
</body>
</html>