package Assignment7_000395780;

import java.util.Scanner;

/**
 * Program: Assignment 7.java
 * Author:  Atta UL Saboor
 * Date:    26/03/2020
 *
 * Purpose: The purpose of this assignment is about polymorphism, abstract classes, and interfaces.
 * Shows an arrangement of classes with inheritance, association and implementation relationships between them.
 *
 * Statement of Authorship :    I, Atta UL Saboor, 000395780 certify that this
 *                              material is my original work. No other person's
 *                              work has been used without due acknowledgement.
 *
 * @author Atta UL Saboor
 */

/**
 * GiftCard class extends to TimsProduct
 */

public class GiftCard extends TimsProduct{

        private int amount;

    /**
     * Constructor for GiftCard
     * @param name Giftcard name
     * @param amount GiftCard amount
     * @param cost GiftCard cost
     * @param price GiftCard price
     */

        private GiftCard(String name, int amount, double cost, double price){
            super(name,cost,price);
            this.amount = amount;
        }

    /**
     * Create Method for GiftCard
     * @return myGiftCard
     */

    public static GiftCard create(){
            Scanner input = new Scanner(System.in);
            String name;
            System.out.println("what is Gift Card name? ");
            name = input.nextLine();
            int amount;
            System.out.println("What is the gift card amount? ");
            amount = input.nextInt();
            input.nextLine();
            double cost;
            System.out.println("what is GiftCard cost? ");
            cost = input.nextDouble();
            input.nextLine();
            double price;
            System.out.println("What is GiftCard Price? ");
            price = input.nextDouble();
            input.nextLine();

            GiftCard myGiftCard = new GiftCard(name,amount,cost,price);
            return myGiftCard;
        }

    /**
     * Get Method for GiftCard Amount
     * @return GiftCard Amount
     */
    public int getAmount() {
        return amount;
    }

    /**
     * To String Method for GiftCard
     * @return Summary of the GiftCard
     */
    public String toString (){

            return ("Type... GiftCard { Size =  " + this.getAmount());
        }
}
