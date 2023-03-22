package ITMOJavaBasic.Exercise10.Part04;

import java.io.*;

public class RewrightFileWith$ {
    public static void main(String[] args) {
        rewrightFileWith$("ITMOJavaBasic/Exercise10/Files/MergedFile.txt",
                "ITMOJavaBasic/Exercise10/Files/RewrightFileWith$.txt");
    }

    public static void rewrightFileWith$(String inputFile, String outputFile) {
        try(
                BufferedReader reader = new BufferedReader(new FileReader(inputFile));
                BufferedWriter writer = new BufferedWriter(new FileWriter(outputFile))
                ){
            String line;
            while((line = reader.readLine()) != null){

                StringBuilder modifiedLine = new StringBuilder();

                for (char ch : line.toCharArray()) {

                    if (Character.isLetterOrDigit(ch)) {
                        modifiedLine.append(ch);
                    } else {
                        modifiedLine.append('$');
                    }
                }

                writer.write(modifiedLine.toString());
                writer.newLine();
            }
        }catch (IOException e){
            System.err.println("Error: " + e.getMessage());
        }
    }
}
