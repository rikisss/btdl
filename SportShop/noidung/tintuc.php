<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8">
        <title>Tin tức</title>
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
    </head>
    <body>
        <h1>Tin tức mới nhất</h1>
        <div class="container">
            <?php
                $conn = mysqli_connect('localhost', 'root', '', 'sportshop') or die('Lỗi kết nối!' . mysqli_connect_error());
                mysqli_set_charset($conn, 'utf8mb4');

                $sql = "SELECT id_baiviet, tenbaiviet, anh2 FROM baiviet ORDER BY ngaydangbai DESC";
                $result = mysqli_query($conn, $sql);

                if(mysqli_num_rows($result) > 0){
                    while($row = mysqli_fetch_assoc($result)){
                        echo '<div class="box">';
                            echo '<a href="noidungtt.php?matt=' . $row['id_baiviet'] . '">';
                                echo '<div class="box1">';
                                    echo '<img src="images/' . $row['anh2'] . '" alt="' . $row['tenbaiviet'] . '">';
                                    echo '<h3>' . $row['tenbaiviet'] . '</h3>';
                                echo '</div>';
                            echo '</a>';
                        echo '</div><br/>';
                    }
                }
                else
                    echo 'Không tìm thấy bài viết nào!';
                mysqli_close($conn);
            ?>
        </div>
    </body>
</html>