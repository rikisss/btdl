<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8">
        <title>Nội dung tin tức</title>
        <style>
            h2{
                text-align: center;
            }

            .box2{
                margin: 100px;
                border: 1px solid gray;
                font-size: 18px;
                padding: 15px;
                position: absolute;
                /* text-align: left; */
            }

            .box2 a{
                text-decoration: none;
                color: blue;
            }

            .box2 img{
                width: 60%;
                height: auto;
                margin: auto;
                position: relative;
                display: block;
            }

        </style>
    </head>
    <body>
        <?php
            $conn = mysqli_connect('localhost', 'root', '', 'sportshop') or die('Lỗi kết nối!' . mysqli_connect_error());
            mysqli_set_charset($conn, 'utf8mb4');

            if(isset($_GET['matt'])){
                $matt = mysqli_real_escape_string($conn, $_GET['matt']);
                $sql = "SELECT tenbaiviet, ngaydangbai, noidung, anh1, anh2 FROM baiviet WHERE id_baiviet = '$matt' ";
                $result = mysqli_query($conn, $sql);

                if(mysqli_num_rows($result) == 1){
                    $row = mysqli_fetch_assoc($result);
                    echo '<div class="box2">';
                        echo '<h2>'. $row['tenbaiviet'] .'</h2>';
                        echo '<p>Ngày đăng: '. $row['ngaydangbai'] .'</p>';
                        echo $row['noidung'];
                    echo '</div>';
                }
                else
                    echo 'Không tìm thấy bài đăng nào!';
            }
            else
                echo 'Không tìm thấy bài đăng nào!';
            mysqli_close($conn);
        ?>
    </body>
</html>