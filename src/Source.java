/**
 * MechWarrior 3rd Edition Character Generator
 *
 * --Created--
 * on: 3/17/14
 * by: Eric Hopkins
 *
 * --Last Edited--
 * on: 3/24/14
 * by: Eric Hopkins
 *
 *
 * This is the Source file of the program, the program runs through this file.
 */
import java.util.*;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.DocumentBuilder;
import org.w3c.dom.Document;
import org.w3c.dom.NodeList;
import org.w3c.dom.Node;
import org.w3c.dom.Element;
import java.io.File;

public class Source {

    public static void main(String args[]) {


        //create a linked list to have the skills into
        List<Skill> completeSkillsList = new LinkedList<Skill>();

        /*
        Character char1 = new Character("testCharacter", 24);

        //tests: these should of course work
        System.out.println(char1.getName());
        System.out.println(char1.getAge());

        //space
        System.out.println();

        char1.addToSkillsList(new Skill(false, "Language", "English"));
        char1.addToSkillsList(new Skill(false, "Perception", ""));
        char1.addToSkillsList(new Skill(false, "Piloting", "Mech"));
        char1.addToSkillsList(new Skill(false, "Academic", "Lyran History"));
        char1.addToSkillsList(new Skill(false, "Zero-G Operations", ""));

        char1.printSkillsList();
        */

        for (Skill s:completeSkillsList) {

            System.out.println("Name: " + s.getName()+ "\nIs difficult: " + s.getDifficult());
        }

    }
}
