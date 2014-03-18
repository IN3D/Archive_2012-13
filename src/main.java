/**
 * MechWarrior 3rd Edition Character Generator
 *
 * --Last Edited--
 * on: 3/17/14
 * by: Eric Hopkins
 *
 * --Last Edited--
 * on: 3/18/14
 * by: Eric Hopkins
 *
 *
 * This is the Main file of the program, the program runs through this file.
 */
public class Main {

    public static void main(String args[]) {

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

    }
}
