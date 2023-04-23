import random
import sys
import csv

def generate_matrix(n, min_value, max_value, filename):
    with open(filename, 'w', newline='') as f:
        writer = csv.writer(f, delimiter=',')
        for _ in range(n):
            row = [random.randint(min_value, max_value) for _ in range(n)]
            writer.writerow(row)

if __name__ == "__main__":
    if len(sys.argv) != 5:
        print("Usage: python matrix_generator.py <n> <min_value> <max_value> <filename>")
        print("Example: python matrix_generator.py 5 1 10 matrix.csv")
        sys.exit(1)

    n = int(sys.argv[1])
    min_value = int(sys.argv[2])
    max_value = int(sys.argv[3])
    filename = sys.argv[4]
    generate_matrix(n, min_value, max_value, filename)

