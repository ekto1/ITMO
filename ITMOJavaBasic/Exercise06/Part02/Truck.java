package ITMOJavaBasic.Exercise06.Part02;

public class Truck extends Car{
    public int numberOfWheels;
    public int maxWeight;

    public Truck(int w, String m, char c, float s, int numberOfWheels, int maxWeight) {
        super(w, m, c, s);
        this.numberOfWheels = numberOfWheels;
        this.maxWeight = maxWeight;
    }

    public void newWheels(int newNumberOfWheels){
        this.numberOfWheels = newNumberOfWheels;
        System.out.println("Количество колес: " + numberOfWheels);
    }
}
