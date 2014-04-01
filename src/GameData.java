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
 * This file contains the linked lists for that hold all of the data that is read in from the XML files.
 */

import java.util.*;

public class GameData {

    //these lists will contain all data used by the program during runtime
    public static List<Skill> completeSkillsList = new LinkedList<Skill>();

    public static List<Trait> completeTraitList = new LinkedList<Trait>();

    //TODO: Affiliations
    /*
     * Sub-Affiliations will very likely need a list of their own. But I'm not 100% sure I can't make them a part of the
     * Affiliations list proper.
     */

    //TODO: Lifepaths
    /*
     * Life paths are going to be more complex data structures than the skills or traits. I want to break them down into
     * The stages. So have a list for Early Life, Late Childhood, Higher Education, and Adulthood.
     */

}
