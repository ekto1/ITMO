import java.io.IOException;
import java.io.BufferedWriter;
import java.nio.file.Paths;
import java.nio.file.Files;
import java.math.BigInteger;
import java.util.concurrent.Executors;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.TimeUnit;
import java.util.List;

public class BigIntDGEMM {

    public static void main(String[] parameters) {
        String fileMatrixA = parameters[0];
        String fileMatrixB = parameters[1];
        String fileMatrixResult = parameters[2];
        int threadsCount = Integer.parseInt(parameters[3]);

        BigInteger[][] loadedMatrixA = retrieveMatrix(fileMatrixA);
        BigInteger[][] loadedMatrixB = retrieveMatrix(fileMatrixB);

        BigInteger[][] multipliedMatrix = multiplyMatrices(loadedMatrixA, loadedMatrixB, threadsCount);

        writeMatrixToFile(multipliedMatrix, fileMatrixResult);
    }

    private static BigInteger[][] retrieveMatrix(String fileName) {
        try {
            List<String> fileLines = Files.readAllLines(Paths.get(fileName));
            int rows = fileLines.size();
            int columns = fileLines.get(0).split(",").length;
            BigInteger[][] retrievedMatrix = new BigInteger[rows][columns];

            for (int i = 0; i < rows; i++) {
                String[] valuesInRow = fileLines.get(i).split(",");
                for (int j = 0; j < columns; j++) {
                    retrievedMatrix[i][j] = new BigInteger(valuesInRow[j]);
                }
            }

            return retrievedMatrix;
        } catch (IOException e) {
            e.printStackTrace();
            return null;
        }
    }

    private static BigInteger[][] multiplyMatrices(BigInteger[][] matrixA, BigInteger[][] matrixB, int threadsNum) {
        int rows = matrixA.length;
        int columns = matrixB[0].length;
        int comm = matrixA[0].length;
        ExecutorService threadPool = Executors.newFixedThreadPool(threadsNum);

        BigInteger[][] multipliedMatrix = new BigInteger[rows][columns];
        for (int i = 0; i < rows; i++) {
            final int finalRow = i;
            threadPool.submit(() -> {
                for (int j = 0; j < columns; j++) {
                    BigInteger rowSum = BigInteger.ZERO;
                    for (int k = 0; k < comm; k++) {
                        rowSum = rowSum.add(matrixA[finalRow][k].multiply(matrixB[k][j]));
                    }
                    multipliedMatrix[finalRow][j] = rowSum;
                }
            });
        }

        threadPool.shutdown();
        try {
            if (!threadPool.awaitTermination(60, TimeUnit.MINUTES)) {
                threadPool.shutdownNow();
            }
        } catch (InterruptedException ex) {
            threadPool.shutdownNow();
            Thread.currentThread().interrupt();
        }

        return multipliedMatrix;
    }

    private static void writeMatrixToFile(BigInteger[][] finalMatrix, String fileName) {
        try (BufferedWriter bw = Files.newBufferedWriter(Paths.get(fileName))) {
            int rows = finalMatrix.length;
            int columns = finalMatrix[0].length;

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < columns; j++) {
                    bw.write(finalMatrix[i][j] + (j == columns - 1 ? "" : " "));
                }
                bw.newLine();
            }

        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
