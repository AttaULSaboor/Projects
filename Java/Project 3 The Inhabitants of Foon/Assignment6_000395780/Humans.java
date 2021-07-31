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

public class Humans extends Humanoids {
    private Elves SwornEnemy;
    private Wizard IsWizard;
    private Fighter IsFighter;

    /**
     * The constructor for the Humans class
     * @param Name  Humanoid name
     * @param Strength Humanoid strength
     * @param Dexterity Humanoid Dexterity
     * @param Armour Humanoid Armour
     * @param Moxie Humanoid Moxie
     * @param Coins Humanoid Coins
     * @param Health Humanoid Health
     */

    public Humans (String Name,int Strength, int Dexterity, int Armour, int Moxie, int Coins, int Health) {
        super(Name,Strength,Dexterity,Armour,Moxie,Coins,Health);
    }
    /**
     * The constructor for the Human class
     * @param Name
     */
    public Humans (String Name) {
        super(Name);
    }

    /**
     * get Sworn Enemy
     * Many humans have an elves who is their sworn enemy
     * @return
     */
    public Elves getSwornEnemy() {
        return SwornEnemy;
    }

    /**
     * When Attack
     * @return
     */
    public int Attack(){
        return ((super.getStrength()*super.getDexterity()*super.getHealth())/3) * 2;
    }
}