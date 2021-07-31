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
 * Class for Tims order
 */

public class TimsOrder{
    private int size;
    private String name;

    private TimsProduct[] timsProducts;

    /**
     * Constructor for Tims Order
     * @param name  Tims order name
     * @param size Tims order Size
     */
    private TimsOrder (String name, int size){
        this.name = name;
        this.size = size;
    }

    /**
     * Create Method for Timsorder
     * @return Tims order
     */
    public static TimsOrder create (){
        Scanner input = new Scanner(System.in);
        String name;
        System.out.println("Please enter your name");
        name = input.nextLine();
        int size;
        System.out.println("How many product you want to order? ");
        size = input.nextInt();
        input.nextLine();
        TimsOrder order = new TimsOrder(name, size);
        order.timsProducts = new TimsProduct[size];

        // loop through all the products in the order
        for (int x = 0 ; x < order.timsProducts.length; x++) {
            String productType;
            System.out.println("What type of product you want? ");
            productType = input.nextLine();

            // Check to see what type of product we have
            if (productType.contains("Donut")) {
                Donut d = Donut.create();
                order.timsProducts[x] = d;
            }

            if (productType.contains("Mug")) {
                Mug m = Mug.create();
                order.timsProducts[x] = m;
            }

            if (productType.contains("GiftCard")) {
                GiftCard g = GiftCard.create();
                order.timsProducts[x] = g;
            }

            if (productType.contains("Cookie") ) {
                Cookie c = Cookie.create();
                order.timsProducts[x] = c;
            }

        }
        return order;
    }

    /**
     * Get Method for AmountDue
     * @return TimsOrder Amount Due
     */
    public double getAmountDue() {
        double AmountDue = 0.0;

        for (int x = 0 ; x < this.timsProducts.length; x++){
            AmountDue = AmountDue + this.timsProducts[x].getRetailPrice();
        }
        return AmountDue;
    }

    /**
     * to string method for tims product
     * @return summary of the order
     */
    public String toString () {
        String output = "";
        System.out.println("Order for :" + this.name);
        for (int x = 0; x < this.timsProducts.length; x++) {
            output = output + ("TimsProduct { name = " + this.timsProducts[x].getName() + ", " +
                    "cost = " + Double.toString(this.timsProducts[x].getProductionCost()) + ", " +
                    "price = " + Double.toString(this.timsProducts[x].getRetailPrice())) + "}" + "\n";
            if (this.timsProducts[x] instanceof Donut) {
                Donut d = (Donut) this.timsProducts[x];
                output = output + ("Type... Donut { description =  " + d.getDescription() +
                        ", calorieCount = " + d.getCalorieCount() + "}" + "\n");
            }
            if (this.timsProducts[x] instanceof Mug) {
                Mug m = (Mug) this.timsProducts[x];
                //Display the color in hex format
                output = output + ("Type... Mug { color =  " + String.format("0x#%02x%02x%02x", (int)m.getColor().getRed(), (int)m.getColor().getGreen(), (int)m.getColor().getBlue()) + "}" + "\n");
            }
            if (this.timsProducts[x] instanceof GiftCard) {
                GiftCard b = (GiftCard) this.timsProducts[x];
                output = output + ("Type... GiftCard { Size =  " + b.getAmount() + "}" + "\n");
            }
            if (this.timsProducts[x] instanceof Cookie) {
                Cookie c = (Cookie) this.timsProducts[x];
                output = output + ("Type... Cookie { description =  " + c.getDescription() +
                        ", calorieCount = " + c.getCalorieCount() + "}" + "\n");
            }
        }

        return output;
    }
}
