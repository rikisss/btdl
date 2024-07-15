<?php
	if(isset($_POST['timkiem'])){
		$tk = $_POST['tukhoa'];
	}
	$conn = mysqli_connect('localhost', 'root', '', 'sportshop') or die('Lỗi kết nối!'.mysqli_connect_error());
	$sql = "SELECT * FROM sanpham WHERE sanpham.tensanpham LIKE '%".$tk."%' ";
	$query = mysqli_query($conn, $sql);
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
		if(mysqli_num_rows($query) > 0){
			while($row = mysqli_fetch_assoc($query)){?>
				<ul class="products">
					<li><a style="text-decoration: none;" href="index.php?quanly=chitiet&id=<?php echo $row['id_sanpham']?>">
						<div class="product-info">
							<img class="imgsp" src=" <?php echo $row['hinhanh']?>">
							<h4 style="color: black;"><?php echo $row['tensanpham'] ?></h4>
							<p class="price"> <?php echo number_format($row['giasanpham'],0,',','.').' VND'?></p>  
						</div>
					</li>
				</ul>
	<?php	
			}
		}
		else{
			echo 'Không tìm thấy sản phẩm...';
		}
	?>
</div>