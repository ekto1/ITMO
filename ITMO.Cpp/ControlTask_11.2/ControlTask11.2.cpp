#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class Point {
private:
    double x;
    double y;

public:
    Point(double x = 0.0, double y = 0.0) : x(x), y(y) {}

    double distance() const {
        return std::sqrt(x * x + y * y);
    }

    friend bool operator < (const Point& a, const Point& b) {
        return a.distance() < b.distance();
    }

    friend std::ostream& operator << (std::ostream& out, const Point& p) {
        out << "(" << p.x << ", " << p.y << ")";
        return out;
    }
};

int main() {
    std::vector<Point> v;
    v.push_back(Point(1,2));
    v.push_back(Point(10,12));
    v.push_back(Point(21,7));
    v.push_back(Point(4,8));

    std::sort(v.begin(), v.end());

    for (auto &point : v)
        std::cout << point << '\n'; 

    return 0; 
}
