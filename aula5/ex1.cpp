#include <iostream>
int main() {
   int numero1;
    int media = 0;
    int contador = 0;
    int conta=0;
    int i=0;
    std::cout << "Digite a quantidade de vezes que voce vai digitar:" << std::endl;
    std::cin >> conta;

    while (i < conta)
    {        
        std::cout << "Digite um numero inteiro:" << std::endl;
        std::cin >> numero1;
        media += numero1;
        contador++;
        i++;
    }

    if (contador > 0) {
        media /= contador;
        std::cout << "A média é: " << media << std::endl;
    } else {
        std::cout << "Nenhum número foi digitado." << std::endl;
    }
    return 0;
}
