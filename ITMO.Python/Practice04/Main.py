import os
import subprocess


def app_start():
    mat_size = int(input("Enter matrix size: "))
    min_val = int(input("Enter minimum value for matrix elements: "))
    max_val = int(input("Enter maximum value for matrix elements: "))
    gen_floats = input("Use float values? (y/n): ")

    subprocess.check_call(["venv\\Scripts\\python.exe", "matrices\\matrix_builder.py", str(mat_size), str(min_val),
                           str(max_val), str(gen_floats)])

    test_runs = int(input("Enter the number of program runs for tests: "))

    if gen_floats != "y":
        use_bigints = input("Do you want to use BigInteger values? (y/n): ")
    else:
        use_bigints = "n"

    thread_num = input("Enter number of threads: ")

    subprocess.check_call(
        ["venv\\Scripts\\python.exe", "DGEMM.py", str(test_runs), str(gen_floats), str(use_bigints),
         str(thread_num)])

    temp_folder = "temp"
    for file in os.listdir(temp_folder):
        os.remove(os.path.join(temp_folder, file))


if __name__ == "__main__":
    app_start()
