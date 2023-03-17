package ITMOJavaBasic.Exercise06.Part04;

import java.util.Scanner;

public class ParentClass {
    public static int age;

    public void getInfo(){
        Scanner scan = new Scanner(System.in);
        System.out.print("Введите возраст: ");
        age = scan.nextInt();
    }
}
