#include <iostream>
using namespace std;

bool Input(int &a, int &b) {
    cout << "Введите два целых числа: ";
    cin >> a >> b;

    // Проверяем корректность ввода
    if(cin.fail()) {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        return false;
    }
    return true;
}

int main() {
    int a, b;
    if(!Input(a, b)) {
        cerr << "Ошибка ввода" << endl;
        return 1;
    }
    int s = a + b;
    cout << "Сумма чисел: " << s << endl;
    return 0;
}
