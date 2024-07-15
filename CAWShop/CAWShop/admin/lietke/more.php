<?php
    $conn = mysqli_connect('localhost', 'root', '', 'sportshop') or die('Lỗi kết nối!'.mysqli_connect_error());
    $result = mysqli_query($conn, "select * from danhmuc");
    $row = mysqli_fetch_assoc($result);
?>

<p style="color: #ff00ff">Liệt kê danh mục sản phẩm</p>
<table border="1" width="100%" style="border-collapse: collapse;">
    <tr>
        <th>Id</th>
        <th>Tên danh mục</th>
        <th>Quản lý</th>
    </tr>
    <?php
        $i=0;
        while($row = mysqli_fetch_assoc($result)){
            $i++;
    ?>
    <tr>
        <td><?php echo $row['id_danhmuc'] ?></td>
        <td><?php echo $row['tendanhmuc'] ?></td>
        <td>
            <a href="admin/lietke/treatment.php?iddanhmuc=<?php echo $row['id_danhmuc']?>" style="text-decoration: none; color: #ff0000;">Xóa</a> | <a href="?action=quanlydanhmuc&query=sua" style="text-decoration: none; color: #339900;">Sửa</a>
        </td>
    </tr>
    <?php
        }
    ?>
</table>


<?php
    $conn = mysqli_connect('localhost', 'root', '', 'sportshop') or die('Lỗi kết nối!'.mysqli_connect_error());
    $result = mysqli_query($conn, "select * from sanpham");
    $row = mysqli_fetch_assoc($result);
?>

<p style="color: #ff00ff">Liệt kê sản phẩm</p>
<table border="1" width="100%" style="border-collapse: collapse;">
    <tr>
        <th>Id</th>
        <th>Tên sản phẩm</th>
        <th>Mã sản phẩm</th>
        <th>Giá sản phẩm</th>
        <th>Số lượng</th>
        <th>Hình ảnh</th>
        <th>Nội dung</th>
        <th>Id danh mục</th>
        <th>Quản lý</th>
    </tr>
    <?php
        $i=0;
        while($row = mysqli_fetch_assoc($result)){
            $i++;
    ?>
    <tr>
        <td><?php echo $row['id_sanpham'] ?></td>
        <td><?php echo $row['tensanpham'] ?></td>
        <td><?php echo $row['masanpham'] ?></td>
        <td><?php echo $row['giasanpham'] ?></td>
        <td><?php echo $row['soluong'] ?></td>
        <td><img  style="width: 100px; height: 100px;" class="imgsp" src="../<?php echo $row['hinhanh'] ?>"/></td>
        <td><?php echo $row['noidung'] ?></td>
        <td><?php echo $row['id_danhmuc'] ?></td>
        <td>
            <a href="?action=quanlysanpham&query=xoa" style="text-decoration: none; color: #ff0000;">Xóa</a> <a href="?action=quanlysanpham&query=sua" style="text-decoration: none; color: #339900;">Sửa</a>
        </td>
    </tr>
    <?php
        }
    ?>
</table>