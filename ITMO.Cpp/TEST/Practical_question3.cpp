//Дан класс Point: 

//class Point{ 
//int x,y; 
//… 
//}; 
//Обеспечьте выполнение: 
//{ 
//Point pt1(1,1) pt2(2,2), pt3; 
//pt3 = pt1 + pt2; 
//pt2 +=pt1; 
//pt3 = pt1 + 5;
//… 
//} 




#include <iostream>

class Point {
    int x, y;

public:
    // Конструктор
    Point(int _x = 0, int _y = 0) : x(_x), y(_y) {}

    // Оператор сложения с другой точкой
    Point operator+(const Point& p) {
        return Point(x + p.x, y + p.y);
    }

    // Оператор сложения с числом
    Point operator+(int i) {
        return Point(x + i, y + i);
    }

    // Оператор сложения с присваиванием для точки
    Point& operator+=(const Point& p) {
        x += p.x;
        y += p.y;
        return *this;
    }

    // Оператор сложения с присваиванием для числа
    Point& operator+=(int i) {
        x += i;
        y += i;
        return *this;
    }

    // Для проверки
    void print() {
        std::cout << "Point(" << x << ", " << y << ")" << std::endl;
    }
};

int main() {
    Point pt1(1,1), pt2(2,2), pt3;

    pt3 = pt1 + pt2;
    pt3.print();  // Выводит "Point(3, 3)"

    pt2 += pt1;
    pt2.print();  // Выводит "Point(3, 3)"

    pt3 = pt1 + 5;
    pt3.print();  // Выводит "Point(6, 6)"

    return 0;
}
