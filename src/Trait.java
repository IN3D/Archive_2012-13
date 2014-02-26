/**
 * MechWarrior 3rd Edition Character Generator
 * Created by Eric Hopkins on 2/26/14.
 */
public class Trait {

    //private
    private boolean fromGen;
    private int value;
    private int maxValue;
    private String name;


    //public

    //getters
    public boolean getFromGen() {
        return fromGen;
    }

    public int getValue() {
        return value;
    }

    public int getMaxValue() {
        return maxValue;
    }

    public String getName() {
        return name;
    }


    //setters
    public void setFromGen(boolean fromGen) {
        this.fromGen = fromGen;
    }

    public void setValue(int value) {
        this.value = value;
    }

    public void setMaxValue(int maxValue) {
        this.maxValue = maxValue;
    }

    public void setName(String name) {
        this.name = name;
    }
}
