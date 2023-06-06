#include <iostream>
#include <cstring>
#include <cstdlib>

using namespace std;

int main(int argc, char *argv[]) {
    if(argc != 4) {
        cerr << "Error: Wrong number of arguments!" << endl;
        return 1;
    }
    
    int num1 = atoi(argv[2]);
    int num2 = atoi(argv[3]);

    if(strcmp(argv[1], "-a") == 0) {
        cout << "The sum is: " << num1 + num2 << endl;
    } else if(strcmp(argv[1], "-m") == 0) {
        cout << "The product is: " << num1 * num2 << endl;
    } else {
        cerr << "Error: Invalid flag! Use -a for addition and -m for multiplication." << endl;
        return 1;
    }

    return 0;
}
