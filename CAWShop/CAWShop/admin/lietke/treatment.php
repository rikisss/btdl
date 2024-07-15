<?php
    include('../../config/connect.php');
    if(isset($_POST['suadanhmuc'])){

    }
    else{
        $id=$_GET['id_danhmuc'];
        $sql_xoa="DELETE FROM danhmuc WHERE id_danhmuc='".$id."'";
        mysqli_query($mysqli, $sql_xoa);
        header("location:../../index.php?action=quanlydanhmucsanpham");
    }
?>