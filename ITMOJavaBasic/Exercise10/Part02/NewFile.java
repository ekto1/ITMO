package ITMOJavaBasic.Exercise10.Part02;

import java.io.*;
import java.util.List;

public class NewFile {
    public static void main(String[] args) {
        addText(List.of("Написать метод который записывает в файл строку переданную параметром!"),
                "ITMOJavaBasic/Exercise10/Files/NewText.txt");
    }

    public static void addText(List<String> strings, String path) {

        try (BufferedWriter writer = new BufferedWriter(new FileWriter(path))){
            for(String s : strings){
                writer.write(s);
            }
        }catch (IOException e){
            System.err.println("Error: " + e.getMessage());
        }
    }
}
