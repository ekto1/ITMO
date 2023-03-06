package ITMOJavaBasic.Exercise03;

public class Study {
    private String course;

    //TODO

    public Study(String parametr) {
        this.course = parametr;
    }

    public String printCourse() {
        return this.course;
    }
}

class JavaProgram {
    public static void main(String[] args) {
        //TODO
        Study study = new Study("Изучение Java - это просто!");

        System.out.println(study.printCourse());
    }

}
