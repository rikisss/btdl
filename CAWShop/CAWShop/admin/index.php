<!DOCTYPE html PUBLIC>
<html>

<head>
    <title> Admin </title>
    <meta charse="utf-8">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.15.4/css/all.css"
        integrity="sha384-DyZ88mC6Up2uqS4h/KRgHuoeGwBcD4Ng9SiP4dIRy0EXTlnuz47vAwmeGwVChigm" crossorigin="anonymous" />
    <style>
        .wrapper{
            border: 1px solid #000;
            height: auto;
            width: 100%;
            margin: 0 auto;
        }
        .title_admin{
            text-align: center;
            font-size: 30px;
            color: blue;
        }
        .admin_list{
            padding: 0;
            margin: 0;
            list-style: none; 
        }
        .admin_list li{
            float: left;
            margin: 5px;
        }
        .clear{
            clear: both;
        }
        .link{
            text-decoration: none;
            color: #8b4513;
        }
    </style>
</head>

<body>
    <h3 class="title_admin"> Chào Mừng Đến Với Trang Admin </h3>
    <div class="wrapper">
        <?php
            include('../config/connect.php');
            include('menu.php');
            include('content.php');
        ?>
    </div>
</body>

</html>