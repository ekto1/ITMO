package ITMOJavaBasic.Exercise04;

import java.util.Arrays;
import java.util.Scanner;

public class Part02 {

    //Напишите программу, которая проверяет отсортирован ли массив по возрастанию
    public static void checkArray(int[] array) {

        for (int i = 0; i < (array.length - 1); i++) {
            if (array[i] > array[i + 1]) {
                System.out.println("Please, try again");
                return;
            }
        }
        System.out.println("OK");
    }

    //Напишите программу, которая считывает с клавиатуры длину массива
    public static void arrayIn(){
        System.out.print("Array length: ");
        Scanner scann = new Scanner(System.in);

        int[] array = new int [scann.nextInt()];

        System.out.println("Numbers of array: ");
        for (int i = 0; i < array.length; i++) {
            array[i] = scann.nextInt();
        }
        System.out.print("Result: " + Arrays.toString(array));
    }

    //Напишите метод, который меняет местами первый и последний элемент массива.
    public static void arrayChange(int[] array) {

        System.out.println("Array 1: " + Arrays.toString(array));

        int first = array[0];

        array[0] = array[array.length - 1];
        array[array.length - 1] = first;

        System.out.println("Array 2: " + Arrays.toString(array));
    }

    //Найдите первое уникальное в этом массиве число
    public static void arrayUnique(int[] array) {

        for (int i = 0; i < array.length; i++) {
            for (int j = 1; j < array.length; j++) {
                if (array[i] == array[j] && i != j) {
                    array[i] = 0;
                    array[j] = 0;
                    break;
                }
            }
            if (array[i] != 0) {
                System.out.println(array[i]);
                return;
            }
        }
    }
}
