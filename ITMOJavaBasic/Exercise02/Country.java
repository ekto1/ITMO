package ITMOJavaBasic.Exercise02;

public class Country {

    private String name;
    private String capital;
    private Long population;
    private String language;
    private Integer square;

    public Country() {
    }

    public Country(String name, String capital, Long population, String language, Integer square) {
        this.name = name;
        this.capital = capital;
        this.population = population;
        this.language = language;
        this.square = square;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getCapital() {
        return capital;
    }

    public void setCapital(String capital) {
        this.capital = capital;
    }

    public Long getPopulation() {
        return population;
    }

    public void setPopulation(Long population) {
        this.population = population;
    }

    public String getLanguage() {
        return language;
    }

    public void setLanguage(String language) {
        this.language = language;
    }

    public Integer getSquare() {
        return square;
    }

    public void setSquare(Integer square) {
        this.square = square;
    }
}
