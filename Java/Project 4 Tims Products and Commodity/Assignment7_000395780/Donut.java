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
 * Donut class extends for TimsProduct and implements to consumable product
 */

public class Donut extends TimsProduct implements Consumable {
    private String description;
    private int calorieCount;

    /**
     * Constructor for Donut
     * @param name Donut name
     * @param description Donut Description
     * @param cost Donut Cost
     * @param price Donut Price
     * @param calorieCount Donut CalorieCount
     */
    private Donut (String name, String description, double cost, double price, int calorieCount){
        super(name,cost,price);
        this.description = description;
        this.calorieCount = calorieCount;
    }

    /**
     * Donut Create Method
     * @return myDonut
     */
    public static Donut create (){
        Scanner input = new Scanner(System.in);
        String name;
        System.out.println("What is Donut name? ");
        name = input.nextLine();
        String description;
        System.out.println("What is Donut description? ");
        description = input.nextLine();
        int calorieCount;
        System.out.println("What is Donut CalorieCount? ");
        calorieCount = input.nextInt();
        input.nextLine();
        double cost;
        System.out.println("What is Donut cost price? ");
        cost = input.nextDouble();
        input.nextLine();
        double price;
        System.out.println("What is Donut price? ");
        price = input.nextDouble();
        input.nextLine();

        Donut myDonut = new Donut(name,description,cost,price,calorieCount);
        return myDonut;
    }

    /**
     * Get Method for Description
     * @return Donut Description
     */
    public String getDescription() {
        return description;
    }

    /**
     * Get Method for Donut CalorieCount
     * @return Donut CalorieCount
     */
    public int getCalorieCount() {
        return calorieCount;
    }

    /**
     * Get Method for Consumption
     * @return Eat it or drink it
     */
    public String getConsumptionMethod() {
        return "Eat it";
    }

    /**
     * to string Method for Donut
     * @return Summary of the Donut
     */
    public String toString () {
        return ("Type... Donut { description =  " + this.getDescription() + ", calorieCount = " + this.getCalorieCount());
    }
}