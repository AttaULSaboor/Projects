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
 * Cookie class extends to TimsProduct and implements to consumable
 */

public class Cookie extends TimsProduct implements Consumable {
    private String description;
    private int calorieCount;

    /**
     * Constructor for Cookie
     * @param name Cookie name
     * @param description Cookie description
     * @param cost Cookie Cost
     * @param price Cookie price
     * @param calorieCount Cookie calorieCount
     */
    private Cookie (String name, String description, double cost, double price, int calorieCount){
        super(name,cost,price);
        this.description = description;
        this.calorieCount = calorieCount;
    }

    /**
     * Create Method for Cookie
     * @return myCookie
     */
    public static Cookie create (){
        Scanner input = new Scanner(System.in);
        String name;
        System.out.println("What is Cookie name? ");
        name = input.nextLine();
        String description;
        System.out.println("What is Cookie description? ");
        description = input.nextLine();
        int calorieCount;
        System.out.println("What is Cookie CalorieCount? ");
        calorieCount = input.nextInt();
        input.nextLine();
        double cost;
        System.out.println("What is Cookie cost? ");
        cost = input.nextDouble();
        input.nextLine();
        double price;
        System.out.println("What is Cookie price? ");
        price = input.nextDouble();
        input.nextLine();

        Cookie myCookie = new Cookie(name,description,cost,price,calorieCount);
        return myCookie;
    }

    /**
     * Get Method for Description
     * @return Cookie description
     */
    public String getDescription() {
        return description;
    }

    /**
     * Get Method for CalorieCount
     * @return Cookie calorieCount
     */
    public int getCalorieCount() {
        return calorieCount;
    }

    /**
     * Get Method for Consumption
     * @return Eat it or Drink it
     */
    public String getConsumptionMethod(){
        return "Eat It";
    }

    /**
     * To String method for Cookie
     * @return summary of the Cookie
     */
    public String toString (){
        return ("Type... Cookie { description =  " + this.getDescription() + ", calorieCount = " + this.getCalorieCount());
    }
}
