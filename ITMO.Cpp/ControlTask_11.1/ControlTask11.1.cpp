#include <iostream>
#include <stdexcept>

class Time {
private:
    int hours;
    int minutes;
    int seconds;

public:
    Time() : hours(0), minutes(0), seconds(0) {}
    Time(int h, int m, int s) : hours(h), minutes(m), seconds(s) {}

    void displayTime() {
        std::cout << hours << ":" << minutes << ":" << seconds << "\n";
    }

    Time operator +(const Time& t) {
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
        return Time(h, m, s);
    }

    Time operator -(const Time& t) {
        int s = seconds - t.seconds;
        int m = minutes - t.minutes;
        int h = hours - t.hours;
        if(s < 0) {
            s += 60;
            m--;
        }
        if(m < 0) {
            m += 60;
            h--;
        }
        if(h < 0) {
            throw std::invalid_argument("Результат некорректен!");
        }
        return Time(h, m, s);
    }

    Time operator +(double timeInHours) {
        Time t((int)timeInHours, (int)((timeInHours - (int)timeInHours) * 60), 0);
        return *this + t;
    }

    friend Time operator +(double timeInHours, Time& t) {
        return t + timeInHours;
    }

    bool operator ==(const Time& t) {
        return (hours == t.hours && minutes == t.minutes && seconds == t.seconds);
    }

    bool operator !=(const Time& t) {
        return !(*this == t);
    }
};

int main() {
    Time t1(1, 30, 0);
    Time t2(2, 45, 0);
    Time t3 = t1 + t2;
    t3.displayTime();  // Должно показать 4:15:00
    try {
        Time t4 = t1 - t2;
        t4.displayTime();  // Необходима обработка, если t1 меньше t2
    }
    catch (const std::invalid_argument& e) {
        std::cerr << e.what() << '\n';
    }
    Time t5 = t1 + 1.5; // Добавляем 1.5 часа
    t5.displayTime();
    Time t6 = 1.5 + t1; // Добавляем 1.5 часа
    t6.displayTime();
    if (t1 == t2)
        std::cout << "t1 и t2 равны\n";
    else
        std::cout << "t1 и t2 не равны\n";
    return 0;
}
