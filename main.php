<?php
for($i = 2;$i < 10000000; $i++){
    $k = (int)sqrt($i);
    $f = true;
    for($j = 2;$j <= $k; $j++){
        if(($i % $j) == 0){
            $f = false;
            break;
        }
    }
    if($f){
        print($i."\n");
    }
}