#include <iostream>
#include "Teacher.h"

Teacher::Teacher(std::string name, std::string phone, std::string subject) 
    : Person(name, phone), subject(subject) {}

void Teacher::printInfo() const {
    std::cout << "Teacher: " << name << ", phone: " << phone << ", subject: " << subject << std::endl;
}

std::string Teacher::getSubject() const {
    return subject;
}

