#include <iostream>

using namespace std;

int main() {
    double horasPorDia;
    double totalSemana = 0;
    const int horasObjetivo = 1000;

    cout << "Insira o numero de horas de treinamento por dia: ";
    cin >> horasPorDia;

    for (int i = 0; i < 5; i++) {
        totalSemana += horasPorDia;
    }

    double totalDias = horasObjetivo / horasPorDia;
    double totalSemanas = horasObjetivo / totalSemana;
    double totalMeses = totalSemanas / 4.5;

    cout << "Total na semana: " << totalSemana << "h" << endl;
    cout << "Dias necessarios: " << totalDias << endl;
    cout << "Semanas necessarias: " << totalSemanas << endl;
    cout << "Meses necessarios: " << totalMeses << endl;

    return 0;
}