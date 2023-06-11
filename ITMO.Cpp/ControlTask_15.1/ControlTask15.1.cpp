#include <iostream>
#include <map>

// Структура для хранения данных студента
struct StudentGrade {
    std::string name;
    char grade;
};

int main() {
    // Создаем map для хранения оценок студентов
    std::map<std::string, char> studentGrades;

    // Создаем несколько студентов
    StudentGrade student1 = {"Иван", 'B'};
    StudentGrade student2 = {"Анна", 'A'};
    StudentGrade student3 = {"Петр", 'C'};

    // Добавляем оценки студентов в map
    studentGrades[student1.name] = student1.grade;
    studentGrades[student2.name] = student2.grade;
    studentGrades[student3.name] = student3.grade;

    // Печатаем оценки всех студентов
    for (auto &studentGrade : studentGrades) {
        std::cout << "Студент: " << studentGrade.first << ", оценка: " << studentGrade.second << std::endl;
    }

    return 0;
}
