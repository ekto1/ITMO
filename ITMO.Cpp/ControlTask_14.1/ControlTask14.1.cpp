#include <iostream>

template <typename T>
double average(T* arr, int size) {
    double sum = 0.0;
    for(int i = 0; i < size; ++i) {
        sum += arr[i];
    }
    return sum / size;
}

int main() {
    int arr1[] = {1, 2, 3, 4, 5};
    long arr2[] = {1L, 2L, 3L, 4L, 5L};
    double arr3[] = {1.1, 2.2, 3.3, 4.4, 5.5};
    char arr4[] = {1, 2, 3, 4, 5};

    std::cout << "Среднее арифметическое массива int: " << average(arr1, 5) << std::endl;
    std::cout << "Среднее арифметическое массива long: " << average(arr2, 5) << std::endl;
    std::cout << "Среднее арифметическое массива double: " << average(arr3, 5) << std::endl;
    std::cout << "Среднее арифметическое массива char: " << average(arr4, 5) << std::endl;

    return 0;
}
