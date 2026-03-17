#include <iostream>
#include <iomanip>
using namespace std;
int main(){
     double pi= 3.14159;
    cout <<"Digite o valor do raio: ";
    double raio;    cin >> raio;
    double area = pi * raio * raio;
    cout <<fixed<<setprecision(4) << "A area do circulo e: " << area << endl;
}








