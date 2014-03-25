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

        //read in the xml file.
        try {

            File skillsFile = new File("./xml/skills.xml");
            DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder dBuilder = dbFactory.newDocumentBuilder();
            Document skillsDoc = dBuilder.parse(skillsFile);

            skillsDoc.getDocumentElement().normalize();

            System.out.println("XML parse test");
            System.out.println("Root element: " + skillsDoc.getDocumentElement().getNodeName());

            NodeList skillNodes = skillsDoc.getElementsByTagName("skill");

            for (int i = 0; i < skillNodes.getLength(); i ++) {


                Node currentNode = skillNodes.item(i);

                if (currentNode.getNodeType() == Node.ELEMENT_NODE) {

                    Element currentElement = (Element) currentNode;

                    String tempName;
                    boolean tempDifficult;

                    tempName = currentElement.getElementsByTagName("name").item(0).getTextContent();

                    if (currentElement.getElementsByTagName("difficult").item(0).getTextContent().equals("true")) {
                        tempDifficult = true;
                    } else {
                        tempDifficult = false;
                    }

                    completeSkillsList.add(new Skill(tempDifficult, tempName));

                }
            }


        } catch (Exception e) {
            e.printStackTrace();
        }





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

        for (Skill s:completeSkillsList) {

            System.out.println("Name: " + s.getName()+ "\n Is difficult: " + s.getDifficult());
        }

    }
}
