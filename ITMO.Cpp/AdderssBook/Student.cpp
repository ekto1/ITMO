#include <iostream>
#include "Student.h"

Student::Student(std::string name, std::string phone, std::string university) 
    : Person(name, phone), university(university) {}

void Student::printInfo() const {
    std::cout << "Student: " << name << ", phone: " << phone << ", university: " << university << std::endl;
}

std::string Student::getUniversity() const {
    return university;
}
