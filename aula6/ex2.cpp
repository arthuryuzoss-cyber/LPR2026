#include <iostream>
using namespace std;
int funcao1();
int funcao2();
int funcao3();
int main(){
    int numero;
    cout<<"Digite qual funcao voce deseja utilizar\n 1-Funcao para saber uma media\n 2-Funcao para descobrir a qnt de numeros impares e multiplos de 3 entre 50 e 500\n 3-Funcao para saber a soma dos digitos do quadrado\n ";
    cin >> numero;
if (numero==1){
    funcao1();
}
if (numero==2){
      funcao2();
    }
    if (numero==3){
        funcao3();
    }
    else {
        cout<<"nenhuma das opcoes solicitadas tente novamente";
    }
}

int funcao1(){
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
        i++; // Incremento simples para o loop funcionar
    }

    if (contador > 0) {
        media /= contador;
        std::cout << "A média é: " << media << std::endl;
    } else {
        std::cout << "Nenhum número foi digitado." << std::endl;
    }
    return 0;

}
int funcao2(){
     int contagem = 0;
        
        for (int i=50;  i <= 500; i ++) 
        {
            if (i % 3 == 0 && i % 2 != 0)
            {

                contagem++;
            }
        }
        cout<<"a quantidade de numeros impares e multiplos de 3 sao "<< contagem;
}
int funcao3(){
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