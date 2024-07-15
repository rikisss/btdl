<?php
    include '../config/connect.php';
    session_start();
?>
<?php

?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Thông tin cá nhân</title>
</head>
<style>
    .login {
        margin-top: 200px;
        text-align: center;
        border: 1px solid #ccc;
        padding: 20px;
        border-radius: 10px;
    }
    .login h2 {
        font-size: 25px;
        text-align: center;
    }

    .login td {
        padding: 10px;
    }

    .login div {
        text-align: left;
    }
    button[type="submit"] {
    font-size: 10px;
    width: 62%;
    padding: 10px;
    background-color: #4CAF50;
    color: white;
    border: none;
    cursor: pointer;
  }
</style>
<body>
    <?php   
        $sql = "SELECT * FROM member";
        $result = $conn->query($sql);
        $customerId = $_SESSION['user']['id'];
        $sql = "SELECT * FROM member WHERE id = $customerId";
        $result = $conn->query($sql);
        // Kiểm tra và hiển thị thông tin khách hàng trong bảng HTML
        if ($result->num_rows > 0) {
            $row = $result->fetch_assoc(); ?>
            <center>
                <table class="login">
                    <tr>
                        <td colspan="2">
                            <div align="center">
                                <h2>Thông tin cá nhân</h2>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div align="left">Tên khách hàng:
                            <output for="nameOutput" class="output"><?php echo $row["name"]; ?></output>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div align="left">Email:
                            <output for="emailOutput"><?php echo $row["email"]; ?></output>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div align="left">Địa chỉ:
                            <output for="diachiOutput">
                            <?php if($row["address"] == null) {
                                echo "Trống";
                            }
                            else {
                                echo $row["address"]; } ?> </output>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div align="left">Số điện thoại:
                            <output for="sdtOutput">
                            <?php if($row["sdt"] == null) {
                                echo "Trống";
                            }
                            else {
                                echo $row["sdt"]; } ?> </output>
                            </div>
                        </td>
                    </tr>
                    
                </table>
            </center>
            <?php
        } else {
            echo "Không có thông tin khách hàng.";
        }
        // Đóng kết nối
        $conn->close();
    ?>
</body>
</html>