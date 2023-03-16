package ITMOJavaBasic.Exercise06.Part01;

public class Worker extends Person{

    public Worker(String firstName, String lastName, String bankName) {
        super(firstName, lastName);
    }

    private String bankName;

    @Override
    void nameOut(String firstName, String lastName) {

        System.out.println("Имя: " + firstName);
        System.out.println("Фамилия: " + lastName);
        System.out.println("Название банка: " + bankName);
    }

}
