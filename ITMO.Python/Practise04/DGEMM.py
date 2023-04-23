import sys

def read_matrix(filename):
    with open(filename) as f:
        return [[int(x) for x in line.split()] for line in f]

def write_matrix(matrix, filename):
    with open(filename, 'w') as f:
        for row in matrix:
            f.write(' '.join(str(x) for x in row) + '\n')

def dgemm(n, A, B):
    C = [[0 for _ in range(n)] for _ in range(n)]
    for i in range(n):
        for j in range(n):
            for k in range(n):
                C[i][j] += A[i][k] * B[k][j]
    return C

if __name__ == "__main__":
    n = int(sys.argv[1])
    input_A = sys.argv[2]
    input_B = sys.argv[3]
    output_file = sys.argv[4]

    A = read_matrix(input_A)
    B = read_matrix(input_B)
    C = dgemm(n, A, B)
    write_matrix(C, output_file)
