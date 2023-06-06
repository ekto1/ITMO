#include <iostream>
#include <cmath>
#include <tuple>

std::tuple<int, double, double> solveQuadratic(double a, double b, double c) {
    if (a == 0.0) {
        if (b != 0.0) {
            return std::make_tuple(1, -c / b, 0);
        } else {
            return std::make_tuple(0, 0, 0);
        }
    }

    double discriminant = b * b - 4 * a * c;

    if (discriminant > 0.0) {
        return std::make_tuple(2, (-b + sqrt(discriminant)) / (2 * a), (-b - sqrt(discriminant)) / (2 * a));
    } else if (discriminant == 0.0) {
        return std::make_tuple(1, -b / (2 * a), 0);
    } else {
        return std::make_tuple(0, 0, 0);
    }
}

int main() {
    double a, b, c;
    std::cout << "Введите коэффициенты квадратного уравнения a, b, c: ";
    std::cin >> a >> b >> c;

    auto solution = solveQuadratic(a, b, c);

    switch (std::get<0>(solution)) {
    case 2:
        std::cout << "Решения квадратного уравнения: " << std::get<1>(solution) << ", " << std::get<2>(solution) << "\n";
        break;
    case 1:
        std::cout << "Решение квадратного уравнения: " << std::get<1>(solution) << "\n";
        break;
    case 0:
        std::cout << "Квадратное уравнение не имеет решений\n";
        break;
    default:
        std::cout << "Ошибка при вычислении корней\n";
    }

    return 0;
}
