import numpy as np
import pandas as pd
import argparse as ap


def create_matrix(r, c, min_v, max_v, float_v=False):
    return np.random.uniform(min_v, max_v, (r, c)).astype("float64" if float_v else "int64")


def write_matrix_to_file(mat, filename):
    data_frame = pd.DataFrame(mat)
    data_frame.to_csv(filename, index=False, header=False)


def execute():
    arg_parser = ap.ArgumentParser(description="Matrix parameters")
    arg_parser.add_argument("size", type=int, help="Size of the square matrix")
    arg_parser.add_argument("min_val", type=int, help="Minimum value for the matrix elements")
    arg_parser.add_argument("max_val", type=int, help="Maximum value for the matrix elements")
    arg_parser.add_argument("float_values", type=str, help="Generate float values or not")
    args = arg_parser.parse_args()

    size, min_val, max_val = args.size, args.min_val, args.max_val
    float_values = args.float_values == "y"

    mat_a = create_matrix(size, size, min_val, max_val, float_values)
    mat_b = create_matrix(size, size, min_val, max_val, float_values)

    write_matrix_to_file(mat_a, "temp\\matrix_a.csv")
    write_matrix_to_file(mat_b, "temp\\matrix_b.csv")

    print("Matrix A and B were created and saved to matrix_a.csv and matrix_b.csv")


if __name__ == "__main__":
    execute()
