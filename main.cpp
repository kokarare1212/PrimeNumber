#include <iostream>

int main() {
    for(int i = 2; i <= 10000000; i++){
        int k = (int)sqrt(i);
        bool f = true;
        for(int j = 2; j <= k; j++){
            if(i % j == 0){
                f = false;
            }
        }
        if(f){
            std::cout << i << std::endl;
        }
    }
    return 0;
}
