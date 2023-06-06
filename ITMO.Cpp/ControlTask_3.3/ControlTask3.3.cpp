#include <iostream>
#include <cmath>
using namespace std;

// Функция для вычисления площади равностороннего треугольника
double triangle_area(double a) {
    return sqrt(3) / 4 * a * a;
}

// Функция для вычисления площади разностороннего треугольника
double triangle_area(double a, double b, double c) {
    double s = (a + b + c) / 2;
    return sqrt(s * (s - a) * (s - b) * (s - c));
}

int main() {
    int choice;
    cout << "Выберите тип треугольника (1 - равносторонний, 2 - разносторонний): ";
    cin >> choice;

    if(choice == 1) {
        double a;
        cout << "Введите сторону равностороннего треугольника: ";
        cin >> a;

        cout << "Площадь равностороннего треугольника: " << triangle_area(a) << endl;
    }
    else if(choice == 2) {
        double a, b, c;
        cout << "Введите стороны разностороннего треугольника: ";
        cin >> a >> b >> c;

        cout << "Площадь разностороннего треугольника: " << triangle_area(a, b, c) << endl;
    }
    else {
        cout << "Неправильный выбор!" << endl;
    }

    return 0;
}
