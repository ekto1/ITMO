#include <iostream>
#include <fstream>

const int N = 10;

int main() {
    int a[N] = { 1, 25, 6, 32, 43, 5, 96, 23, 4, 55 };
    int min = 0;
    int buf = 0;
    
    std::ofstream file("arrays.txt");
    if (!file.is_open()) {
        std::cerr << "Не удалось открыть файл для записи.\n";
        return 1;
    }

    // Запись исходного массива в файл
    file << "Исходный массив: ";
    for (int i = 0; i < N; i++) {
        file << a[i] << " ";
    }
    file << "\n";

    // Сортировка массива
    for (int i = 0; i < N; i++) {
        min = i;
        for (int j = i + 1; j < N; j++) {
            min = (a[j] < a[min]) ? j : min;
        }
        if (i != min) {
            buf = a[i];
            a[i] = a[min];
            a[min] = buf;
        }
    }

    // Запись отсортированного массива в файл
    file << "Отсортированный массив: ";
    for (int i = 0; i < N; i++) {
        file << a[i] << " ";
    }
    file << "\n";

    file.close();
    std::cout << "Массивы успешно записаны в файл 'arrays.txt'.\n";

    return 0;
}
