<!DOCTYPE html>
<?php
/**
 * Name: Atta UL Saboor
 * Date: 23 October, 2020
 * 
 * I create and maintain databse tables listing all the wumpus locations and 
 * all the users who played the game along with their record of wins and losses.
 * 
 */

include "connect.php";

//prepare and excute the DB query
$command ="SELECT wumpusRow, wumpusColumn From wumpuses where wumpusRow =? and  wumpusColumn = ?";
$stmt = $dbh->prepare($command);
$params = [ filter_input(INPUT_GET,"row", FILTER_VALIDATE_INT), filter_input(INPUT_GET,"col", FILTER_VALIDATE_INT)];
$success = $stmt->execute($params);
$paramsok = $stmt->fetch();

if ($paramsok) {
    $win = true;
} else {
    $win = false;
}


?>
<html>

<head>
    <title>Hunt the wumpus</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, intial-scale=1.0">
    <link rel="stylesheet" href="css/wumpus.css">
</head>

<body>
    <div id="container">
        <h1>Hunt the Wumpus!</h1>
    </div>
    <?php
    //output
         if ($paramsok) {
             echo"<p>Congratulations!</p>";
              $src = "wumpus.png";
         }else {
             echo"<p>Bad Luck...You didn't find the wumpus!</p>";
             $src = "sadpicture.png";
         }
    ?>
    <img src="<?php echo $src ?>"> 
    <form action="save.php" method="post"><br/>
        <div>
            <input type="email" name="emailAddress" placeholder="Enter your Email Address" required>
        </div>
        <div>
            <input type="hidden" name="win" value="<?php echo $win ?>">
        </div>
        <div>
            <input type="submit" value="Submit">
        </div>
    </form>
</body>

</html>