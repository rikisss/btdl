<?php
	include('noidung/slide.php');
?>
<div class="grid_column2">
	<nav class="category">
		<h3 class="cate_heading"> <i class="fas fa-list"></i> Danh Mục</h3>
		<!--<ul class="category_list">-->
		<?php
			$conn = mysqli_connect('localhost', 'root', '', 'sportshop') or die('Lỗi kết nối!'.mysqli_connect_error());
			$sql = "SELECT * FROM danhmuc";
			$result = mysqli_query($conn, $sql);
			if(mysqli_num_rows($result) > 0){
				while($row = mysqli_fetch_assoc($result)){?>
					<div>
						<ul class="category_item">
							<li class="co_item_link">
								<a href="index.php?quanly=mathang&id=<?php echo $row['id_danhmuc']?>" class="co_item_link"><?php echo $row['tendanhmuc'] ?></a>
							</li>
						</ul>
					</div><br/>
				<?php }
			}
			else {
				echo 'Không có dữ liệu!';
			}
			mysqli_close($conn);
		?>
		<!--</ul>-->
	</nav>
	<?php
		include('noidung/sale.php');
	?>
</div>
<div class="grid_column10">

	<?php
		$conn = mysqli_connect('localhost', 'root', '', 'sportshop') or die('Lỗi kết nối!'.mysqli_connect_error());
		$sql = "SELECT * FROM danhmuc where id_danhmuc='$_GET[id]'";
		$result = mysqli_query($conn, $sql);
		if(mysqli_num_rows($result) > 0){
			while($row_mh = mysqli_fetch_assoc($result)){?>
		 		<h1 class="section-title section-title-center" style="display: flex; font-size: 1.5rem; color: #c038cb; webkit-box-align: center;">
		 			<b style="display: block; webkit-box-flex: 1; ms-flex: 1; flex: 1; height: 2px; opacity: .1; background-color: currentColor; margin: 14px;"></b>
		 				<span class="section-title-main"><?php echo $row_mh['tendanhmuc'] ?></span>
		 			<b style="display: block; webkit-box-flex: 1; ms-flex: 1; flex: 1; height: 2px; opacity: .1; background-color: currentColor; margin: 14px;"></b>
		 		</h1>
		 	<?php }
		 }
		 else {
		 	echo 'Không có dữ liệu!';
		 }
		 mysqli_close($conn);
		?>

	<?php
		$conn = mysqli_connect('localhost', 'root', '', 'sportshop') or die('Lỗi kết nối!'.mysqli_connect_error());
		$result = mysqli_query($conn, "select count(id_danhmuc) as total from sanpham where id_danhmuc='$_GET[id]'");
		$row_mh = mysqli_fetch_assoc($result);
		$total_records = $row_mh['total'];
		// BƯỚC 3: TÌM LIMIT VÀ CURRENT_PAGE
		$current_page = isset($_GET['page']) ? $_GET['page'] : 0;
		$limit = 20;	
		// BƯỚC 4: TÍNH TOÁN TOTAL_PAGE VÀ START
		// tổng số trang
		$total_page = ceil($total_records / $limit);
		// Giới hạn current_page trong khoảng 1 đến total_page
		if ($current_page > $total_page){
			$current_page = $total_page;
		}
		else if ($current_page < 1){
			$current_page = 1;
		}				
		// Tìm Start
		$start = ($current_page - 1) * $limit;
		// BƯỚC 5: TRUY VẤN LẤY DANH SÁCH TIN TỨC
		// Có limit và start rồi thì truy vấn CSDL lấy danh sách tin tức
		$result = mysqli_query($conn, "SELECT * FROM sanpham WHERE id_danhmuc='$_GET[id]' LIMIT $start, $limit");
		//$sql = "SELECT tensanpham, giasanpham, hinhanh FROM sanpham";
		//$result = mysqli_query($conn, $sql);
		if(mysqli_num_rows($result) > 0){
			while($row_mh = mysqli_fetch_assoc($result)){
		?>
				<form class="products" method="POST" action="noidung/themgiohang.php?id_sanpham=<?php echo $row_mh['id_sanpham']?>">
					<div class="product-info"> <a style="text-decoration: none;" href="index.php?quanly=chitiet&id=<?php echo $row_mh['id_sanpham'] ?>">
						<img class="imgsp" src="<?php echo $row_mh['hinhanh'] ?>"/>
						<h4 style="color: black;"> <strong> <?php echo $row_mh['tensanpham'] ?></strong></h4>
						<p class="price"> <?php echo number_format($row_mh['giasanpham'],0,',','.').' VND'?></p> 
					</div>
				</form>
	<?php
			}
		}
		else {
			echo 'Không có dữ liệu!';
		}
		mysqli_close($conn);
	?>
</div>	
<div class="pagination">
	<?php 			
		// PHẦN HIỂN THỊ PHÂN TRANG
		// BƯỚC 7: HIỂN THỊ PHÂN TRANG
		// nếu current_page > 1 và total_page > 1 mới hiển thị nút prev
		if ($current_page > 1 && $total_page > 1){
			echo '<div class="page"> <a style="text-decoration:none;" href="index.php?quanly=mathang&id='.$_GET['id'].'&page='.($current_page-1).'">Prev</a> </div>';
		}
		// Lặp khoảng giữa
		for ($i = 1; $i <= $total_page; $i++){
		// Nếu là trang hiện tại thì hiển thị thẻ span
		// ngược lại hiển thị thẻ a
			if ($i == $current_page){
				echo '<div class="page"> <span>'.$i.' </span> </div>'; 
			}
			else{
				echo '<div class="page"> <a style="text-decoration:none;" href="index.php?quanly=mathang&id='.$_GET['id'].'&page='.$i.'">'.$i.' </a> </div>';
			}
		}
		// nếu current_page < $total_page và total_page > 1 mới hiển thị nút prev
		if ($current_page < $total_page && $total_page > 1){
			echo '<div class="page"> <a style="text-decoration:none;" href="index.php?quanly=mathang&id='.$_GET['id'].'&page='.($current_page+1).'">Next</a> </div>';
		}
	?>
</div>
