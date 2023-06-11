#include <iostream>
#include <stdexcept>
#include <cmath>

class Triangle {
private:
    double a, b, c;

public:
    // Конструктор класса
    Triangle(double a, double b, double c) {
        // Проверяем условие существования треугольника
        if (a >= b + c || b >= a + c || c >= a + b)
            throw std::invalid_argument("Such a triangle does not exist.");

        this->a = a;
        this->b = b;
        this->c = c;
    }

    // Функция для вычисления площади треугольника
    double area() const {
        double p = (a + b + c) / 2;
        return sqrt(p * (p - a) * (p - b) * (p - c));
    }
};

int main() {
    try {
        Triangle t(3, 4, 5);
        std::cout << "Area: " << t.area() << std::endl;
    }
    catch (std::invalid_argument& e) {
        std::cerr << "Error: " << e.what() << std::endl;
    }

    return 0;
}
