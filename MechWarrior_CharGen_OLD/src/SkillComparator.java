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
 * This file is used for the comparison of the skill linked list. This comparison uses the skill's names to alphabetize
 * them.
 */
import java.util.Collections;
import java.util.Comparator;
import java.util.LinkedList;

public class SkillComparator implements Comparator<Skill> {

    //NOTE: This should alphabetize names A-Z, if it is going Z-A turn the returns around.
    @Override
    public int compare(Skill s1, Skill s2) {

        if (s1.getName().compareTo(s2.getName()) > 0) {
            return 1;

        } else {
            return -1;

        }
    }
}
