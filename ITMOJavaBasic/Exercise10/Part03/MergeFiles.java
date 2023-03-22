package ITMOJavaBasic.Exercise10.Part03;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class MergeFiles {
    public static void main(String[] args) {

            mergeFiles("ITMOJavaBasic/Exercise10/Files/Text.txt",
                    "ITMOJavaBasic/Exercise10/Files/NewText.txt",
                    "ITMOJavaBasic/Exercise10/Files/MergedFile.txt");
    }

    public static void mergeFiles(String inputFile1, String inputFile2, String outputFile) {

        try(
                BufferedReader reader1 = new BufferedReader(new FileReader(inputFile1));
                BufferedReader reader2 = new BufferedReader(new FileReader(inputFile2));
                BufferedWriter writer = new BufferedWriter(new FileWriter(outputFile))
        ){
            String line;

            while ((line = reader1.readLine()) != null) {
                writer.write(line);
                writer.newLine();
            }
            while ((line = reader2.readLine()) != null) {
                writer.write(line);
                writer.newLine();
            }
        } catch (IOException e){
            System.err.println("Error: " + e.getMessage());
        }
    }
}
