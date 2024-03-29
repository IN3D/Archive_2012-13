/**
 * MechWarrior 3rd Edition Character Generator
 *
 * --Created--
 * on: 2/26/14
 * by: Eric Hopkins
 *
 * --Last Edited--
 * on: 3/18/14
 * by: Eric Hopkins
 *
 *
 * This file contains the base class for Characters.
 */
import java.util.*;

public class Character {

    //private
    private String name;
    private int age;
    private int characterPoints;

    //lists
    private List<Skill> skillsList = new LinkedList<Skill>();
    private List<Trait> traitsList = new LinkedList<Trait>();

    //public
    public Character(String name, int age) {
        this.name = name;
        this.age = age;
        this.characterPoints = 50; //default number

    }

    
    //getters
    public int getAge() {
        return age;
    }

    public int getCharacterPoints() {
        return characterPoints;
    }

    public String getName() {
        return name;
    }

    public List getSkillsList() {
        return skillsList;
    }


    //setters
    public void setAge(int age) {
        this.age = age;
    }

    public void setCharacterPoints(int characterPoints) {
        this.characterPoints = characterPoints;
    }

    public void setName(String name) {
        this.name = name;
    }


    //other methods
    public void addCharacterPoints(int addition) {
        this.characterPoints += addition;
    }

    public void addToSkillsList(Skill skill) {
        skillsList.add(skill);

        //sort after addition
        Collections.sort(skillsList, new SkillComparator());
    }

    public void addToTraitsList(Trait trait) {
        traitsList.add(trait);

        //sort after addition
        Collections.sort(traitsList, new TraitComparator());
    }

    public void printSkillsList() {

        for(Skill s:skillsList) {

            if(s.getSubName().equals("")) {
                System.out.println(s.getName());
            } else {
                System.out.println(s.getName() + "/" + s.getSubName());
            }
        }
    }

    public void removeFromSkillsListAt(int i) {
        skillsList.remove(i);
    }

    public void removeFromTraitsListAt(int i) {
        traitsList.remove(i);
    }

    /* NOTE: These were originally part of a test branch, both of the additions
     * now support inherent sorting. Whenever something is added to either list
     * this is left here just in case. */
    public void sortSkillList() {
        Collections.sort(skillsList, new SkillComparator());
    }

    public void sortTraitsList() {
        Collections.sort(traitsList, new TraitComparator());
    }
}
