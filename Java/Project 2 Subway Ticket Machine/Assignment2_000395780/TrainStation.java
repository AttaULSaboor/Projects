/*
This class is used as view for Ticket Machine.I Completed 28 jan, 2020
author Atta UL Saboor
*/
package Assignment2_000395780;
import java.util.Scanner;
import javafx.application.Application;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;
import javafx.stage.Stage;
public class TrainStation extends Application{
    /**
     * Sets up the stage.
     * @param stage The first stage
     */
    @Override
    public void start(Stage stage) {
        stage.setTitle("Ticket Machines");
        Canvas canvas = new Canvas(500, 400);
        Group root = new Group();
        Scene scene = new Scene(root);
        root.getChildren().add(canvas);
        stage.setScene(scene);
        stage.show();
        GraphicsContext gc = canvas.getGraphicsContext2D();
        // This code starts animation
        Thread t = new Thread(() -> animate(gc));
        t.start();
    }
    /**
     * Animation code.
     *
     * @param gc The drawing Area
     */
    public void animate(GraphicsContext gc) {
        // clear the screen to black
        gc.setFill(Color.WHITE);
        gc.fillRect(0, 0, 500, 400);
        gc.setStroke(Color.rgb(0, 0, 150));
        gc.strokeText("Ticket Counter!", 130, 150);
        TrainStation trainStation = new TrainStation();
        trainStation.subWayTicketMachine(gc);
    }
    public static void pause(int duration) {
        try {
            Thread.sleep(duration);
        } catch (InterruptedException ex) {
        }
    }
    @Override
    public void stop() {
        System.exit(0);
    }
    /**
     * Process start
     *
     * @param gc The drawing Area
     */
    public void subWayTicketMachine(GraphicsContext gc){
        Scanner input = new Scanner(System.in);
        int choice;
        do {
            System.out.println("Welcome to the Ticket Counter! \n" +
                    "1. Approach first machine. \n" +
                    "2. Approach second machine. \n" +
                    "3. Exit.");
            System.out.print("Your Choice : ");
            choice = input.nextInt();
            TicketMachine ticketMachine = new TicketMachine();
            if (choice == 1) {
                ticketMachine.machine = "First Machine";
                getUserInput(input, "Uptown", "Downtown", ticketMachine, gc);
            } else if (choice == 2) { // Second machine
                ticketMachine.machine = "Second Machine";
                getUserInput(input, "Main St.", "King St.", ticketMachine, gc);
            }
        } while(choice != 3);
        System.out.println("BYE!!!");
        stop();
    }
    /**
     * Process to get ticket.
     *
     * @param input Scanner object
     * @param firstRoute first route name
     * @param secondRoute second route name
     * @param ticketMachine TicketMachine class object
     * @param gc The drawing surface
     */
    public void getUserInput(Scanner input, String firstRoute, String secondRoute,TicketMachine ticketMachine, GraphicsContext gc){
        int choice;
        do {
            // output
            gc.clearRect(0, 0, 500, 400);
            gc.setStroke(Color.rgb(0, 0, 150));
            gc.strokeText(String.valueOf(ticketMachine), 130, 140);
            System.out.println("1. Select Route '" + firstRoute + "' \n" +
                    "2. Select Route '" + secondRoute + "' \n" +
                    "3. Add Adult \n" +
                    "4. Remove Adult \n" +
                    "5. Add Child \n" +
                    "6. Remove Child \n" +
                    "7. Insert Quarter \n" +
                    "8. Insert Loonie \n" +
                    "9. Insert Toonie \n" +
                    "10. Print Ticket \n" +
                    "11. Step away from machine");
            System.out.print("Your Choice : ");
            choice = input.nextInt();
            if (choice == 1) {
                ticketMachine.firstRoute();
            } else if(choice == 2){
                ticketMachine.secondRoute();
            } else if(choice == 3){
                ticketMachine.adultAdd();
            } else if(choice == 4){
                ticketMachine.adultLess();
            } else if(choice == 5){
                ticketMachine.childrenAdd();
            } else if(choice == 6){
                ticketMachine.childrenLess();
            } else if(choice == 7){
                ticketMachine.insertQuarter();
            } else if(choice == 8){
                ticketMachine.insertLoonie();
            } else if(choice == 9){
                ticketMachine.insertToonie();
            } else if(choice == 10){
                if(ticketMachine.printTicket()) {
                    System.out.println("YOU GOT THE TICKET");
                } else {
                    System.out.println("Need more credit.");
                }

            }
        }
        // keep accepting until user decides to exit
        while (choice != 11);
        System.out.println("STAY AWAY FROM MACHINE " + ticketMachine.machine);
    }
    /*
     * The actual main method that launches the app.
     * @param args unused
     */
    public static void main(String[] args) {
        launch(args);
    }
}

