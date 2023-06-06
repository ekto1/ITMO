#include <iostream>
using namespace std;

// Все функции будут использовать целые числа (int), поскольку мы работаем с простыми числами, и это обычно целые положительные числа.

bool is_prime(int n) {
    if (n <= 1) {
        return false;
    }
    for (int i = 2; i * i <= n; i++) {
        if (n % i == 0) {
            return false;
        }
    }
    return true;
}

int prime_count(int n) {
    int count = 0;
    for (int i = 2; i <= n; i++) {
        if (is_prime(i)) {
            count++;
        }
    }
    return count;
}

bool is_super_prime(int n) {
    return is_prime(n) && is_prime(prime_count(n));
}

int main() {
    int n;
    cout << "Введите число: ";
    cin >> n;

    if (is_super_prime(n)) {
        cout << n << " является суперпростым числом." << endl;
    } else {
        cout << n << " не является суперпростым числом." << endl;
    }

    return 0;
}
