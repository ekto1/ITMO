#include "Person.h"

class Colleague : public Person {
private:
    std::string company;
public:
    Colleague(std::string name, std::string phone, std::string company);

    void printInfo() const override;

    std::string getCompany() const;
};
