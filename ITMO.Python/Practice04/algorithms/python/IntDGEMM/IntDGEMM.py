import numpy
import argparse
import multiprocessing
import os


def matrix_import(filepath):
    return numpy.loadtxt(filepath, delimiter=',', dtype=numpy.int64)


def matrix_export(matrix, filepath):
    numpy.savetxt(filepath, matrix, delimiter=' ', fmt='%d')


def row_multiplication(parameters):
    row_a, matrix_b = parameters
    return numpy.dot(row_a, matrix_b)


def matrix_multiplication(matrix_a, matrix_b, threads):
    with multiprocessing.Pool(processes=threads) as pool:
        res_matrix = pool.map(row_multiplication, [(matrix_a[i], matrix_b) for i in range(matrix_a.shape[0])])
    return numpy.array(res_matrix, dtype=int)


def run():
    args_parser = argparse.ArgumentParser()
    args_parser.add_argument("--input1")
    args_parser.add_argument("--input2")
    args_parser.add_argument("--output")
    args_parser.add_argument("--threads", type=int, default=os.cpu_count())
    args = args_parser.parse_args()

    loaded_matrix_a = matrix_import(args.input1)
    loaded_matrix_b = matrix_import(args.input2)

    multiplied_matrix = matrix_multiplication(loaded_matrix_a, loaded_matrix_b, args.threads)
    matrix_export(multiplied_matrix, args.output)


if __name__ == "__main__":
    run()
