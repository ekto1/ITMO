#include <vector>
#include "Person.h"

class AddressBook {
private:
    std::vector<Person*> contacts;
public:
    void addContact(Person* person);

    void saveToFile(const std::string& filename);

    void loadFromFile(const std::string& filename);

    void printAllContacts();

    ~AddressBook();
};
