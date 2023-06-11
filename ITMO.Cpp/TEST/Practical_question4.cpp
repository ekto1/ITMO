//Напишите класс, который реализует функционал стека. Класс Stack должен иметь:
//Открытый целочисленный фиксированный массив длиной 10.
//Открытое целочисленное значение для отслеживания длины стека.
//Открытый метод с именем reset(), который будет сбрасывать длину и все значения элементов на 0.
//Открытый метод с именем push(), который будет добавлять значение в стек. Метод push() должен возвращать значение false, если массив уже заполнен, в противном случае — true.
//Открытый метод с именем pop() для возврата значений из стека. Если в стеке нет значений, то должно выводиться предупреждающее сообщение.
//Открытый метод с именем print(), который будет выводить все значения стека.

#include<iostream>

class Stack {
public:
    static const int max_length = 10;
    int arr[max_length];
    int length;

    // Инициализация стека
    void reset() {
        length = 0;
        for(int i = 0; i < max_length; ++i) {
            arr[i] = 0;
        }
    }

    // Добавление элемента в стек
    bool push(int value) {
        if(length == max_length) {
            return false;
        }
        else {
            arr[length++] = value;
            return true;
        }
    }

    // Удаление элемента из стека
    bool pop() {
        if(length == 0) {
            std::cout << "Stack is empty\n";
            return false;
        }
        else {
            --length;
            return true;
        }
    }

    // Вывод содержимого стека
    void print() {
        std::cout << "( ";
        for(int i = 0; i < length; ++i) {
            std::cout << arr[i] << ' ';
        }
        std::cout << ")\n";
    }
};

int main() {
    Stack stack;
    stack.reset();
    stack.print();

    stack.push(3);
    stack.push(7);
    stack.push(5);
    stack.print();

    stack.pop();
    stack.print();

    stack.pop();
    stack.pop();
    stack.print();

    return 0;
}
