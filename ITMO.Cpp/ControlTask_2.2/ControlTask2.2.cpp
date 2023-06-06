#include <iostream>
#include <string>
using namespace std;

bool is_valid_snils(string snils) {
    if (snils.length() != 11) {
        return false;
    }

    for (int i = 0; i < 8; i++) {
        if (snils[i] == snils[i+1] && snils[i+1] == snils[i+2]) {
            return false;
        }
    }

    int check_number = stoi(snils.substr(9, 2));
    int sum = 0;
    for (int i = 0; i < 9; i++) {
        sum += (snils[i] - '0') * (9 - i);
    }

    if (sum < 100) {
        return sum == check_number;
    } else if (sum == 100 || sum == 101) {
        return check_number == 0;
    } else {
        return sum % 101 % 100 == check_number;
    }
}

int main() {
    string snils;
    cout << "Введите номер СНИЛС (без пробелов и дефисов): ";
    cin >> snils;

    if (is_valid_snils(snils)) {
        cout << "СНИЛС валидный." << endl;
    } else {
        cout << "СНИЛС не валидный." << endl;
    }

    return 0;
}
