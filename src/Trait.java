/**
 * MechWarrior 3rd Edition Character Generator
 * Created by Eric Hopkins on 2/26/14.
 *
 * This file contains the base class for character traits.
 */
public class Trait {

    //private
    private boolean fromGen; //if a trait should generally only be gained during character generation (ie. not in the buy phase)
    private int value;
    private int maxValue;
    private String name;


    //public


    //constructor
    public Trait(boolean fromGen, String name) {
        this.fromGen = fromGen;
        this.value = 0;
        this.maxValue = 0;
        this.name = name;
    }


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
	
	//included for convention, it would be more convenient to have a method that simply adds to value
	//rather than doing the math, then adding it to the value.
    public void setValue(int value) {
        
		if (value < this.maxValue) {
		
			this.value = this.maxValue;
		} else {
			
			this.value = value;
		}
    }
	
	//probably should never be used, but is here for convention
    public void setMaxValue(int maxValue) {
        this.maxValue = maxValue;
    }

    public void setName(String name) {
        this.name = name;
    }
}
