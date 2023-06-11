#include <iostream>
#include <stdexcept>

class Time {
private:
    int hours;
    int minutes;
    int seconds;

public:
    // Конструктор класса
    Time(int hours, int minutes, int seconds) {
        if(hours < 0 || hours > 23 || minutes < 0 || minutes > 59 || seconds < 0 || seconds > 59) {
            throw std::invalid_argument("Invalid time value");
        }
        this->hours = hours;
        this->minutes = minutes;
        this->seconds = seconds;
    }

    // Вывод значения времени на экран
    void displayTime() const {
        std::cout << hours << ":" << minutes << ":" << seconds << std::endl;
    }

    // Сложение времени
    Time add(const Time& t) const {
        int s = seconds + t.seconds;
        int m = minutes + t.minutes;
        int h = hours + t.hours;

        if(s > 59) {
            s -= 60;
            m++;
        }

        if(m > 59) {
            m -= 60;
            h++;
        }

        if(h > 23) {
            h -= 24;
        }

        return Time(h, m, s);
    }
};

int main() {
    try {
        Time t1(10, 40, 30);
        Time t2(15, 20, 40);
        Time t3 = t1.add(t2);

        t3.displayTime();
    }
    catch (std::invalid_argument& e) {
        std::cerr << "Error: " << e.what() << std::endl;
    }

    return 0;
}
