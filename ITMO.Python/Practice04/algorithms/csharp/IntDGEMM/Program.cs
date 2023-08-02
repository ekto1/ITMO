using System.Numerics;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

public class intDGEMM
{
    public static void Main(string[] parameters)
    {
        string fileMatrixOne = parameters[0];
        string fileMatrixTwo = parameters[1];
        string fileMatrixResult = parameters[2];
        int threadCount = int.Parse(parameters[3]);

        int[][] matrixOne = ReadMatrix(fileMatrixOne);
        int[][] matrixTwo = ReadMatrix(fileMatrixTwo);

        int[][] multiplicationResult = MultiplyMatrices(matrixOne, matrixTwo, threadCount);

        WriteMatrix(multiplicationResult, fileMatrixResult);
    }

    private static int[][] ReadMatrix(string file)
    {
        return File.ReadAllLines(file)
            .Select(line => line.Split(',')
                .Select(int.Parse)
                .ToArray())
            .ToArray();
    }

    private static int[][] MultiplyMatrices(int[][] matrixOne, int[][] matrixTwo, int threadCount)
    {
        int rows = matrixOne.Length;
        int columns = matrixTwo[0].Length;
        int common = matrixOne[0].Length;

        int[][] resultMatrix = new int[rows][];
        for (int i = 0; i < rows; i++)
            resultMatrix[i] = new int[columns];

        var parallelOptions = new ParallelOptions() { MaxDegreeOfParallelism = threadCount };

        Parallel.For(0, rows, parallelOptions, row =>
        {
            for (int column = 0; column < columns; column++)
            {
                int sum = 0;
                for (int index = 0; index < common; index++)
                {
                    sum += matrixOne[row][index] * matrixTwo[index][column];
                }
                resultMatrix[row][column] = sum;
            }
        });

        return resultMatrix;
    }

    private static void WriteMatrix(int[][] resultMatrix, string file)
    {
        using StreamWriter sw = new StreamWriter(file);
        foreach (var row in resultMatrix)
        {
            sw.WriteLine(string.Join(" ", row));
        }
    }
}
