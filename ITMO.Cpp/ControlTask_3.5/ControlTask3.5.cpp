#include <iostream>
using namespace std;

// Рекурсивная функция перевода числа в двоичное представление
void toBinary(int n) {
    if (n > 0) {
        toBinary(n / 2);
        cout << n % 2;
    }
}

int main() {
    int n;
    cout << "Введите целое число: ";
    cin >> n;
    if (n < 0) {
        cout << "Ошибка: число должно быть положительным!" << endl;
    } else {
        cout << "Двоичное представление: ";
        toBinary(n);
        cout << endl;
    }

    return 0;
}
