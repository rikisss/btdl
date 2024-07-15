<?php
    include('../../config/connect.php');
	
    if(isset($_POST['them'])){
        $name = $_POST['tensanpham'];
        $masp = $_POST['masanpham'];
        $giasp = $_POST['giasanpham'];
        $sl = $_POST['soluong'];
        $hinh = $_POST['hinhanh'];
        $nd = $_POST['noidung'];
        $iddm = $_POST['iddanhmuc'];
        
        if($conn -> query("INSERT INTO sanpham(tensanpham, masanpham, giasanpham, soluong, hinhanh, noidung, id_danhmuc) VALUES(N'$name', N'$masp', N'$giasp', N'$sl', N'$hinh', N'$nd', N'$iddm')")){
            echo "<script>alert('Thêm thành công.');</script>";
        }
        else{
            echo "<script>alert('Thêm thất bại!');</script>";
        }
    }
    $conn -> close();
?>