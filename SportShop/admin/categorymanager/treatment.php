<?php
    include('../../config/connect.php');
	
    if(isset($_POST['them'])){
        $name = $_POST['tendanhmuc'];
        
        if($conn -> query("INSERT INTO danhmuc(tendanhmuc) VALUES(N'$name')")){
            echo "<script>alert('Thêm thành công.');</script>";
        }
        else{
            echo "<script>alert('Thêm thất bại!');</script>";
        }
    }
    $conn -> close();
?>