#include <iostream>

using namespace std;

// Функция для обработки данных массива
void processData(int arr[], int n) {
    int sum = 0;
    for(int i=0; i<n; i++) {
        sum += arr[i];
    }
    cout << "Сумма элементов массива: " << sum << endl;
}

// Функция для сортировки массива
void sortArray(int arr[], int n) {
    int minIndex = 0;
    int temp = 0;
    for (int i = 0; i < n-1; i++) {
        minIndex = i;
        for (int j = i+1; j < n; j++) {
            if (arr[j] < arr[minIndex]) {
                minIndex = j;
            }
        }
        temp = arr[minIndex];
        arr[minIndex] = arr[i];
        arr[i] = temp;
    }
}

int main() {
    const int N = 10;
    int a[N] = {1, 25, 6, 32, 43, 5, 96, 23, 4, 55};

    processData(a, N);

    sortArray(a, N);

    cout << "Отсортированный массив: ";
    for (int i=0; i<N; i++) {
        cout << a[i] << " ";
    }
    cout << endl;

    return 0;
}
