package ITMOJavaBasic.Exercise07;

public class Main {
    public static void main(String[] args) {

        Airplane.Wing boing1 = new Airplane.Wing();
        Airplane.Wing boing2 = new Airplane.Wing();

        boing1.weightWing = 4;
        boing1.outPrintWeightWing();

        boing2.weightWing = 3;
        boing2.outPrintWeightWing();

    }
}
