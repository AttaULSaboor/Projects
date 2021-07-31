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

public class Hobbits extends Humanoids {

    private int SuccessScore;

    /**
     * The constructor for the Hobbits class
     * @param Name  Humanoid name
     * @param Strength Humanoid strength
     * @param Dexterity Humanoid Dexterity
     * @param Armour Humanoid Armour
     * @param Moxie Humanoid Moxie
     * @param Coins Humanoid Coins
     * @param Health Humanoid Health
     */
    public Hobbits (String Name,int Strength, int Dexterity, int Armour, int Moxie, int Coins, int Health) {
        super(Name,Strength,Dexterity,Armour,Moxie,Coins,Health);
    }

    /**
     * The constructor for the Hobbits class
     * @param Name
     */
    public Hobbits (String Name) {
        super(Name);
    }

    /**
     * Get Success Score
     * @return
     */
    public int getSuccessScore() {
        return SuccessScore;
    }

    /**
     * Set Success Score
     * @param successScore
     */
    public void setSuccessScore(int successScore) {
        this.SuccessScore = successScore;
    }

    /**
     * A hobbit Steal Money
     */
    public void SteelMoney(){
        if (super.getHealth() > 0){
            this.SuccessScore = super.getDexterity()/2;
        }else {
            System.out.println("Hobbit is Dead");
        }
    }
}
