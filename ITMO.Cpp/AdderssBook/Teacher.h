#pragma once
#include "Person.h"

class Teacher : public Person {
private:
    std::string subject;
public:
    Teacher(std::string name, std::string phone, std::string subject);

    void printInfo() const override;

    std::string getSubject() const;
};
