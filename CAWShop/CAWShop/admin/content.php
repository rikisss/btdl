<div class="clear"></div>
<div class="content">
    <?php
        if(isset($_GET['action'])){
            $tam = $_GET['action'];
        }
        else{
            $tam = '';
        }
        if($tam=='quanlydanhmucsanpham'){
            include('categorymanager/more.php');
        }
        else if($tam=='quanlysanpham'){
            include('productmanager/more.php');
        }
        else if($tam=='lietke'){
            include('lietke/more.php');
        }
        else{
            include('welcom.php');
        }
    ?>
</div>