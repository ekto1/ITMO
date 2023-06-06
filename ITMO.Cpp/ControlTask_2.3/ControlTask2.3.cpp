#include <iostream>
#include <iomanip>
using namespace std;

void change(double amount) {
    double coins[] = {10, 5, 2, 1, 0.5, 0.1, 0.05, 0.01};
    int count[8] = {0};
    const double EPSILON = 1E-9;

    cout << fixed << setprecision(2);

    for (int i = 0; i < 8; i++) {
        while (amount + EPSILON >= coins[i]) {
            amount -= coins[i];
            count[i]++;
        }
    }

    cout << "Набор монет для сдачи: " << endl;
    for (int i = 0; i < 8; i++) {
        if (count[i] > 0) {
            cout << coins[i] << ": " << count[i] << endl;
        }
    }
}

int main() {
    double amount;
    cout << "Введите сумму для размена (используйте точку для разделения рублей и копеек): ";
    cin >> amount;

    change(amount);

    return 0;
}
