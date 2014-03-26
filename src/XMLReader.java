/**
 * MechWarrior 3rd Edition Character Generator
 *
 * --Created--
 * on: 3/26/14
 * by: Eric Hopkins
 *
 * --Last Edited--
 * on: 3/26/14
 * by: Eric Hopkins
 *
 *
 * This is a utility class to read in all of the XML files.
 */

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import java.io.File;

public class XMLReader {

    public static void readSkillsXML(String fileLocation) {

        //read in the xml file.
        try {

            File skillsFile = new File(fileLocation);

            DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder dBuilder = dbFactory.newDocumentBuilder();
            Document skillsDoc = dBuilder.parse(skillsFile);

            skillsDoc.getDocumentElement().normalize();

            NodeList skillNodes = skillsDoc.getElementsByTagName("skill");

            for (int i = 0; i < skillNodes.getLength(); i ++) {


                Node currentNode = skillNodes.item(i);

                if (currentNode.getNodeType() == Node.ELEMENT_NODE) {

                    Element currentElement = (Element) currentNode;

                    //temp variables to hold data parsed out of the xml
                    String tempName;
                    boolean tempDifficult;
                    boolean tempMilitary;


                    tempName = currentElement.getElementsByTagName("name").item(0).getTextContent();

                    tempDifficult = currentElement.getElementsByTagName("difficult").item(0).getTextContent().equals("true");

                    tempMilitary = currentElement.getElementsByTagName("military").item(0).getTextContent().equals("true");

                    GameData.completeSkillsList.add(new Skill(tempDifficult, tempMilitary, tempName));
                }
            }


        } catch (Exception e) {
            e.printStackTrace();
        }
    }

}
