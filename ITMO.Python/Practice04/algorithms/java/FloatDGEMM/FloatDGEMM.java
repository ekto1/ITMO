import java.io.IOException;
import java.io.BufferedWriter;
import java.nio.file.Paths;
import java.nio.file.Files;
import java.util.concurrent.Executors;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.TimeUnit;
import java.util.List;

public class FloatDGEMM {

    public static void main(String[] parameters) {
        String fileMatrixA = parameters[0];
        String fileMatrixB = parameters[1];
        String fileMatrixResult = parameters[2];
        int threadsCount = Integer.parseInt(parameters[3]);

        float[][] loadedMatrixA = retrieveMatrix(fileMatrixA);
        float[][] loadedMatrixB = retrieveMatrix(fileMatrixB);

        float[][] multipliedMatrix = multiplyMatrices(loadedMatrixA, loadedMatrixB, threadsCount);

        writeMatrixToFile(multipliedMatrix, fileMatrixResult);
    }

    private static float[][] retrieveMatrix(String fileName) {
        try {
            List<String> fileLines = Files.readAllLines(Paths.get(fileName));
            int rows = fileLines.size();
            int columns = fileLines.get(0).split(",").length;
            float[][] retrievedMatrix = new float[rows][columns];

            for (int i = 0; i < rows; i++) {
                String[] valuesInRow = fileLines.get(i).split(",");
                for (int j = 0; j < columns; j++) {
                    retrievedMatrix[i][j] = Float.parseFloat(valuesInRow[j]);
                }
            }

            return retrievedMatrix;
        } catch (IOException e) {
            e.printStackTrace();
            return null;
        }
    }

    private static float[][] multiplyMatrices(float[][] matrixA, float[][] matrixB, int threadsNum) {
        int rows = matrixA.length;
        int columns = matrixB[0].length;
        int comm = matrixA[0].length;
        ExecutorService threadPool = Executors.newFixedThreadPool(threadsNum);

        float[][] multipliedMatrix = new float[rows][columns];
        for (int i = 0; i < rows; i++) {
            final int finalRow = i;
            threadPool.submit(() -> {
                for (int j = 0; j < columns; j++) {
                    float rowSum = 0;
                    for (int k = 0; k < comm; k++) {
                        rowSum += matrixA[finalRow][k] * matrixB[k][j];
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

    private static void writeMatrixToFile(float[][] finalMatrix, String fileName) {
        try (BufferedWriter bw = Files.newBufferedWriter(Paths.get(fileName))) {
            int rows = finalMatrix.length;
            int columns = finalMatrix[0].length;

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < columns; j++) {
                    bw.write(Float.toString(finalMatrix[i][j]) + (j == columns - 1 ? "" : " "));
                }
                bw.newLine();
            }

        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
