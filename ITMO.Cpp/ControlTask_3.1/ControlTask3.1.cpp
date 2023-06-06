#include <iostream>
#include <string>
#include <cctype>
using namespace std;

bool isValidSnils(string snils) {
    string digitsOnly = "";
    for (char c : snils) {
        if (isdigit(c)) digitsOnly += c;
        else if (c != ' ' && c != '-') return false;
    }

    if (digitsOnly.size() != 11) return false;

    int sum = 0;
    for (int i = 0; i < 9; ++i) {
        sum += (digitsOnly[i] - '0') * (9 - i);
    }

    int controlNumber = (digitsOnly[9] - '0') * 10 + (digitsOnly[10] - '0');

    if (sum < 100) {
        if (sum != controlNumber) return false;
    } else if (sum == 100 || sum == 101) {
        if (controlNumber != 0) return false;
    } else {
        if (sum % 101 != controlNumber && sum % 101 != 100) return false;
    }

    return true;
}

int main() {
    string snils;
    cout << "Введите номер СНИЛС: ";
    getline(cin, snils);

    if (isValidSnils(snils)) {
        cout << "Номер СНИЛС валидный." << endl;
    } else {
        cout << "Номер СНИЛС невалидный." << endl;
    }

    return 0;
}
