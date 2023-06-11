//Создайте класс “A”, инкапсулирующий динамический массив. 
//Введите в класс необходимые на Ваш взгляд данные и методы, чтобы приведенный ниже код выполнялся: 

//{ 
//A a1; 
//A a2(10); //10 – размер массива 
//A a3 = a2; 
//a1 = a3; 
//a2 = A(20); 
//const A a4(5); 
//for(int i=0; i<a2.size(); i++) 
//{ 
//cout<<a4[i]; 
//} 
//} 





#include<iostream>
class A {
    int* arr;
    int len;
public:
    // Конструктор по умолчанию
    A() : len(0), arr(nullptr) {}

    // Конструктор с параметром
    A(int size) : len(size) {
        arr = new int[len]{0}; // инициализация нулями
    }

    // Конструктор копирования
    A(const A& a) : len(a.len) {
        arr = new int[len];
        for (int i = 0; i < len; ++i) {
            arr[i] = a.arr[i];
        }
    }

    // Оператор присваивания
    A& operator=(const A& a) {
        if (&a == this) {
            return *this;
        }

        delete[] arr;
        len = a.len;
        arr = new int[len];
        for (int i = 0; i < len; ++i) {
            arr[i] = a.arr[i];
        }

        return *this;
    }

    // Оператор присваивания с переносом
    A& operator=(A&& a) noexcept {
        if (&a == this) {
            return *this;
        }

        delete[] arr;
        len = a.len;
        arr = a.arr;
        a.len = 0;
        a.arr = nullptr;

        return *this;
    }

    // Оператор индексирования
    int operator[](int i) const {
        if (i >= 0 && i < len) {
            return arr[i];
        }
        else {
            std::cout << "Index out of bounds!\n";
            return -1;
        }
    }

    // Размер
    int size() const {
        return len;
    }

    // Деструктор
    ~A() {
        delete[] arr;
    }
};

int main() {
    A a1;
    A a2(10); //10 – размер массива
    A a3 = a2;
    a1 = a3;
    a2 = A(20);
    const A a4(5);
    for(int i=0; i<a2.size(); i++) {
        std::cout << a4[i] << ' ';
    }
    return 0;
}
