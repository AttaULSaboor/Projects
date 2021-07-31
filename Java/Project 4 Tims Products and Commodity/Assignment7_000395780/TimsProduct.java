package Assignment7_000395780;

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
 *Abstract class for TimsProduct and implements to commodity
 */
public abstract class TimsProduct implements Commodity {
    private String name;
    private double cost;
    private double price;

    /**
     * Constructor for Tims Product
     * @param name Product Name
     * @param cost Product Cost
     * @param price product price
     */
    public TimsProduct (String name, double cost, double price){
        this.name = name;
        this.cost = cost;
        this.price = price;
    }

    /**
     * Get Method for Name
     * @return Product Name
     */
    public String getName() {
        return name;
    }

    /**
     * Get Method for ProductionCost
     * @return Product cost
     */
    public double getProductionCost() {
        return cost;
    }

    /**
     * Get Method for RetailPrice
     * @return Product Price
     */
    public double getRetailPrice() {
        return price;
    }

    /**
     * To String Method for Tims Product
     * @return
     */
    public String toString (){
        return "";
    }
}

