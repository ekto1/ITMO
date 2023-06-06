#include <iostream>
#include <cmath>
using namespace std;

double cube_root_pow(double a) {
    return pow(a, 1.0/3);
}

double cube_root_iter(double a) {
    double x = a;
    double x_prev = a;
    double epsilon = 1e-6;

    do {
        x_prev = x;
        x = (1.0/3) * (a/(x_prev*x_prev) + 2*x_prev);
    } while(abs(x - x_prev) > epsilon);

    return x;
}

int main() {
    double a;
    cout << "Введите число: ";
    cin >> a;

    cout << "Кубический корень числа " << a << " с использованием pow(): " << cube_root_pow(a) << endl;
    cout << "Кубический корень числа " << a << " с использованием итерации: " << cube_root_iter(a) << endl;

    return 0;
}
