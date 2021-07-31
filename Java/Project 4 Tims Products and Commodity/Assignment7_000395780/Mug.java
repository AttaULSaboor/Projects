package Assignment7_000395780;

import javafx.scene.paint.Color;
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
 * Mug class extends to TimsProduct
 */

public class Mug extends TimsProduct{
    private Color color;

    /**
     * Constructor for Mug
     * @param name mug name
     * @param color mug color
     * @param cost mug cost
     * @param price mug price
     */
    private Mug ( String name, Color color, double cost, double price){
        super(name,cost,price);
        this.color = color;
    }

    /**
     * Create Method for Mug
     * @return myMug
     */
    public static Mug create(){
        Scanner input = new Scanner(System.in);
        String name;
        System.out.println("what is Mug name? ");
        name = input.nextLine();
        Color color;
        System.out.println("What color do you want? ");
        String colorString = input.nextLine();
        color = Color.web(colorString);
        double cost;
        System.out.println("what is Mug cost? ");
        cost = input.nextDouble();
        input.nextLine();
        double price;
        System.out.println("What is Mug Price? ");
        price = input.nextDouble();
        input.nextLine();

        Mug myMug = new Mug(name,color,cost,price);
        return myMug;
    }

    /**
     * Get Method for Color
     * @return color
     */
    public Color getColor() {

        return color;
    }

    /**
     * to String Method for Mug
     * @return summary of the Mug
     */
    public String toString (){

        return ("Type... Mug { color =  " + Integer.toString(this.getColor().hashCode()));
    }
}
