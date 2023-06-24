#pragma once
#include "Person.h"

class Student : public Person {
private:
    std::string university;
public:
    Student(std::string name, std::string phone, std::string university);

    void printInfo() const override;

    std::string getUniversity() const;
};
