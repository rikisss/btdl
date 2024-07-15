<?php
	session_start();
	include '../config/connect.php';
	if(isset($_POST['login'])) {
		$email = $_POST['email'];
		$password = $_POST['password'];
		$sql = "SELECT * FROM member WHERE email = '$email' and password = '$password'";
		$query = $conn->query($sql);
		$data = mysqli_fetch_assoc($query);
		$nums = $query->num_rows;
		if($nums > 0) {
			$_SESSION['user'] = $data;
			header('location:../index.php');
			$to = $email;
        	$subject = 'Đăng nhập thành công';
        	$message = 'Bạn đã đăng nhập thành công vào KP SportShop.';
        	$headers = 'From: dongocdat28042003@gmail.com' ;
			mail($to, $subject, $message, $headers);
		}
		else {
			$error_message = "Tài khoản hoặc mật khẩu không đúng";
		}
	}
?>
<!DOCTYPE html>
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="csslogin.css">
    <title>Đăng nhập</title>
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
			padding-left: 10px;
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
		.error-message {
			font-size:14px;
			color: red;
			padding-left: 0px;
		}
	</style>
</head>
<body>
	<div class = "login">
		<form action="" method="POST" role = "form">
			<h2> Đăng nhập</h2>
			<input type="text" placeholder="Nhập email" name="email">
			<input type="password" placeholder="Nhập mật khẩu" name="password">
			<div class="error-message">
				<?php if(isset($error_message)) { echo $error_message; } ?>
			</div>
			<button type="submit" name ="login" >Đăng nhập</button>
		</form>
	</div>
</body>
</html>