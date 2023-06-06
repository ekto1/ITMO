#include <iostream>
#include <cmath>
using namespace std;

int main() {
    double x, y;
    int totalScore = 0;
    int shots = 0;

    while (totalScore < 50) {
        cout << "Введите координаты выстрела (x y): ";
        cin >> x >> y;

        double distance = sqrt(x*x + y*y);
        if (distance <= 1) totalScore += 10;
        else if (distance <= 2) totalScore += 5;
        
        shots++;
    }

    cout << "Число выполненных выстрелов: " << shots << endl;

    if (totalScore / shots >= 10) {
        cout << "Ваш уровень: Снайпер" << endl;
    } else if (totalScore / shots >= 5) {
        cout << "Ваш уровень: Просто стрелок" << endl;
    } else {
        cout << "Ваш уровень: Новичок" << endl;
    }

    return 0;
}
