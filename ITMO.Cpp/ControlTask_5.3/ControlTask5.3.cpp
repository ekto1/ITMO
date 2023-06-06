#include <iostream>
using namespace std;

int* transpositionSearch(int* arr, int size, int key) {
    for(int i = 0; i < size; ++i) {
        if (arr[i] == key) {
            if (i > 0) { // Если это не первый элемент, меняем местами с предыдущим
                swap(arr[i], arr[i - 1]);
            }
            return &arr[i - 1]; // Возвращаем указатель на новое местоположение ключа
        }
    }
    return nullptr; // Возвращаем nullptr, если ключ не был найден
}

int main() {
    int arr[] = {1, 2, 3, 4, 5};
    int size = sizeof(arr) / sizeof(arr[0]);
    int key = 3;

    int* keyPtr = transpositionSearch(arr, size, key);

    if (keyPtr != nullptr) {
        cout << "Key found at index " << (keyPtr - arr) << endl;
    } else {
        cout << "Key not found in the array." << endl;
    }

    for (int i = 0; i < size; ++i) {
        cout << arr[i] << ' ';
    }

    return 0;
}

