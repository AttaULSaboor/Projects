package Assignment1_000395780;

import javafx.application.Application;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.TextInputDialog;
import javafx.scene.paint.Color;
import javafx.stage.Stage;
import java.util.Optional;
import javafx.scene.control.Dialog;

/**
 *Create a star field by displaying a whole bunch of randomly-placed stars on
 *a black or vey dark blue screen, Then create a dialog box ask the user to
 *enter a series of X and Y values that will represent stars in a constellation.
 * I completed Assignment_1 on Jan 21, 2020.
 *
 * @author Atta UL Saboor
 **/

public class Main extends Application {

    /**
     * Start method (use this instead of main).
     *
     * @param stage The FX stage to draw on
     * @throws Exception
     **/
    @Override
    public void start(Stage stage) throws Exception {
        Group root = new Group();
        Scene scene = new Scene(root);
        Dialog dialog = new Dialog();
        Canvas canvas = new Canvas(800, 600); // Set canvas Size in Pixels
        stage.setTitle("Night_Sky"); // Set window title
        root.getChildren().add(canvas);
        stage.setScene(scene);
        GraphicsContext gc = canvas.getGraphicsContext2D();
        GraphicsContext g1 = canvas.getGraphicsContext2D();
        GraphicsContext g2 = canvas.getGraphicsContext2D();

//**Method start from here

        for (int i = 0; i < 500; i++) {
            double x1 = Math.random() * 0;
            double y1 = Math.random() * 0;
            double h1 = Math.random() * 800;
            gc.setFill(Color.BLACK);
            gc.fillRect(x1, y1, h1, h1);
        }

        //**Draw stars randomly

        for (int z = 0; z < 500; z++) {
            double x2 = Math.random() * 800;
            double y2 = Math.random() * 800;
            double h2 = Math.random() * 3;
            g1.setFill(Color.WHITE);
            g1.fillOval(x2, y2, h2, h2);
        }

        // create a text input dialog
        TextInputDialog td = new TextInputDialog();

        // setHeaderText
        td.setHeaderText("Please Enter an X,Y,X,Y,etc...:");

        final Optional<String> result = td.showAndWait();
        if (result.isPresent()) {
            final String params = result.get();
            String[] newParams = params.split(",");

            for (int i = 0; i < newParams.length; i++) {
                if (i <= newParams.length) {
                    double x2 = new Double(newParams[i]);

                    double y2 = new Double(newParams[i]);
                    double h2 = new Double(10);
                    g2.setFill(Color.WHITE);
                    g2.fillOval(x2, y2, h2, h2);
                }

            }

        }
        // Credit on screen
                 g2.fillText(
                        "Program by Atta UL Saboor",
                         Math.round(canvas.getWidth()  / 2),
                         Math.round(canvas.getHeight() / 2)
        );
            stage.show();
    }
        /**
         * The actual main method that launches the app.
         *
         * @param args unused
         */
        public static void main(String[] args) {
            launch(args);
        }

}
