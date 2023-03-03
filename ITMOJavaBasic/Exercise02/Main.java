package ITMOJavaBasic.Exercise02;

public class Main {
    public static void main(String[] args) {

        Calculator calculator = new Calculator();

        int summaint = calculator.sum(2, 2);
        System.out.println(summaint);
        long summalong = calculator.sum(10000000000000000L, 10000000L);
        System.out.println(summalong);
        double summadouble = calculator.sum(1.2, 2.3);
        System.out.println(summadouble);

        double divisionint = calculator.division (2, 3);
        System.out.println(divisionint);
        double divisionlong = calculator.division(10000000000000000L, 3L);
        System.out.println(divisionlong);
        double divisiondouble = calculator.division(1.2, 2.3);
        System.out.println(divisiondouble);

        int multiplicationint = calculator.multiplication (2, 2);
        System.out.println(multiplicationint);
        long multiplicationlong = calculator.multiplication(10000000000000000L, 10000000L);
        System.out.println(multiplicationlong);
        double multiplicationdouble = calculator.multiplication(1.2, 2.3);
        System.out.println(multiplicationdouble);

        int minusint = calculator.minus (2, 2);
        System.out.println(minusint);
        long minuslong = calculator.minus(10000000000000000L, 10000000L);
        System.out.println(minuslong);
        double minusdouble = calculator.minus(1.2, 2.3);
        System.out.println(minusdouble);
    }
}
