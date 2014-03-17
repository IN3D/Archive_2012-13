/**
 * MechWarrior 3rd Edition Character Generator
 *
 * --Created--
 * on: 2/26/14
 * by: Eric Hopkins
 *
 * --Last Edited--
 * on: 3/17/14
 * by: Eric Hopkins
 *
 *
 * This file contains the base class for Skills.
 */
public class Skill {

    //private
    private boolean difficult;
    private int points;
    private int bonus;
    private String name;
    private String subName;

    //public


    //constructor
    public Skill(boolean difficult, String name, String subName) {
        this.difficult = difficult;
        this.points = 0;
        this.bonus = 0;
        this.name = name;
        this.subName = subName;

    }

    //getters
    public boolean getDifficult() {
        return difficult;
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
