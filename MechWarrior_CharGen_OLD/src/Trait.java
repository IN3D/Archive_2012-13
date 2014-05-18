/**
 * MechWarrior 3rd Edition Character Generator
 *
 * --Created--
 * on: 2/26/14
 * by: Eric Hopkins
 *
 * --Last Edited--
 * on: 3/27/14
 * by: Eric Hopkins
 *
 *
 * This file contains the base class for character traits.
 */
public class Trait {

    //private
    private boolean fromGen; //if a trait should generally only be gained during character generation (ie. not in the buy phase)
    private boolean odd;
    private boolean addition;
    private int level;
    private int modifier;
    private int value;
    private int maxValue;
    private String name;


    //public


    //constructor
    //default
    public Trait() {
        this(false, false, false, 0, 0, "What am I?!");
    }

    //standard
    public Trait(boolean fromGen, boolean odd, boolean addition, int modifier, int maxValue, String name) {
        this.fromGen = fromGen;
        this.odd = odd;
        this.addition = addition;
        this.level = 0;
        this.modifier = modifier;
        this.value = 0;
        this.maxValue = maxValue;
        this.name = name;
    }


    //getters
    public boolean getFromGen() {
        return fromGen;
    }

    public boolean getOdd() {
        return odd;
    }

    public boolean getAddition() {
        return addition;
    }

    public int getLevel() {
        return level;
    }

    public int getModifier() {
        return modifier;
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

    public void setOdd(boolean odd) {
        this.odd = odd;
    }

    public void setAddition(boolean addition) {
        this.addition = addition;
    }

    public void setLevel(int level) {
        this.level = level;
    }

    public void setModifier(int modifier) {
        this.modifier = modifier;
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

    //methods
    public void incrementLevel(int level) {

        //no matter what, this should always happen
        this.level += level;


        if(this.odd) { //if the value is supposed to be only odd numbers

            this.value = ((this.level) + (this.level - 1));
        } else if (this.addition) { //if he modifier is supposed to be added

            this.value = (this.level + this.modifier);
        } else { //this is the default method

            this.value = (this.level * this.modifier);
        }
    }
}