#include <iostream>
#include <vector>
#include <fstream>
#include <sstream>
#include "AddressBook.h"
#include "Teacher.h"
#include "Student.h"
#include "Colleague.h"

class UserInterface {
private:
    AddressBook* addressBook;
public:
    UserInterface() {
        addressBook = new AddressBook();
    }

    ~UserInterface() {
        delete addressBook;
    }

    void addContact() {
        std::string type, name, phone, additional;
        std::cout << "Enter contact type (Student, Teacher, Colleague): ";
        std::getline(std::cin >> std::ws, type); // std::ws обрабатывает возможные пробельные символы перед вводом
        std::cout << "Enter name: ";
        std::getline(std::cin, name);
        std::cout << "Enter phone: ";
        std::getline(std::cin, phone);
        if (type == "Student") {
            std::cout << "Enter university: ";
            std::getline(std::cin, additional);
            addressBook->addContact(new Student(name, phone, additional));
        } else if (type == "Teacher") {
            std::cout << "Enter subject: ";
            std::getline(std::cin, additional);
            addressBook->addContact(new Teacher(name, phone, additional));
        } else if (type == "Colleague") {
            std::cout << "Enter company: ";
            std::getline(std::cin, additional);
            addressBook->addContact(new Colleague(name, phone, additional));
        } else {
            std::cerr << "Unknown contact type: " << type << std::endl;
        }
    }


    void printAllContacts() {
        addressBook->printAllContacts();
    }

    void saveContactsToFile(const std::string& filename) {
        addressBook->saveToFile(filename);
    }

    void loadContactsFromFile(const std::string& filename) {
        addressBook->loadFromFile(filename);
    }

    void start() {
        while (true) {
            std::cout << "\n--- Address Book Menu ---\n";
            std::cout << "1. Add contact\n";
            std::cout << "2. View all contacts\n";
            std::cout << "3. Save contacts to file\n";
            std::cout << "4. Load contacts from file\n";
            std::cout << "5. Exit\n";
            std::cout << "Enter your choice: ";

            int choice;
            std::cin >> choice;

            switch (choice) {
            case 1:
                addContact();
                break;
            case 2:
                printAllContacts();
                break;
            case 3: {
                std::string filename;
                std::cout << "Enter filename: ";
                std::cin >> filename;
                saveContactsToFile(filename);
                break;
            }
            case 4: {
                std::string filename;
                std::cout << "Enter filename: ";
                std::cin >> filename;
                loadContactsFromFile(filename);
                break;
            }
            case 5:
                return;  // выход из цикла, завершение метода start
            default:
                std::cerr << "Unknown choice: " << choice << std::endl;
                break;
            }
        }
    }
};
