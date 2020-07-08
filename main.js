for(i=2;i < 10000000; i++){
    k=Math.sqrt(i)
    f=true;
    for(j=2;j <= Math.floor(k); j++){
        if((i % j) == 0){
            f=false;
            break;
        }
    }
    if(f){
        console.log(i);
    }
}