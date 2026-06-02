#include <iostream>
#include <vector>
int main() {
    std::vector<int> v(10);
    std::cout << "Insira os 10 numeros:" << std::endl;
 for (int i = 0; i < v.size(); i++)
 {
 std:: cout << "Numero " << i + 1 << ": ";
 std::cin >> v[i];
 }
        std::cout <<"Numeros pares" << std::endl;

    for (int i = 0; i < v.size(); i++) {
        int element = v[i];
        if (element % 2 == 0) {
            std::cout << element << " ";
        }
    }
    std::cout << std::endl;
    std::cout <<"Numeros impares" << std::endl;
     for (int i = 0; i < v.size(); i++) { 
         int element = v[i];
        if (element % 2 != 0) {
            std::cout << element << " ";
        }
    }
    std::cout << std::endl;
    return 0;
}