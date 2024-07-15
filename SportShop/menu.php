<div class="menu">
	<ul class="menu_link">
		<li class="menu_list"><a class="menu_item" href="index.php">Trang Chủ</a></li>
		<li class="menu_list"><a class="menu_item" href="">Sản Phẩm</a>
			<?php
				$conn = mysqli_connect('localhost', 'root', '', 'sportshop') or die('Lỗi kết nối!'.mysqli_connect_error());
				$sql = "SELECT * FROM danhmuc";
				$result = mysqli_query($conn, $sql);
				if(mysqli_num_rows($result) > 0){
					while($row = mysqli_fetch_assoc($result)){?>
						<div>
							<ul class="sub_menu">
								<li class="item">
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
		</li>
		<li class="menu_list"><a class="menu_item" href="noidung/tintuc.php">Tin Tức</a></li>
		<li class="menu_list"><a class="menu_item" href="noidung/khuyenmai.php">Khuyến Mãi</a></li>
		<li class="menu_list"><a class="menu_item" href="noidung/gioithieu.php">Giới Thiệu</a></li>
	</ul> 	          
</div>