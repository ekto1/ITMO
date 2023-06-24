#include <iostream>
#include "Colleague.h"

Colleague::Colleague(std::string name, std::string phone, std::string company) 
    : Person(name, phone), company(company) {}

void Colleague::printInfo() const {
    std::cout << "Colleague: " << name << ", phone: " << phone << ", company: " << company << std::endl;
}

std::string Colleague::getCompany() const {
    return company;
}
