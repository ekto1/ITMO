package ITMOJavaBasic.Exercise06.Part04;

import java.util.Scanner;

public class ChildClass extends ParentClass {
    public static String name;

    @Override
    public void getInfo() {
        Scanner scan = new Scanner(System.in);
        System.out.print("Введите имя: ");
        name = scan.next();
    }
}
