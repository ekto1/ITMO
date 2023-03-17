package ITMOJavaBasic.Exercise05;

import java.util.Arrays;


public class Exercise05 {

    //Написать метод для поиска самого длинного слова в тексте
    public static void searchLongest(){

        String text = "с помощью этой конструкции мы можем объявить ресурсы, которые будут использоваться в try-блоке, и эти ресурсы будут автоматиески закрыты по окончании выполнения try-блока. Ресурсом будем называть объект, являющийся экземпляром класса, который реализует интерфейс java";
        String theLongest = "";

        for(String word : text.split(" ")){
            if(word.length() > theLongest.length()){
                theLongest = word;
            }
        }
        System.out.println("Самое длинное слово: " + theLongest);
    }

    //Написать метод, который проверяет является ли слово палиндромом
    public static boolean palindrom(String anyWord){

        String word = anyWord.toLowerCase();
        StringBuilder inputWord = new StringBuilder();
        inputWord.append(word);

        if (word.equals(inputWord.toString())) {
            return true;
            }
        return false;
    }

    //Напишите метод, заменяющий в тексте все вхождения слова «бяка» на «[вырезано цензурой]»
    public static void changeByaka(String text, String regex, String replacement) {
        String replaceText = text.replaceAll(regex, replacement);
        System.out.println(replaceText);
    }

    //Имеются две строки. Найти количество вхождений одной (являющейся подстрокой) в другую
    public static void countSubString(String str) {

        System.out.println(str);
        String substring = str.substring(0, 2);
        System.out.println(substring);

        int count = str.split(substring, -1).length - 1;

        System.out.println(count);
    }

    //Напишите метод, который инвертирует слова в строке
    public static void changeSide(String text) {

        System.out.println("The given string is: " + text);
        System.out.print("The string reversed word by word is: ");

        for(String word : text.split(" ")){
            StringBuilder builder = new StringBuilder(word);
            System.out.print(builder.reverse() + " ");
        }
    }
}
