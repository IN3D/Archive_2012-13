/**
 * MechWarrior 3rd Edition Character Generator
 * Created by Eric Hopkins on 2/26/14.
 */
public class Skill {

    //private
    private boolean difficult;
    private int points;
    private int bonus;
    private String name;
    private String subName;

    //public


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
