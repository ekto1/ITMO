#include <iostream>
#include <vector>
#include <fstream>
#include <sstream>
#include "AddressBook.h"
#include "Teacher.h"
#include "Student.h"
#include "Colleague.h"

void AddressBook::addContact(Person* person) {
    contacts.push_back(person);
}

void AddressBook::saveToFile(const std::string& filename) {
    std::ofstream file(filename);
    if (!file) {
        std::cerr << "Unable to open the file for writing!" << std::endl;
        return;
    }
    for (auto& contact : contacts) {
        file << contact->getName() << "," << contact->getPhone() << "\n";
    }
    file.close();
}

void AddressBook::loadFromFile(const std::string& filename) {
    std::ifstream file(filename);
    if (!file) {
        std::cerr << "Unable to open the file for reading!" << std::endl;
        return;
    }
    std::string line;
    while (std::getline(file, line)) {
        std::istringstream iss(line);
        std::string type, name, phone, additional;
        if (!(iss >> type >> name >> phone >> additional)) { break; } 
        if (type == "Student") {
            addContact(new Student(name, phone, additional));
        } else if (type == "Teacher") {
            addContact(new Teacher(name, phone, additional));
        } else if (type == "Colleague") {
            addContact(new Colleague(name, phone, additional));
        } else {
            std::cerr << "Unknown contact type: " << type << std::endl;
        }
    }
    file.close();
}

void AddressBook::printAllContacts() {
    for (auto& contact : contacts) {
        contact->printInfo();
    }
}

AddressBook::~AddressBook() {
    for (auto& contact : contacts) {
        delete contact;
    }
}
