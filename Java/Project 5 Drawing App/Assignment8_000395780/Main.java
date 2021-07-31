package Assignment8_000395780;

import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.event.Event;
import javafx.event.EventHandler;
import javafx.scene.Scene;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.*;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.stage.Stage;
import java.util.ArrayList;

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

/***
 * Main class extends to application
 */
public class Main extends Application {

    public String SelectedShape;
    public ArrayList<Shape> ShapeArray = new ArrayList<>();

    @Override
    public void start(Stage stage) throws Exception {
        //Set application default settings
        Pane root = new Pane();
        Scene scene = new Scene(root, 880, 600); // set the size here
        stage.setTitle("COMP0062 - Assignment 8 - (Atta UL Saboor)"); // set the window title here
        stage.setScene(scene);
        stage.setResizable(false);
        // TODO: Add your GUI-building code here

        // Create the GUI components
        Canvas canvas = new Canvas(900, 520);
        GraphicsContext gc = canvas.getGraphicsContext2D();
        drawDefaultBackground(gc);

        Button RectangleBtn = new Button("Rectangle");
        Button CircleBtn = new Button("Circle");
        Button ClearBtn = new Button("Clear");
        Button ResetShapeBtn = new Button("Reset Shape Color");
        Label InstructionLabel = new Label("INSTRUCTIONS \n \n"+
                                            "o Select the shape you want to draw \n"+
                                            "o Left Mouse Click to draw the selected shape \n"+
                                            "o Clear/Reset Shape Color using buttons \n"+
                                            "o Set Outline/Fill Color using Color picker");
        Label BorderLabel = new Label("Outline");
        ColorPicker BorderColorPicker = new ColorPicker(Color.BLACK);
        Label FillLabel = new Label("Fill");
        ColorPicker FillColorPicker = new ColorPicker(Color.RED);
        Label StrokeLabel = new Label("Stroke Width");
        TextField StrokeWidth = new TextField ("5");

        // Add components to the root
        root.getChildren().add(canvas);
        root.getChildren().add(RectangleBtn);
        root.getChildren().add(CircleBtn);
        root.getChildren().add(ClearBtn);
        root.getChildren().add(ResetShapeBtn);
        root.getChildren().add(BorderLabel);
        root.getChildren().add(InstructionLabel);
        root.getChildren().add(BorderColorPicker);
        root.getChildren().add(FillLabel);
        root.getChildren().add(FillColorPicker);
        root.getChildren().add(StrokeLabel);
        root.getChildren().add(StrokeWidth);

        // Configure the components (colors, fonts, size, location)
        RectangleBtn.setLayoutX(50);
        RectangleBtn.setLayoutY(450);
        RectangleBtn.setMinWidth(80);
        CircleBtn.setLayoutX(150);
        CircleBtn.setLayoutY(450);
        CircleBtn.setMinWidth(80);
        ClearBtn.setLayoutX(380);
        ClearBtn.setLayoutY(450);
        ClearBtn.setMinWidth(110);
        ResetShapeBtn.setLayoutX(510);
        ResetShapeBtn.setLayoutY(450);
        ResetShapeBtn.setMinWidth(100);
        InstructionLabel.setLayoutX(640);
        InstructionLabel.setLayoutY(450);
        BorderLabel.setLayoutX(50);
        BorderLabel.setLayoutY(505);
        BorderColorPicker.setLayoutX(50);
        BorderColorPicker.setLayoutY(525);
        FillLabel.setLayoutX(190);
        FillLabel.setLayoutY(505);
        FillColorPicker.setLayoutX(190);
        FillColorPicker.setLayoutY(525);
        StrokeLabel.setLayoutX(330);
        StrokeLabel.setLayoutY(505);
        StrokeWidth.setLayoutX(330);
        StrokeWidth.setLayoutY(525);
        StrokeWidth.setPrefWidth(110);

        // Add Event Handlers and do final setup
        //Rectangle Button Click Event Handler
        RectangleBtn.setOnAction(new EventHandler<ActionEvent>() {
            @Override public void handle(ActionEvent e) {
                SelectedShape = "rectangle";
                //Disable the button to show selected shape
                CircleBtn.setDisable(false);
                RectangleBtn.setDisable(true);
            }
        });
        //Circle Button Click Event Handler
        CircleBtn.setOnAction(new EventHandler<ActionEvent>() {
            @Override public void handle(ActionEvent e) {
                SelectedShape ="circle";
                CircleBtn.setDisable(true);
                RectangleBtn.setDisable(false);
            }
        });
        ClearBtn.setOnAction(new EventHandler<ActionEvent>() {
            @Override public void handle(ActionEvent e) {
                //Clear the canvas
                gc.clearRect(0, 0, canvas.getWidth(), canvas.getHeight());
                drawDefaultBackground(gc);
                //Clear the Array List
                ShapeArray.clear();
            }
        });
        ResetShapeBtn.setOnAction(new EventHandler<ActionEvent>() {
            @Override public void handle(ActionEvent e) {
                try {
                    gc.clearRect(0, 0, canvas.getWidth(), canvas.getHeight());
                    drawDefaultBackground(gc);
                    //looping through all the shape in the array
                    for (int i = 0; i < ShapeArray.size(); i++){
                        if (ShapeArray.get(i) instanceof Rectangle) {
                            Rectangle rec = (Rectangle) ShapeArray.get(i);
                            rec.setBorderColor(BorderColorPicker.getValue());
                            rec.setFillColor(FillColorPicker.getValue());
                            rec.setBorderWidth(Double.parseDouble(StrokeWidth.getText()));
                            rec.Draw(gc);
                        }
                        if (ShapeArray.get(i) instanceof Circle) {
                            Circle Cir = (Circle) ShapeArray.get(i);
                            Cir.setBorderColor(BorderColorPicker.getValue());
                            Cir.setFillColor(FillColorPicker.getValue());
                            Cir.setBorderWidth(Double.parseDouble(StrokeWidth.getText()));
                            Cir.Draw(gc);
                        }

                    }
                } catch (Exception i) {
                    new Alert(Alert.AlertType.ERROR, "Please enter a numeric Value for the Stroke Width").showAndWait();
                }
            }
        });
        BorderColorPicker.setOnAction(new EventHandler() {
            public void handle(Event t) {
                System.out.println(BorderColorPicker.getValue());
            }
        });
        FillColorPicker.setOnAction(new EventHandler() {
            public void handle(Event t) {
                System.out.println(FillColorPicker.getValue());
            }
        });
        //Event handler for the Canvas
        canvas.setOnMouseClicked(event -> {
            if (SelectedShape == "rectangle" || SelectedShape == "circle"){
                if (SelectedShape == "rectangle"){
                    try {
                        double Width = Double.parseDouble(StrokeWidth.getText());
                        Rectangle myRectangle = new Rectangle(BorderColorPicker.getValue(), FillColorPicker.getValue(), Width, event.getX(), event.getY());
                        myRectangle.Draw(gc);
                        ShapeArray.add(myRectangle);
                    } catch (Exception e) {
                        new Alert(Alert.AlertType.ERROR, "Please enter a numeric Value for the Stroke Width").showAndWait();
                    }
                }

                if (SelectedShape == "circle"){
                    try {
                        double Width = Double.parseDouble(StrokeWidth.getText());
                        Circle myCircle = new Circle(BorderColorPicker.getValue(), FillColorPicker.getValue(), Width, event.getX(), event.getY());
                        myCircle.Draw(gc);
                        ShapeArray.add(myCircle);
                    } catch (Exception e) {
                        new Alert(Alert.AlertType.ERROR, "Please enter a numeric Value for the Stroke Width").showAndWait();
                    }
                }
            }else {
                new Alert(Alert.AlertType.WARNING, "Please select a shape to Draw").showAndWait();
            }
        });

        // Show the stage
        stage.show();
    }
    //Set the Default background
    public void drawDefaultBackground(GraphicsContext gc){
        gc.setFill(Color.WHITE);
        gc.fillRect(0, 0, 900, 400);
    }

    public static void main(String[] args) {
        launch(args);
    }
}
