#include <iostream>
int main(){
    std::cout << "Digite um numero inteiro:" << std::endl;
    int numero;
    std::cin >> numero;
    int reverso = 0;
    int reservo();
    while (numero != 0) {
        reverso = reverso * 10 + numero % 10;
        numero /= 10;
    }
    std::cout << "O reverso do numero é: " << reverso << std::endl;
    return 0;

}