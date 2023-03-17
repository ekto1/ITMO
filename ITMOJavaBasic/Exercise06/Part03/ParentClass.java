package ITMOJavaBasic.Exercise06.Part03;

import java.util.Scanner;

public class ParentClass {
    public static int intNumber;

    public void getNumber(){
        Scanner scan = new Scanner(System.in);
        System.out.println("Введите целое число: ");
        intNumber = scan.nextInt();
    }
}
