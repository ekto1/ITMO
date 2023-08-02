using System.Numerics;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

public class BigIntDGEMM
{
    public static void Main(string[] parameters)
    {
        string fileMatrixOne = parameters[0];
        string fileMatrixTwo = parameters[1];
        string fileMatrixResult = parameters[2];
        int threadCount = int.Parse(parameters[3]);

        BigInteger[][] matrixOne = ReadMatrix(fileMatrixOne);
        BigInteger[][] matrixTwo = ReadMatrix(fileMatrixTwo);

        BigInteger[][] multiplicationResult = MultiplyMatrices(matrixOne, matrixTwo, threadCount);

        WriteMatrix(multiplicationResult, fileMatrixResult);
    }

    private static BigInteger[][] ReadMatrix(string file)
    {
        return File.ReadAllLines(file)
            .Select(line => line.Split(',')
                .Select(BigInteger.Parse)
                .ToArray())
            .ToArray();
    }

    private static BigInteger[][] MultiplyMatrices(BigInteger[][] matrixOne, BigInteger[][] matrixTwo, int threadCount)
    {
        int rows = matrixOne.Length;
        int columns = matrixTwo[0].Length;
        int common = matrixOne[0].Length;

        BigInteger[][] resultMatrix = new BigInteger[rows][];
        for (int i = 0; i < rows; i++)
            resultMatrix[i] = new BigInteger[columns];

        var parallelOptions = new ParallelOptions() { MaxDegreeOfParallelism = threadCount };

        Parallel.For(0, rows, parallelOptions, row =>
        {
            for (int column = 0; column < columns; column++)
            {
                BigInteger sum = BigInteger.Zero;
                for (int index = 0; index < common; index++)
                {
                    sum += matrixOne[row][index] * matrixTwo[index][column];
                }
                resultMatrix[row][column] = sum;
            }
        });

        return resultMatrix;
    }

    private static void WriteMatrix(BigInteger[][] resultMatrix, string file)
    {
        using StreamWriter sw = new StreamWriter(file);
        foreach (var row in resultMatrix)
        {
            sw.WriteLine(string.Join(" ", row));
        }
    }
}
