#include "dot.h"
#include <math.h>

// Версия с композицией
class Triangle {
private:
    Dot point1;
    Dot point2;
    Dot point3;
public:
    Triangle(double x1, double y1, double x2, double y2, double x3, double y3) : 
    point1(x1, y1), point2(x2, y2), point3(x3, y3) {}

    double perimeter() {
        return point1.distanceTo(point2) + point2.distanceTo(point3) + point3.distanceTo(point1);
    }

    double area() {
        double a = point1.distanceTo(point2);
        double b = point2.distanceTo(point3);
        double c = point3.distanceTo(point1);
        double s = (a + b + c) / 2.0;
        return sqrt(s * (s - a) * (s - b) * (s - c));
    }
};

