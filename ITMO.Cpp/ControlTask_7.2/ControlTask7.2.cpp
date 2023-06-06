#include <iostream>
#include <cmath>

struct QuadraticSolution {
    double root1;
    double root2;
    int numberOfRoots;
};

QuadraticSolution solveQuadratic(double a, double b, double c) {
    QuadraticSolution solution;

    if (a == 0.0) {
        if (b != 0.0) {
            solution.root1 = -c / b;
            solution.numberOfRoots = 1;
        } else {
            solution.numberOfRoots = 0;
        }
        return solution;
    }

    double discriminant = b * b - 4 * a * c;

    if (discriminant > 0.0) {
        solution.root1 = (-b + sqrt(discriminant)) / (2 * a);
        solution.root2 = (-b - sqrt(discriminant)) / (2 * a);
        solution.numberOfRoots = 2;
    } else if (discriminant == 0.0) {
        solution.root1 = -b / (2 * a);
        solution.numberOfRoots = 1;
    } else {
        solution.numberOfRoots = 0;
    }

    return solution;
}

int main() {
    double a, b, c;
    std::cout << "Введите коэффициенты квадратного уравнения a, b, c: ";
    std::cin >> a >> b >> c;

    QuadraticSolution solution = solveQuadratic(a, b, c);

    switch (solution.numberOfRoots) {
    case 2:
        std::cout << "Решения квадратного уравнения: " << solution.root1 << ", " << solution.root2 << "\n";
        break;
    case 1:
        std::cout << "Решение квадратного уравнения: " << solution.root1 << "\n";
        break;
    case 0:
        std::cout << "Квадратное уравнение не имеет решений\n";
        break;
    default:
        std::cout << "Ошибка при вычислении корней\n";
    }

    return 0;
}
