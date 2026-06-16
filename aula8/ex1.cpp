#include <iostream>
#include <array>
using namespace std;
struct Filme{
    string titulo;
    string diretor;
    int anoLancamento;
    int DuracaoMinutos;
};
int main() {
     Filme f[3];
     for (int i = 0; i < 3; i++) {
     cout<< "Filme " << i + 1 << ":" << endl;
     cout <<"Digite o titulo do filme: "<<endl;
     cin>> f[i].titulo;
     cout <<"Digite o diretor do filme: "<<endl;
     cin>> f[i].diretor;
     cout <<"Digite o ano de lancamento: "<<endl;
     cin>> f[i].anoLancamento;
     cout <<"Digite a duracao do filme em minutos: "<<endl;
     cin>> f[i].DuracaoMinutos;
     }

     // mais antigo = 0;
     // para cada filme, se ano maior que mais antigo, mais antigo = i
     // mostrar filme[maisantigo  ]

     // vetor filme
     // 0                1
     // struct filme 1 1990  struct filme 2 2002
     int indice_maisantigo = -1;
     int ano_maisantigo = 9999;
     for (int i = 0; i < 3; i++) {
        if (f[i].anoLancamento < ano_maisantigo) {
            ano_maisantigo = f[i].anoLancamento;
            indice_maisantigo = i;
        }
     }
     cout << "O filme mais antigo e: " << f[indice_maisantigo].titulo << " dirigido por " << f[indice_maisantigo].diretor << " lancado em " << f[indice_maisantigo].anoLancamento << " com duracao de " << f[indice_maisantigo].DuracaoMinutos << " minutos." << endl;
}