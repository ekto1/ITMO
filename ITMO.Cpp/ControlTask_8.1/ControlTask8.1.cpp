#include<iostream>

class Time {
private:
    int hours;
    int minutes;
    int seconds;

public:
    // Конструктор по умолчанию
    Time() : hours(0), minutes(0), seconds(0) { }

    // Конструктор с параметрами
    Time(int h, int m, int s) {
        seconds = s % 60;
        minutes = (m + s / 60) % 60;
        hours = (h + (m + s / 60) / 60) % 24;
    }

    // Метод для вывода времени
    void displayTime() const {
        std::cout << hours << ":" << minutes << ":" << seconds << std::endl;
    }

    // Метод для сложения двух объектов Time
    void addTime(const Time& t1, const Time& t2) {
        seconds = (t1.seconds + t2.seconds) % 60;
        minutes = ((t1.minutes + t2.minutes) + (t1.seconds + t2.seconds) / 60) % 60;
        hours = ((t1.hours + t2.hours) + ((t1.minutes + t2.minutes) + (t1.seconds + t2.seconds) / 60) / 60) % 24;
    }
};

int main() {
    // Создаем два инициализированных объекта
    const Time t1(10, 59, 59);
    const Time t2(2, 59, 2);

    // Создаем неинициализированный объект
    Time t3;

    // Складываем два инициализированных значения
    t3.addTime(t1, t2);

    // Выводим значение на экран
    t3.displayTime();

    return 0;
}
