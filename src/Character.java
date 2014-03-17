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
 *
 * This file contains the base class for Characters.
 */
import java.util.*;

public class Character {
    //TODO: create a class to facilitate sorting the object lists
    //private
    private String name;
    private int age;

    //lists
    private List<Skill> skillsList = new LinkedList<Skill>();
    private List<Trait> traitsList = new LinkedList<Trait>();

    //public


    
    //getters
    public String getName() {
        return name;
    }

    public int getAge() {
        return age;
    }


    //setters
    public void setName(String name) {
        this.name = name;
    }

    public void setAge(int age) {
        this.age = age;
    }


    //other methods
    public void addToSkillsList(Skill skill) {
        skillsList.add(skill);
        //TODO: sort list after an addition
    }

    public void addToTraitsList(Trait trait) {
        traitsList.add(trait);
        //TODO: sort list after an addition
    }

    public void removeFromSkillsListAt(int i) {
        skillsList.remove(i);
    }

    public void removeFromTraitsListAt(int i) {
        traitsList.remove(i);
    }
}
