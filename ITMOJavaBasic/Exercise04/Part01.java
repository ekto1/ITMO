package ITMOJavaBasic.Exercise04;

import java.util.Arrays;
import java.util.Scanner;

public class Part01 {

    //Напишите программу, которая выводит на консоль нечетные числа от 1 до 99. Каждое число печатается с новой строки.
    public static void oddNumbers (){

        for (int i = 1; i < 100; i = i + 2) {
                System.out.println(i);
        }
    }

    //Напишите программу, которая выводит числа от 1 до 100, которые делятся на 3, 5 и на то и другое
    public static void numbers3or5() {

        System.out.print("Делится на 3: ");
        for (int i = 1; i <= 100; i++) {
            if (i % 3 == 0) {
                System.out.print(i + " ");
            }
        }
        System.out.println();
        System.out.print("Делится на 5: ");
        for (int i = 1; i <= 100; i++) {
            if (i % 5 == 0) {
                System.out.print(i + " ");
            }
        }
        System.out.println();
        System.out.print("Делится на 3 и на 5: ");
        for (int i = 1; i <= 100; i++){
            if (i % 3 == 0 & i % 5 == 0) {
                System.out.print(i + " ");
            }
        }
    }

    //Напишите программу, чтобы вычислить сумму двух целых чисел и вернуть true, если сумма равна третьему целому числу
    public static boolean sumTwoNumbers(){

        System.out.print("Введите первое число: ");
        Scanner scann = new Scanner(System.in);
        int number1 = scann.nextInt();

        System.out.print("Введите второе число: ");
        int number2 = scann.nextInt();

        System.out.print("Введите третье число: ");
        int number3 = scann.nextInt();

        scann.close();

        if (number1 + number2 == number3){
            return true;
        }
        return false;

    }

    //Напишите программу, которая принимает от пользователя три целых числа и возвращает true,
    // если второе число больше первого числа, а третье число больше второго числа
    public static boolean compairTreeNumbers(){

        System.out.print("Введите первое число: ");
        Scanner scann = new Scanner(System.in);
        int number1 = scann.nextInt();

        System.out.print("Введите второе число: ");
        int number2 = scann.nextInt();

        System.out.print("Введите третье число: ");
        int number3 = scann.nextInt();

        scann.close();

        if (number2 > number1 && number3 > number2){
            return true;
        }
        return false;
    }

    //Напишите программу, чтобы проверить, появляется ли число 3 как первый или последний элемент массива целых чисел

    public static boolean checkNumber(int[] array){

        System.out.println("array = " + Arrays.toString(array));

        if (array [0] == 3 || array [6] == 3){
            return true;
        }
        return false;
    }

    //Напишите программу, чтобы проверить, что массив содержит число 1 или 3.
    public static boolean checkNumb1or3(int[] array) {

        System.out.println("array = " + Arrays.toString(array));

        for (int i = 0; i < array.length; i++) {
            if (array [i] == 1 || array [i] == 3){
                return true;
            }
        }
        return false;
    }

}
