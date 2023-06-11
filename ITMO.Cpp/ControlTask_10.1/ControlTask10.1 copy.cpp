#include "dot.h"
#include <math.h>

// Версия с агрегацией
class Triangle {
private:
    Dot *point1;
    Dot *point2;
    Dot *point3;
public:
    Triangle(Dot *p1, Dot *p2, Dot *p3) : point1(p1), point2(p2), point3(p3) {}

    double perimeter() {
        return point1->distanceTo(*point2) + point2->distanceTo(*point3) + point3->distanceTo(*point1);
    }

    double area() {
        double a = point1->distanceTo(*point2);
        double b = point2->distanceTo(*point3);
        double c = point3->distanceTo(*point1);
        double s = (a + b + c) / 2.0;
        return sqrt(s * (s - a) * (s - b) * (s - c));
    }
};

