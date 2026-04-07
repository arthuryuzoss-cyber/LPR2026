#include <iostream>
int main() {
    int numero;
    int media = 0;
    int contador = 0;
    int conta=0;
    int i=0;
    std::cout << "Digite a quantidade de vezes que voce vai digitar:" << std::endl;
    std::cin >> conta;
    while (i < conta)
    {     
        /* code */
        i++;
     if (contador > conta) {
        break;
     }    
     (i < contador, i++); {
        std::cout << "Digite um numero inteiro:" << std::endl;
        std::cin >> numero;
        media += numero;
        contador++;
    }
    if (contador > conta) {
        break;
    }
    if (contador > 0) {
        media /= contador;
        std::cout << "A média é: " << media << std::endl;
    } else {
        std::cout << "Nenhum número foi digitado." << std::endl;
    }
    return 0;

}
