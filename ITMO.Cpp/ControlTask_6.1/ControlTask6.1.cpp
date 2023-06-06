#include <iostream>
#include <fstream>
#include <string>

int main() {
    std::cout << "Введите стихотворение. Когда закончите, введите 'END' на новой строке:\n";
    
    std::string line;
    std::string poem;

    while (std::getline(std::cin, line)) {
        if (line == "END") {
            break;
        }
        poem += line + "\n";
    }

    std::ofstream file("poem.txt");
    if (file.is_open()) {
        file << poem;
        file.close();
        std::cout << "Стихотворение успешно сохранено в файл 'poem.txt'.\n";
    } else {
        std::cerr << "Не удалось открыть файл для записи.\n";
        return 1;
    }

    return 0;
}
 