package ITMOJavaBasic.Exercise03;

public class Main {
    public static void main(String[] args) {

        //Для работы с классом машина

        Car ferrari = new Car();

        ferrari.setColor("red");
        ferrari.setName("ferrari");
        ferrari.setWeight(1.7);

        Car ford = new Car();

        ford.setColor("blue");
        ford.setName("ford");
        ford.setWeight(1.6);

        ferrari.output();
        ford.output();

        //Для работы с классом дом

        House smallHouse = new House();
        House bigHouse = new House();

        smallHouse.setFlors(2);
        smallHouse.setYear(1998);
        smallHouse.setName("Small House");

        bigHouse.setFlors(20);
        bigHouse.setYear(2020);
        bigHouse.setName("Big House");

        System.out.println(smallHouse.getName());
        System.out.println(smallHouse.getFlors());
        System.out.println(smallHouse.getYear());
        System.out.println(smallHouse.yearsCount());

        System.out.println(bigHouse.getName());
        System.out.println(bigHouse.getFlors());
        System.out.println(bigHouse.getYear());
        System.out.println(bigHouse.yearsCount());

        //Для работы с классом дерево

        Tree oak = new Tree("Oak", 60);
        Tree maple = new Tree("Maple", 20, Life.Alive);
        Tree linden = new Tree();

    }
}
