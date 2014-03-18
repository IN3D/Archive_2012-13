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
 * This file is used for the comparison of the trait linked list. This comparison uses the trait's names to alphabetize
 * them.
 */
import java.util.Collections;
import java.util.Comparator;
import java.util.LinkedList;

public class TraitComparator implements Comparator<Trait> {

    //NOTE: This should alphabetize names A-Z, if it is going Z-A turn the returns around.
    @Override
    public int compare(Trait t1, Trait t2) {

        if (t1.getName().compareTo(t2.getName()) < 0) {
            return 1;

        } else {
            return -1;
        }
    }
}
