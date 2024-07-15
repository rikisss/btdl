<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8">
        <title>Khuyến mãi</title>
        <link rel="stylesheet" type="text/css" href="../main.css">
        <style>
            h1 {
                text-align: center;
            }

            h3 {
                text-align: center;
            }

            .container {
                display: flex; /*hiển thị các phần tử con theo 1 hàng duy nhất*/
                flex-wrap: wrap; /*tự động xuống dòng khi không đủ chỗ*/
                margin: 50px; /*tạo khoảng cách xung quanh phần tử container*/
                justify-content: space-around; /*Các box sẽ được căn đều về hai phía, tạo khoảng cách giữa các box*/
            }

            .box {
                position: relative;
                margin-bottom: 20px;
            }

            .box a {
                text-decoration: none;
                color: #000;
                display: inline-block;
                width: auto;
                /* height: auto; */
                padding: 5px;
                overflow: hidden; /*sẽ bị ẩn đi nếu phần tử con vượt quá khu vực được chỉ định*/
            }

            .box a:hover .box1 {
                transform: translateY(-3px); /*khi rê chuột vào phần tử dịch chuyển lên 3px*/
                /* height: auto; */
            }

            .box1 {
                border: 1px solid #525050;
                width: 320px;
                height: 335px;
                box-shadow: 8px 4px 8px rgba(0, 0, 0, 0.2);
            }

            .box1 img {
                width: 97%;
                height: 200px;
                margin: 5px;
            }

            .box1 h3, p {
                margin-left: 10px; /* Khoảng cách từ bên trái của phần nội dung đến ảnh */
                word-wrap: break-word;
            }
        </style>
        <link rel="stylesheet" type="text/css" href="main.css">
    </head>
    <body>
        <img src="../images/banner1.jpg" alt="Lỗi tải ảnh!" style="width: 100%; height: 400px;">
        <h1>Chương trình khuyến mãi</h1>
        <div class="container">
            <?php
                $conn = mysqli_connect('localhost', 'root', '', 'sportshop') or die('Lỗi kết nối!' . mysqli_connect_error());
                mysqli_set_charset($conn, 'utf8mb4');

                $sql = "SELECT id_khuyenmai, tenchuongtrinh, mota, hinhanh FROM tb_khuyenmai";
                $result = mysqli_query($conn, $sql);

                if(mysqli_num_rows($result) > 0){
                    while($row = mysqli_fetch_assoc($result)){?>
                        <div class="box">
                            <a href="noidungkm.php?mact=<?php echo $row['id_khuyenmai']?>">
                                <div class="box1">
                                    <img src="images/<?php echo $row['hinhanh']?>"/>
                                    <h3> <?php echo $row['tenchuongtrinh']?></h3>
                                    <p><?php echo $row['mota']?></p>
                                </div>
                            </a>
                        </div><br/>
                    <?php
                    }
                }
               
            ?>
                    
        </div>
    </body>
</html>
