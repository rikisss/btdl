<head>
    <title>Trang chính sách vận chuyển</title>
    <link rel="stylesheet" type="text/css" href="../main.css">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.15.4/css/all.css"
        integrity="sha384-DyZ88mC6Up2uqS4h/KRgHuoeGwBcD4Ng9SiP4dIRy0EXTlnuz47vAwmeGwVChigm" crossorigin="anonymous" />
    <style>
        .container{
            padding: 10px;
        }
        .title_cs {
            text-align: center;
            color:#333;
            margin-bottom: 40px;
        }
        .cs_muc {
            text-align: left;
            color: #333;
            margin-left: 40px;
        }
        .cs_p, .cs_ul {
            color: #444;
            line-height: 1.5;
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <div class="container">
        <?php
        include '../header.php';
        include '../menu.php';
        ?>

        <div>
            <h2 class="title_cs">CHÍNH SÁCH VẬN CHUYỂN</h2>
            <h3 class="cs_muc">Trong Tỉnh Bình Định:</h3>
            <ul class="cs_ul">
                <li>Phí vận chuyển 20.000vnđ, miễn phí cho các đơn có giá trị cao hơn 299.000vnđ</li>
                <li>Giao hàng khẩn cấp, trong ngày thêm 5.000vnđ/Km</li>
            </ul>
            <h3 class="cs_muc">Các Tỉnh khác:</h3>
            <ul class="cs_ul">
                <li>Phí vận chuyển 30.000vnđ, miễn phí cho các đơn có giá trị lớn hơn 299.000vnđ</li>
                <li>Thời gian giao hàng: 1-2 ngày với thành phố và 3-4 ngày với huyện xã</li>
                <li>Huyện đảo thời gian vận chuyển có thể lên đến 7 ngày</li>
            </ul>
        </div>

        <?php
        include '../footer.php';
        ?>
    </div>
</body>