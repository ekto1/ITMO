import java.io.*;
import java.nio.file.*;
import java.util.Arrays;
import java.util.concurrent.*;
import java.util.stream.Collectors;

public class MultiThreadedDGEMM {

    static int[][] readMatrix(String filename) throws IOException {
        String[] lines = Files.readAllLines(Paths.get(filename)).toArray(new String[0]);
        int n = lines.length;
        int[][] matrix = new int[n][n];

        for (int i = 0; i < n; i++) {
            String[] row = lines[i].split(",");
            for (int j = 0; j < n; j++) {
                matrix[i][j] = Integer.parseInt(row[j]);
            }
        }

        return matrix;
    }

    static void writeMatrix(int[][] matrix, String filename) throws IOException {
        int n = matrix.length;
        try (BufferedWriter writer = Files.newBufferedWriter(Paths.get(filename))) {
            for (int i = 0; i < n; i++) {
                String row = Arrays.stream(matrix[i])
                        .mapToObj(Integer::toString)
                        .collect(Collectors.joining(","));
                writer.write(row);
                writer.newLine();
            }
        }
    }

    static int[][] dgemm(int n, int[][] A, int[][] B) throws InterruptedException, ExecutionException {
        int[][] C = new int[n][n];
        ExecutorService executor = Executors.newFixedThreadPool(Runtime.getRuntime().availableProcessors());

        List<Future<Void>> futures = new ArrayList<>();

        for (int i = 0; i < n; i++) {
            final int row = i;
            futures.add(executor.submit(() -> {
                for (int j = 0; j < n; j++) {
                    for (int k = 0; k < n; k++) {
                        C[row][j] += A[row][k] * B[k][j];
                    }
                }
                return null;
            }));
        }

        for (Future<Void> future : futures) {
            future.get();
        }

        executor.shutdown();
        return C;
    }

    public static void main(String[] args) throws IOException, InterruptedException, ExecutionException {
        int n = Integer.parseInt(args[0]);
        String inputA = args[1];
        String inputB = args[2];
        String outputFile = args[3];

        int[][] A = readMatrix(inputA);
        int[][] B = readMatrix(inputB);
        int[][] C = dgemm(n, A, B);
        writeMatrix(C, outputFile);
    }
}
