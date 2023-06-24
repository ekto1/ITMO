#pragma once
#include <string>

class Person {
protected:
    std::string name;
    std::string phone;
public:
    Person(std::string name, std::string phone);

    virtual ~Person();

    virtual void printInfo() const = 0;

    std::string getName() const;

    std::string getPhone() const;
};
