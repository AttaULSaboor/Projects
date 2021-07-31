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

public class Humanoids {

    private String Name;
    private int Strength;
    private int Dexterity;
    private int Armour;
    private int Moxie;
    private int Coins;
    private int Health;

    /**
     * The constructor for the Humanoid class
     * @param Name Humanoid name
     * @param Strength Humanoid strength
     * @param Dexterity Humanoid Dexterity
     * @param Armour Humanoid Armour
     * @param Moxie Humanoid Moxie
     * @param Coins Humanoid Coins
     * @param Health Humanoid Health
     */
    public Humanoids(String Name,int Strength, int Dexterity, int Armour, int Moxie, int Coins, int Health){
        this.Name = Name;
        this.Strength = Strength;
        this.Dexterity = Dexterity;
        this.Armour = Armour;
        this.Moxie = Moxie;
        this.Coins = Coins;
        this.Health = Health;
    }

    /**
     * The Constructor for the Humanoids Name
     * @param Name
     */
    public Humanoids(String Name){
        this.Name = Name;
        this.Strength = 0;
        this.Dexterity = 0;
        this.Armour = 0;
        this.Moxie = 0;
        this.Coins = 0;
        this.Health = 0;

    }
    public String getName() {
        return Name;
    }

    public int getStrength() {
        return Strength;
    }

    /**
     * The Set Strength
     * @param strength
     */
    public void setStrength(int strength) {
        if (strength == 1 ){
            // increment by 1
            strength = strength + 1;
        }else if ( strength == -1 ){
            // substract by 1
            strength = strength -1;
        }else {
            // invalid entry
        }

        if (strength < 0 || strength > 20) {
            // strength cannot less than 0 order greater than 20
        }
        this.Strength = strength;
    }

    /**
     * The get Dexterity
     * @return
     */
    public int getDexterity() {
        return Dexterity;
    }

    /**
     * The Set Dexterity
     * @param dexterity
     */
    public void setDexterity(int dexterity) {
        if (dexterity == 1 ){
            // increment by 1
            dexterity = dexterity +1;
        }else if (dexterity == -1){
            // substract by 1
            dexterity = dexterity -1;
        }else {
            System.out.println("invalid entry");
        }

        if (dexterity < 0 || dexterity > 20) {
            System.out.println("dexterity cannot less than 0 order greater than 20");
        }
        this.Dexterity = dexterity;
    }

    /**
     * The get Armour
     * @return
     */
    public int getArmour() {
        return Armour;
    }

    /**
     * The Set Armour
     * @param armour
     */
    public void setArmour(int armour) {
        if (armour == 1){
            // increment by 1
            armour = armour +1;
        }else if (armour == -1){
            // substract by 1
            armour = armour -1;
        }else {
            System.out.println("invalid entry");
        }

        if (armour < 0 || armour > 20) {
            System.out.println("armour cannot less than 0 order greater than 20");
        }
        this.Armour = armour;
    }
    /**
     * The get Moxie
     * @return
     */
    public int getMoxie() {
        return Moxie;
    }

    /**
     * The  set Moxie
     * @param moxie
     */
    public void setMoxie(int moxie) {
        if (moxie == 1){
            // increment by 1
            moxie = moxie +1;
        }else if (moxie == -1){
            // substract by 1
            moxie = moxie -1;
        }else {
            System.out.println("invalid entry");
        }

        if (moxie < 0 || moxie > 20) {
            System.out.println("moxie cannot less than 0 order greater than 20");
        }
        this.Moxie = moxie;
    }

    /**
     * The get Coins
     * @return
     */
    public int getCoins() {
        return Coins;
    }

    /**
     * The Set Coins
     * @param coins
     */
    public void setCoins(int coins) {
        if (coins < 0 ){
            System.out.println("Coin Value must be greater then or eual to zero");
        }
        this.Coins = coins;
    }

    /**
     * The get Health
     * @return
     */
    public int getHealth() {
        return Health;
    }

    /**
     * The Set Health
     * @param health
     */
    public void setHealth(int health) {
        if (health > 0 ){
            // Humanoids is Alive
        }else if (health <= 0){
            System.out.println("Humanoids is dead");
        }
        this.Health = health;
    }

    /**
     * For Humanoids Attack
     * @return
     */
    public int Attack(){
        return (this.Strength*this.Dexterity*this.Health)/3;
    }

    /**
     * For humanoids Defends
     * @param Demage
     * @return
     */
    public int Defends(int Demage) {
        // Only Alow Division Where Demage is greater then Armour
        if(Demage > this.Armour){
            this.setHealth(Demage / this.Armour);
        }else {
            // Otherwise Divide by 1
            this.setHealth(Demage / 1);
        }
        return (this.Health);
    }

    /**
     * For String toString Method for Humanoids
     * @return
     */
    @Override
    public String toString() {
        return "Humanoids{" +
                "Name='" + Name + '\'' +
                "Health='" + this.Health + '\'' +
                "Strength='" + this.Strength + '\'' +
                "Dextrity='" + this.Dexterity + '\'' +
                "Armour='" + this.Armour + '\'' +
                "Moxie='" + this.Moxie + '\'' +
                "Coins='" + this.Coins + '\'' +
                "Strength='" + this.Strength + '\'' +
                '}';
    }
}

