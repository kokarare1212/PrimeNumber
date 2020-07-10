package jp.kokarare1212.primenumber;

public class Main {

    public static void main(String[] args) {
	    for(int i = 2; i <= 10000000; i++){
	        int k = (int)Math.sqrt(i);
	        boolean f = true;
	        for(int j = 2; j <= k; j++){
	            if(i % j == 0){
	                f = false;
	                break;
                }
            }
	        if(f){
	            System.out.println(i);
            }
        }
    }
}
