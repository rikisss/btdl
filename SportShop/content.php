<div class="container">
	<div class="grid">
		<div class="grid_row">		
			<?php
				if(isset($_GET['quanly'])){
					$tam=$_GET['quanly'];
				}else{
					$tam='';
				}if($tam=='chitiet'){
					include('noidung/chitiet.php');
				}elseif($tam=='mathang'){
					include('noidung/mathang.php');
				}elseif($tam=='giohang'){
					include('noidung/themgiohang.php');
				}elseif($tam=='capnhatgiohang'){
					include('noidung/capnhatgiohang.php');
				}elseif($tam=='timkiem'){
					include('noidung/search.php');
				}
				else{
					include('noidung/sanpham.php');
				}
			?>
		</div>
	</div>
</div>