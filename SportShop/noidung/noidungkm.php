<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8">
        <title>Nội dung khuyến mãi</title>
        <style>
            h3{
                text-align: center;
            }

            .box2{
                margin: 100px;
                border: 1px solid gray;
                font-size: 18px;
                padding: 10px;
                position: absolute;
                }

            .box2 a{
                text-decoration: none;
                color: blue;
            }

            .box2 img{
                width: 70%;
                height: auto;
                margin: auto;
                position: relative;
                display: block;
            }

        </style>
        <link rel="stylesheet" type="text/css" href="main.css">
    </head>
    <body>
        <img src="../images/banner1.jpg" alt="Lỗi tải ảnh!" style="width: 100%; height: 400px;">
        <?php
            $conn = mysqli_connect('localhost', 'root', '', 'sportshop') or die('Lỗi kết nối!' . mysqli_connect_error());
            mysqli_set_charset($conn, 'utf8mb4');

            if(isset($_GET['mact'])){
                $mact = mysqli_real_escape_string($conn, $_GET['mact']);
                $sql = "SELECT tenchuongtrinh, noidung, anhnoidung FROM tb_khuyenmai WHERE id_khuyenmai = '$mact' ";
                $result = mysqli_query($conn, $sql);

                if(mysqli_num_rows($result) == 1){
                    $row = mysqli_fetch_assoc($result);
                    echo '<div class="box2">';
                        echo $row['tenchuongtrinh'];
                        echo $row['noidung'];
                    echo '</div>';
                }
                else
                    echo 'Không tìm thấy chương trình khuyến mãi!';
            }
            else
                echo 'Không tìm thấy chương trình khuyến mãi!';
            mysqli_close($conn);
        ?>
    </body>
</html>