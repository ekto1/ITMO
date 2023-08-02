import subprocess
import time
import matplotlib.pyplot as plt
import numpy as np
import argparse
import webbrowser
import os


def run_dgemm(command, num_executions):
    exec_times = []
    for _ in range(num_executions):
        start_time = time.time()
        subprocess.run(command, check=True)
        end_time = time.time()
        exec_times.append(end_time - start_time)
    return exec_times


def plot_stats(exec_times, filename, data_type):
    languages = ["Java", "CSharp", "Python"]
    colors = ["b", "r", "g"]

    plt.figure(figsize=(12, 7))

    for i in range(3):
        plt.plot(exec_times[i], color=colors[i], label=languages[i], linewidth=1)

    plt.legend(loc="upper right")
    plt.xlabel("Number of launches")
    plt.ylabel("Execution Time (s)")
    plt.title(f"Execution time of DGEMM on Java, C# and Python for {data_type}")

    stats_text = ""

    for i in range(3):
        t_min = min(exec_times[i])
        t_max = max(exec_times[i])
        t_avg = sum(exec_times[i]) / len(exec_times[i])
        t_std = np.std(exec_times[i])
        t_med = np.median(exec_times[i])

        stats_text += r"$\bf{" + languages[i] + "}$" + ":\n"
        stats_text += f"tMin = {t_min:.2f} s\n"
        stats_text += f"tMax = {t_max:.2f} s\n"
        stats_text += f"tAvg = {t_avg:.2f} s\n"
        stats_text += f"tStd = {t_std:.2f} s\n"
        stats_text += f"tMed = {t_med:.2f} s\n\n"

    plt.figtext(0.1, 0.02, stats_text, fontsize=10)

    plt.subplots_adjust(left=0.3)

    plt.savefig(filename)


def main():
    parser = argparse.ArgumentParser(description="DGEMM parameters")
    parser.add_argument("num_executions", type=int, help="Number of launches")
    parser.add_argument("generate_floats", type=str, help="Use float values or not")
    parser.add_argument("use_bigint", type=str, help="Use BigInteger values or not")
    parser.add_argument("num_threads", type=int, help="Number of threads (1-32)")
    args = parser.parse_args()

    program_run_count = args.num_executions
    desired_datatype = "y" if args.generate_floats.lower() in ["y", "true"] else "n"
    desired_bigint = "y" if args.use_bigint.lower() in ["y", "true"] else "n"
    thread_count = args.num_threads

    exec_times = []
    data_type = ""

    if desired_datatype == "y":
        data_type = "Float"
        os.chdir('algorithms/csharp/FloatDGEMM/')
        subprocess.run(["dotnet", "build"])
        os.chdir('../../../')

        os.chdir('algorithms/java/FloatDGEMM/')
        subprocess.run(["javac.exe", "FloatDGEMM.java"])
        os.chdir('../../../')

        programs = [["java.exe", "-cp", "algorithms\\java\\FloatDGEMM\\", "FloatDGEMM", "temp\\matrix_a.csv",
                     "temp\\matrix_b.csv", "temp\\Java_Float_DGEMM.csv", str(thread_count)],
                    ["dotnet", "run", "--project", "algorithms\\csharp\\FloatDGEMM", "--", "temp\\matrix_a.csv",
                     "temp\\matrix_b.csv", "temp\\Csharp_Float_DGEMM.csv", str(thread_count)],
                    ["venv\\Scripts\\python.exe", "algorithms\\python\\FloatDGEMM\\FloatDGEMM.py", "--input1",
                     "temp\\matrix_a.csv", "--input2", "temp\\matrix_b.csv", "--output",
                     "temp\\Python_Float_DGEMM.csv", "--threads", str(thread_count)]]
    elif desired_bigint == "y":
        data_type = "BigInteger"
        os.chdir('algorithms/csharp/BigIntDGEMM/')
        subprocess.run(["dotnet", "build"])
        os.chdir('../../../')

        os.chdir('algorithms/java/BigIntDGEMM/')
        subprocess.run(["javac.exe", "BigIntDGEMM.java"])
        os.chdir('../../../')

        programs = [["java.exe", "-cp", "algorithms\\java\\BigIntDGEMM\\", "BigIntDGEMM", "temp\\matrix_a.csv",
                     "temp\\matrix_b.csv", "temp\\Java_BigInt_DGEMM.csv", str(thread_count)],
                    ["dotnet", "run", "--project", "algorithms\\csharp\\BigIntDGEMM", "--", "temp\\matrix_a.csv",
                     "temp\\matrix_b.csv", "temp\\Csharp_BigInt_DGEMM.csv", str(thread_count)],
                    ["venv\\Scripts\\python.exe", "algorithms\\python\\IntDGEMM\\IntDGEMM.py", "--input1",
                     "temp\\matrix_a.csv", "--input2", "temp\\matrix_b.csv", "--output",
                     "temp\\Python_BigInt_DGEMM.csv", "--threads", str(thread_count)]]
    else:
        data_type = "Integer"
        os.chdir('algorithms/csharp/IntDGEMM/')
        subprocess.run(["dotnet", "build"])
        os.chdir('../../../')

        os.chdir('algorithms/java/IntDGEMM/')
        subprocess.run(["javac.exe", "IntDGEMM.java"])
        os.chdir('../../../')

        programs = [["java.exe", "-cp", "algorithms\\java\\IntDGEMM\\", "IntDGEMM", "temp\\matrix_a.csv",
                     "temp\\matrix_b.csv", "temp\\Java_Int_DGEMM.csv", str(thread_count)],
                    ["dotnet", "run", "--project", "algorithms\\csharp\\IntDGEMM", "--", "temp\\matrix_a.csv",
                     "temp\\matrix_b.csv", "temp\\Csharp_Int_DGEMM.csv", str(thread_count)],
                    ["venv\\Scripts\\python.exe", "algorithms\\python\\IntDGEMM\\IntDGEMM.py", "--input1",
                     "temp\\matrix_a.csv", "--input2", "temp\\matrix_b.csv", "--output",
                     "temp\\Python_Int_DGEMM.csv", "--threads", str(thread_count)]]

    for program in programs:
        exec_times.append(run_dgemm(program, program_run_count))

    image_path = f"DGEMM_for_{data_type}.png"
    plot_stats(exec_times, image_path, data_type)
    webbrowser.open(image_path)


if __name__ == "__main__":
    main()
