#include "Person.h"
#include <iostream>

Person::Person(std::string name, std::string phone) : name(name), phone(phone) {}

Person::~Person() {
    std::cout << "Person object deleted." << std::endl;
}

std::string Person::getName() const {
    return name;
}

std::string Person::getPhone() const {
    return phone;
}

