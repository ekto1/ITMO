package ITMOJavaBasic.Exercise07;

public class Airplane {

    Wing wing = new Wing();

    static class Wing{
        int weightWing = 0;
        void outPrintWeightWing(){
            System.out.println("Вес крыла самолета: " + weightWing + " т.");
        }
    }
}
