package Assignment6_000395780;

/**
 * Program: Assignment 6.java
 * Author:  Atta UL Saboor
 * Date:    16/03/2020
 *
 * Purpose: The purpose of this assignment is to effectively using inheritance, association, overriding,
 * and constructors. Make a game world into a set of classes that could serve as part of a model for a
 * game or gaming utility.
 *
 * Statement of Authorship :    I, Atta UL Saboor, 000395780 certify that this
 *                              material is my original work. No other person's
 *                              work has been used without due acknowledgement.
 *
 * @author Atta UL Saboor
 */

/**
 * For Healing
 */
public class Wizard {
    private int MagicRating;

    public int getMagicRating() {
        return MagicRating;
    }

    /**
     *Set Magic Rating
     * @param magicRating
     */
    public void setMagicRating(int magicRating) {
        if (magicRating >= 0 || magicRating <=20){
            //Magic rating is valid
        }else{
            System.out.println("Magic Rating is valid");
        }
        this.MagicRating = magicRating;
    }

    /**
     * For Cast Healing Spell
     * @return
     */
    public int CastHealingSpell () {
        int HealthBoostScore = 0;

        if (this.MagicRating > 0){
            HealthBoostScore = this.MagicRating / 2;
            this.MagicRating = this.MagicRating - 3;
        }else {
            System.out.println("You Cannot Cast the Spell");
        }
        return HealthBoostScore;
    }
}
