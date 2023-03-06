package ITMOJavaBasic.Exercise03;

public class Car {

    private String color;
    private String name;
    private Double weight;

    public Car() {
    }

    public Car(String color) {
        this.color = color;
    }

    public Car(String color, String name) {
        this.color = color;
        this.name = name;
    }

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Double getWeight() {
        return weight;
    }

    public void setWeight(Double weight) {
        this.weight = weight;
    }

    public void output(){
        System.out.println(name + " " + color + " " + weight);
    }
}
