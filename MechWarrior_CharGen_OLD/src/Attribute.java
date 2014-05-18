/**
 * MechWarrior 3rd Edition Character Generator
 *
 * --Created--
 * on: 3/17/14
 * by: Eric Hopkins
 *
 * --Last Edited--
 * on: 3/17/14
 * by: Eric Hopkins
 *
 *
 * This file contains the data for characters attributes.
 */
public class Attribute {

    //private
    private int threshold;
    private int value;
    private int maxValue;
    private String name;

    //public


    //constructor
    Attribute(int threshold, int value, int maxValue, String name) {
        this.threshold = threshold;
        this.value = value;
        this.maxValue = maxValue;
        this.name = name;
    }


    //getters
    public int getThreshold() {
        return this.threshold;
    }

    public int getValue() {
        return this.value;
    }

    public int getMaxValue() {
        return this.maxValue;
    }

    public String getName() {
        return this.name;
    }


    //setters
    //included for convention, generally avoid, use adjustThreshold
    public void setThreshold(int threshold) {
        this.threshold = threshold;
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


    //methods
    public void adjustThreshold(int adjustment) {
        this.threshold += adjustment;
    }
}
