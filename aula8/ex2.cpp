#include <iostream>
#include <array>
using namespace std;
struct Produto{
    string nome;
    int codigo;
    double preco;
    int quantidade;
};
int main(){
    Produto p[3];
for (int i = 0; i < 3; i++) {
     cout<< "Produto " << i + 1 << ":" << endl;
     cout <<"Digite o nome do produto: "<<endl;
     cin>> p[i].nome;
     cout <<"Digite o codigo do produto: "<<endl;
     cin>> p[i].codigo;
     cout <<"Digite o preco do produto: "<<endl;
     cin>> p[i] .preco;
     cout <<"Digite a quantidade do produto: "<<endl;
     cin>> p[i].quantidade;
    }
    double valor_total = (p[0].preco * p[0].quantidade)+ (p[1].preco * p[1].quantidade)+ (p[2].preco * p[2].quantidade);
    cout << "O valor total do estoque e: " << valor_total << endl;
}