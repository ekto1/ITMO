#include <iostream>
#include <vector>

// Определение структуры Point для хранения координат
struct Point {
    double x, y;

    Point(double x = 0, double y = 0) : x(x), y(y) {}
};

// Функция для вычисления площади многоугольника
double computeArea(std::vector<Point>& points) {
    double area = 0;
    int n = points.size();
    for(int i = 0; i < n; i++) {
        int j = (i + 1) % n;
        area += points[i].x * points[j].y - points[j].x * points[i].y;
    }
    return std::abs(area) / 2.0;
}

int main() {
    std::vector<Point> points(5);
    std::cout << "Введите координаты 5 вершин пятиугольника (формат: x y):\n";
    for(int i = 0; i < 5; i++) {
        std::cin >> points[i].x >> points[i].y;
    }
    double area = computeArea(points);
    std::cout << "Площадь пятиугольника: " << area << std::endl;

    return 0;
}
