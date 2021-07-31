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

$emailAddress = filter_input(INPUT_POST,"emailAddress", FILTER_VALIDATE_EMAIL);
$win = filter_input(INPUT_POST,"win", FILTER_VALIDATE_INT);

// check if email already exists in table
if (
    $emailAddress !== null && $emailAddress !== "" &&
    $win !== null && $win !== "" 
   
)
{
    $command = "SELECT * From players where emailAddress = ?";
    $stmt = $dbh->prepare($command);
    $params = [$emailAddress];
    $success = $stmt->execute($params);
}
if ($success && $row = $stmt->fetch()) {
    // record already exists
    
    $command = "UPDATE players SET wins=?, losses=?, dateLastPlayed=CURDATE() Where emailAddress = ?";
    $stmt = $dbh->prepare($command);

    $winValue = $row['wins'];
    $lossValue = $row['losses'];

    if ($win) {
        $winValue++;
    } else {
        $lossValue++;
    }
    $params = [$winValue, $lossValue, $emailAddress];
    $success = $stmt->execute($params);
    $successMessage = '1 record was updated';
} else {
    // record doesnt exists
    $command = "INSERT INTO players (emailAddress, wins, losses, dateLastPlayed) VALUES (?,?,?,CURDATE())";
    $stmt = $dbh->prepare($command);
    
    if ($win) {
        $winValue = 1;
        $lossValue = 0;
    } else {
        $winValue = 0;
        $lossValue = 1;
    }
    $params = [filter_input(INPUT_POST,"emailAddress", FILTER_VALIDATE_EMAIL), $winValue, $lossValue];
    $success = $stmt->execute($params);
    $successMessage = '1 record was inserted into the database';
}
//display the result
$command = "SELECT * From players LIMIT 10";
$stmt = $dbh->prepare($command);
$success = $stmt->execute();
$top10 = $stmt->fetchAll();
?>
<html>

<head>
    <title>Hunt the Wumpus</title>
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
    $emailAddress = filter_input(INPUT_GET, "emailAddress" , FILTER_VALIDATE_EMAIL);
    if ($successMessage) {
        echo '<p>'.$successMessage.'</p>';
    }
    ?>
    <div id="button">
            <button onclick="location.href='index.php'">Play again</button>
        </div>
        <table>
            <tr>
                <td colspa="4" >Top 10 Players</td>
            </tr>
            <tr>
                <td>Email</td>
                <td>Wins</td>
                <td>Losses</td>
                <td>Date Last Played</td>
            </tr>
            <?php foreach ($top10 as $row) { ?>
            <tr>
               <td><?php echo $row['emailAddress']; ?></td> 
               <td><?php echo $row['wins']; ?></td> 
               <td><?php echo $row['losses']; ?></td> 
               <td><?php echo $row['dateLastPlayed']; ?></td> 
            </tr>
            <?php } ?>
        </table>
</body>

</html>