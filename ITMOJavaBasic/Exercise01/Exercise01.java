package ITMOJavaBasic.Exercise01;

import java.util.Scanner;

public class Exercise01 {
    public static void main(String[] args){
        System.out.println("Я");
        System.out.println("хорошо");
        System.out.println("знаю");
        System.out.println("Java");

        double primer1 = (46 + 10) * (10 * 1.0 / 3);
        int primer2 = (29) * (4) * (-15);
        System.out.println(primer1);
        System.out.println(primer2);

        int number = 10500;
        int result = (number / 10) / 10;
        System.out.println(result);

        double a = 3.6;
        double b = 4.1;
        double c = 5.9;
        double result2 = a * b * c;
        System.out.println(result2);

        Scanner scanner = new Scanner(System.in);
        int d1 = scanner.nextInt();
        int d2 = scanner.nextInt();
        int d3 = scanner.nextInt();
        System.out.println(d1);
        System.out.println(d2);
        System.out.println(d3);

        int e = scanner.nextInt();
        if (e % 2 != 0 && e < 100){
            System.out.println("Нечетное");
        }else if (e < 100){
            System.out.println("Четное");
        }else{
            System.out.println("Выход за пределы диапазона");
        }
    }
}
