package ITMOJavaBasic.Exercise03;

public class Tree {
    private String name;
    private Integer age;
    private Life life;

    public Tree(String name, Integer age) {
        this.name = name;
        this.age = age;
    }

    public Tree(String name, Integer age, Life life) {
        this.name = name;
        this.age = age;
        this.life = life;
    }

    public Tree() {
        System.out.println("Пустой конструктор без параметров сработал");
    }
}
