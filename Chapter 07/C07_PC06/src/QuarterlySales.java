public class QuarterlySales {

    private int quaters;
    private int divs;

    /** Getters **/
    public int getQuaters() {
        return quaters;
    }

    public int getDivs() {
        return divs;
    }
    /** Setters **/
    public void setQuaters(int quaters) {
        this.quaters = quaters;
    }

    public void setDivs(int divs) {
        this.divs = divs;
    }

    /** Constructors **/
    public QuarterlySales() {
        quaters = 4;
        divs = 6;

        double [][] Sales = new double[divs][quaters];
    }
}
