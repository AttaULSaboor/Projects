package Assignment8_000395780;

import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;

/**
 * Program: Assignment 8.java
 * Author:  Atta UL Saboor
 * Date:    08/04/2020
 *
 * Purpose: The purpose of this assignment is to create a drawing app that will require the use of encapsulation,
 * inheritance, polymorphism, association, exception handling and ArrayLists.
 *
 * Statement of Authorship :    I, Atta UL Saboor, 000395780 certify that this
 *                              material is my original work. No other person's
 *                              work has been used without due acknowledgement.
 *
 * @author Atta UL Saboor
 */

/**
 * Circle Class extends to shape and interface to Drawable
 */
public class Circle extends Shape implements Drawable {

    public static double Radius = 100;

    public Circle(Color BorderColor, Color FillColor, double BorderWidth, double Xcordinate, double Ycordinate) {
        super(BorderColor, FillColor, BorderWidth, Xcordinate, Ycordinate);
    }

    /**
     * Override draw method for shape
     * @param gc Draw
     */
    @Override
    public void Draw(GraphicsContext gc) {
        gc.setStroke(this.getBorderColor());
        gc.setLineWidth(this.getBorderWidth());
        gc.strokeOval(this.getXcordinate(), this.getYcordinate(), Radius, Radius);

        gc.setFill(this.getFillColor());
        gc.fillOval(this.getXcordinate(), this.getYcordinate(), Radius, Radius);
    }
}