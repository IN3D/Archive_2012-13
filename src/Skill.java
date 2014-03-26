/**
 * MechWarrior 3rd Edition Character Generator
 *
 * --Created--
 * on: 2/26/14
 * by: Eric Hopkins
 *
 * --Last Edited--
 * on: 3/26/14
 * by: Eric Hopkins
 *
 *
 * This file contains the base class for Skills.
 */
public class Skill {

    //private
    private boolean difficult;
    private boolean military;
    private int points;
    private int bonus;
    private String name;
    private String subName;

    //public


    //constructors

    //default
    public Skill() {
        this(false, false, "WHAT AM I??!");
    }

    //primary
    public Skill(boolean difficult, boolean military, String name) {
        this.difficult = difficult;
        this.military = military;
        this.points = 0;
        this.bonus = 0;
        this.name = name;
        this.subName = "";
    }

    //alternate
    public Skill(boolean difficult, boolean military, String name, String subName) {
        this.difficult = difficult;
        this.military = military;
        this.points = 0;
        this.bonus = 0;
        this.name = name;
        this.subName = subName;

    }

    //getters
    public boolean getDifficult() {
        return difficult;
    }

    public boolean getMilitary() {
        return military;
    }

    public int getPoints() {
        return points;
    }

    public int getBonus() {
        return bonus;
    }

    public String getName() {
        return name;
    }

    public String getSubName() {
        return subName;
    }


    //setters
    public void setDifficult(boolean difficult) {
        this.difficult = difficult;
    }

    public void setMilitary(boolean military) {
        this.military = military;
    }

    public void setPoints(int points) {
        this.points = points;
    }

    public void setBonus(int bonus) {
        this.bonus = bonus;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setSubName(String subName) {
        this.subName = subName;
    }
}
