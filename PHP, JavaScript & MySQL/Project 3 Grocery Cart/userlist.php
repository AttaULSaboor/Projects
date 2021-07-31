<?php
/**
 * Returns a json-encoded list of User objects drawn from a database.
 *
 * Use the grocerycart table (grocerycart.sql) from database.
 * 
 */

include "connect.php";

// // Prepare and execute the DB query
$command = "SELECT Item_id, Item_name, Item_quantity FROM grocerycart ORDER BY Item_id";
$stmt = $dbh->prepare($command);
$success = $stmt->execute();

// // Fill an array with User objects based on the results.
$userlist = [];
while ($row = $stmt->fetch()) {
    $user = [
        "ItemId" => (int)$row["Item_id"],
        "ItemName" => $row["Item_name"],
        "ItemQuantity" => (int)$row["Item_quantity"]
    ];
    array_push($userlist, $user);
}

// // Write the json encoded array to the HTTP Response
echo json_encode($userlist);