package Assignment8_000395780;

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
 * Class for Shape
 */
public class Shape {
    private Color BorderColor;
    private Color FillColor;
    private double BorderWidth;
    private double Xcordinate;
    private double Ycordinate;

    /**
     * Constructor for Shape
     * @param BorderColor Shape Border Color
     * @param FillColor  Shape Fill Color
     * @param BorderWidth Shape Border Width
     * @param Xcordinate Shape x Cordinate
     * @param Ycordinate Shape Y Cordinate
     */
    public Shape(Color BorderColor, Color FillColor, double BorderWidth, double Xcordinate, double Ycordinate) {
        this.BorderColor = BorderColor;
        this.FillColor = FillColor;
        this.BorderWidth = BorderWidth;
        this.Xcordinate = Xcordinate;
        this.Ycordinate = Ycordinate;
    }

    /**
     * Het Method for Border Color in Shape
     * @return Border Color
     */
    public Color getBorderColor() {
        return BorderColor;
    }

    /**
     * Set Method for Border Color in shape
     * @param borderColor set Border color
     */
    public void setBorderColor(Color borderColor) {
        BorderColor = borderColor;
    }

    /**
     * Get Method for Fill Color in Shape
     * @return Fill Color
     */
    public Color getFillColor() {
        return FillColor;
    }

    /**
     * Set Method for Fill color in Shape
     * @param fillColor set fill color
     */
    public void setFillColor(Color fillColor) {
        FillColor = fillColor;
    }

    /**
     * Get Method for Border Width in Shape
     * @return Border Width
     */
    public double getBorderWidth() {
        return BorderWidth;
    }

    /**
     * Set Method for Border Width in Shape
     * @param borderWidth Set Border Width
     */
    public void setBorderWidth(double borderWidth) {
        BorderWidth = borderWidth;
    }

    /**
     * Get Method for X Cordinate in shape
     * @return X Cordinate
     */
    public double getXcordinate() {
        return Xcordinate;
    }

    /**
     * Set MEthod for X Cordinate in shape
     * @param xcordinate set X cordinate
     */
    public void setXcordinate(double xcordinate) {
        Xcordinate = xcordinate;
    }

    /**
     * Get Method for Y Cordinate in shape
     * @return Y Cordinate
     */
    public double getYcordinate() {
        return Ycordinate;
    }

    /**
     * Set Method for Y Cordinate in shape
     * @param ycordinate Set y Cordinate
     */
    public void setYcordinate(double ycordinate) {
        Ycordinate = ycordinate;
    }
}