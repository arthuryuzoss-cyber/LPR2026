#include <iostream>

using namespace std;

int main() {
    long long numero, quadrado;
    int somaDigitos = 0;

    cout << "Digite um numero: ";
    cin >> numero;

    quadrado = numero * numero;
    cout << "Quadrado: " << quadrado << endl;

    long long temp = quadrado;
    
    if (temp < 0) {
        temp = -temp;
    }

    while (temp > 0) {
        somaDigitos += temp % 10;
        temp /= 10;
    }

    cout << "Soma dos digitos: " << somaDigitos << endl;

    return 0;
}