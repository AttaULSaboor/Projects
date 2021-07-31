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

public class Elves extends Humanoids {

    private String Clan;
    private Hobbits BestFriend;

    /**
     * The constructor for the Elves class
     * @param Name  Humanoid name
     * @param Strength Humanoid strength
     * @param Dexterity Humanoid Dexterity
     * @param Armour Humanoid Armour
     * @param Moxie Humanoid Moxie
     * @param Coins Humanoid Coins
     * @param Health Humanoid Health
     */

    public Elves (String Name,int Strength, int Dexterity, int Armour, int Moxie, int Coins, int Health) {
        super(Name,Strength,Dexterity,Armour,Moxie,Coins,Health);
    }
    /**
     * The constructor for the Elves class
     * @param Name
     */
    public Elves (String Name) {
        super(Name);
    }

    /**
     * Get Clan for 'forest' or 'city'
     * @return
     */
    public String getClan() {
        if (Clan == "forest" || Clan == "city"){
            //Clan name is valid
        }else {
            System.out.println("Clan name is invalid");
        }
        return Clan;
    }

    /**
     * Get Best Friend
     * Elves Exactly One Hobbit that they consider their best friend
     * @return
     */
    public Hobbits getBestFriend() {
        return BestFriend;
    }

    /**
     * Set Best Friend
     * @param bestFriend
     */
    public void setBestFriend(Hobbits bestFriend) {
        BestFriend = bestFriend;
    }
}

