/**
 * MechWarrior 3rd Edition Character Generator
 * Created by Eric Hopkins on 2/26/14.
 */
import java.util.*;

public class Character {

    //private
    private String name;
    private int age;


    //public

    /*note: I'm not sure these -should- actually be public
    but given my lack of experience with linked lists, I'll just
    use it public for the the moment*/
    
    //lists
    List<Skill> skillsList = new LinkedList<Skill>();
    List<Trait> traitsList = new LinkedList<Trait>();
    
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
}
