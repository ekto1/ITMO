using System.Numerics;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

public class FloatDGEMM
{
    public static void Main(string[] parameters)
    {
        string fileMatrixOne = parameters[0];
        string fileMatrixTwo = parameters[1];
        string fileMatrixResult = parameters[2];
        int threadCount = int.Parse(parameters[3]);

        float[][] matrixOne = ReadMatrix(fileMatrixOne);
        float[][] matrixTwo = ReadMatrix(fileMatrixTwo);

        float[][] multiplicationResult = MultiplyMatrices(matrixOne, matrixTwo, threadCount);

        WriteMatrix(multiplicationResult, fileMatrixResult);
    }

    private static float[][] ReadMatrix(string file)
    {
        var culture = System.Globalization.CultureInfo.InvariantCulture;

        return File.ReadAllLines(file)
            .Select(line => line.Split(',')
                .Select(s => float.Parse(s, culture))
                .ToArray())
            .ToArray();
    }

    private static float[][] MultiplyMatrices(float[][] matrixOne, float[][] matrixTwo, int threadCount)
    {
        int rows = matrixOne.Length;
        int columns = matrixTwo[0].Length;
        int common = matrixOne[0].Length;

        float[][] resultMatrix = new float[rows][];
        for (int i = 0; i < rows; i++)
            resultMatrix[i] = new float[columns];

        var parallelOptions = new ParallelOptions() { MaxDegreeOfParallelism = threadCount };

        Parallel.For(0, rows, parallelOptions, row =>
        {
            for (int column = 0; column < columns; column++)
            {
                float sum = 0f;
                for (int index = 0; index < common; index++)
                {
                    sum += matrixOne[row][index] * matrixTwo[index][column];
                }
                resultMatrix[row][column] = sum;
            }
        });

        return resultMatrix;
    }

    private static void WriteMatrix(float[][] resultMatrix, string file)
    {
        using StreamWriter sw = new StreamWriter(file);
        foreach (var row in resultMatrix)
        {
            sw.WriteLine(string.Join(" ", row));
        }
    }
}
