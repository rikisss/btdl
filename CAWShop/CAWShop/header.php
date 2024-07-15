<?php
	session_start();
?>
<header class="header">
	<div class="header_slc">
		<div class="header_logo">
			<img class="logo_img" src="images/logo.jpg">
			<h4 class="name_logo">CAW Shop</h4>
		</div>

		<form action="index.php?quanly=timkiem" class="header_search" method="POST" >
			<input type="text" class="search_in" name="tukhoa" placeholder=" Nhập để tìm kiếm sản phẩm ">
			<button class="search_btn" name="timkiem">
				<i class="btn_icon fas fa-search"></i>
			</button>	
		</form>

		<a href="noidung/giohang.php" class="header_cart">
			<div class="cart_wrap">
			<i class="cart_icon fas fa-shopping-cart"></i>
			</div>
		</a>
		<div class="header_div">
			<ul class="header_list">
				<?php if(isset($_SESSION['user']) != NULL) { ?>
					<nav class = "session">
						<li class="header_ses_item"> <?php echo $_SESSION['user']['name']; ?>	</li>
						<ul class = "header_session">
							<li class="session_item" > <a class="session_link" href = "noidung/thongtincanhan.php">Thông tin cá nhân</a> </li>
							<li class="session_item" > <a class="session_link" href = "noidung/dangxuat.php">Đăng xuất</a></li> 
						</ul>
					</nav>
				<?php } else { ?>
					<li class="header_item item_separate"><a href="noidung/dangky.php">Đăng ký</a></li>
					<li class="header_item"><a href="noidung/dangnhap.php">Đăng nhập</a></li>
				<?php } ?>
			</ul>
		</div>

	</div>
</header>
	