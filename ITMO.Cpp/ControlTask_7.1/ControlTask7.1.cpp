#include <iostream>

struct Time {
    int hours;
    int minutes;
    int seconds;

    bool isValid() {
        return hours >= 0 && hours < 24 && minutes >= 0 && minutes < 60 && seconds >= 0 && seconds < 60;
    }

    int totalSeconds() {
        return hours * 3600 + minutes * 60 + seconds;
    }

    Time addTime(Time t) {
        Time result;
        result.seconds = (seconds + t.seconds) % 60;
        result.minutes = (minutes + t.minutes + (seconds + t.seconds) / 60) % 60;
        result.hours = (hours + t.hours + (minutes + t.minutes + (seconds + t.seconds) / 60) / 60) % 24;
        return result;
    }

    Time subtractTime(Time t) {
        Time result;
        int totalSeconds1 = totalSeconds();
        int totalSeconds2 = t.totalSeconds();

        if (totalSeconds1 < totalSeconds2) {
            std::swap(totalSeconds1, totalSeconds2);
        }

        int diffSeconds = totalSeconds1 - totalSeconds2;
        result.hours = diffSeconds / 3600;
        diffSeconds %= 3600;
        result.minutes = diffSeconds / 60;
        result.seconds = diffSeconds % 60;

        return result;
    }
};

int main() {
    Time t1, t2;

    std::cout << "Введите первое время (часы минуты секунды): ";
    std::cin >> t1.hours >> t1.minutes >> t1.seconds;
    if (!t1.isValid()) {
        std::cout << "Некорректные данные для первого времени!\n";
        return 1;
    }

    std::cout << "Введите второе время (часы минуты секунды): ";
    std::cin >> t2.hours >> t2.minutes >> t2.seconds;
    if (!t2.isValid()) {
        std::cout << "Некорректные данные для второго времени!\n";
        return 1;
    }

    std::cout << "Первое время в секундах: " << t1.totalSeconds() << "\n";
    std::cout << "Второе время в секундах: " << t2.totalSeconds() << "\n";

    Time t3 = t1.addTime(t2);
    std::cout << "Сложение времени: " << t3.hours << ":" << t3.minutes << ":" << t3.seconds << "\n";

    Time t4 = t1.subtractTime(t2);
    std::cout << "Вычитание времени: " << t4.hours << ":" << t4.minutes << ":" << t4.seconds << "\n";

    return 0;
}
 