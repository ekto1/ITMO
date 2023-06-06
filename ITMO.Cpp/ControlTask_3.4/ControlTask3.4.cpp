#include <iostream>
using namespace std;

// Рекурсивная функция для вычисления суммы ряда
int sumSeries(int n) {
    if (n == 0) {
        return 0;
    }
    else {
        return 5 * n + sumSeries(n - 1);
    }
}

int main() {
    int n;
    cout << "Введите значение n: ";
    cin >> n;
    cout << "Сумма ряда: " << sumSeries(n) << endl;

    return 0;
}
