/**
 * MechWarrior 3rd Edition Character Generator
 *
 * --Last Edited--
 * on: 3/17/14
 * by: Eric Hopkins
 *
 * --Last Edited--
 * on: 3/17/14
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

        char1.addToSkillsList(new Skill(false, "C_skill", ""));
        char1.addToSkillsList(new Skill(false, "A_skill", ""));
        char1.addToSkillsList(new Skill(false, "B_skill", ""));

        char1.sortSkillList();

        char1.printSkillsList();

        System.out.println("----");
        System.out.println("that should have printed something");

    }
}
