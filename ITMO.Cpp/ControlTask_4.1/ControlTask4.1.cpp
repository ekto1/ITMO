#include <iostream>
#include <cmath>
using namespace std;

int Myroot(double a, double b, double c, double &x1, double &x2) {
    double discriminant = b * b - 4 * a * c;
    if (discriminant < 0) {
        return -1;
    } else if (discriminant == 0) {
        x1 = x2 = -b / (2 * a);
        return 0;
    } else {
        x1 = (-b + sqrt(discriminant)) / (2 * a);
        x2 = (-b - sqrt(discriminant)) / (2 * a);
        return 1;
    }
}

int main() {
    double a, b, c, x1, x2;
    cout << "Введите коэффициенты a, b и c: ";
    cin >> a >> b >> c;

    int result = Myroot(a, b, c, x1, x2);
    if (result == -1) {
        cout << "Корней уравнения нет" << endl;
    } else if (result == 0) {
        cout << "Корень уравнения один x1 = x2 = " << x1 << endl;
    } else {
        cout << "Корни уравнения x1 = " << x1 << ", x2 = " << x2 << endl;
    }

    return 0;
}
