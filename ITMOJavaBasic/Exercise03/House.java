package ITMOJavaBasic.Exercise03;

import java.time.YearMonth;

public class House {

    private Integer flors;
    private Integer year;
    private String name;

    public Integer getFlors() {
        return flors;
    }

    public void setFlors(Integer flors) {
        this.flors = flors;
    }

    public Integer getYear() {
        return year;
    }

    public void setYear(Integer year) {
        this.year = year;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Integer yearsCount(){
        return YearMonth.now().getYear() - year;
    }
}
