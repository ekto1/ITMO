package ITMOJavaBasic.Exercise10.Part01;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;

public class ReadLines {
    public static void main(String[] args) {
        File text = new File("ITMOJavaBasic/Exercise10/Files/Text.txt");

        try (BufferedReader reader = new BufferedReader(new FileReader(text))){
            String input;
            while ((input = reader.readLine()) != null){
                System.out.println(input);
            }
        }catch (IOException e){
            System.err.println("Error: " + e.getMessage());
        }
    }
}
