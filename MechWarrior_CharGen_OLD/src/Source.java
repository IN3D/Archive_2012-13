/**
 * MechWarrior 3rd Edition Character Generator
 *
 * --Created--
 * on: 3/17/14
 * by: Eric Hopkins
 *
 * --Last Edited--
 * on: 3/27/14
 * by: Eric Hopkins
 *
 *
 * This is the Source file of the program, the program runs through this file.
 */

public class Source {

    public static void main(String args[]) {

        XMLReader.readSkillsXML("./xml/skills.xml");
        XMLReader.readTraitsXML("./xml/traits.xml");


        System.out.println();
        //PERSONAL NOTE: I'm not sure if I should encapsulate this skills list or not. I'm feeling like I aught to but
        //for convenience, I'll leave it as is for now.

        for (Skill s:GameData.completeSkillsList) {

            System.out.println("Name: " + s.getName()+ "\nIs difficult: " + s.getDifficult() + "\nIs military: " + s.getMilitary() + "\n");
        }

        System.out.println("\n\n|||====TRAITS====|||\n\n");

        for (Trait t:GameData.completeTraitList) {

            System.out.println("Name: " + t.getName() + "\nFrom Gen: " + t.getFromGen() + "\nIs Odd: " + t.getOdd() + "\nIs Addition: " +
            t.getAddition() + "\nModifier: " + t.getModifier() + "\nMax Value: " + t.getMaxValue() + "\n");
        }

    }
}
