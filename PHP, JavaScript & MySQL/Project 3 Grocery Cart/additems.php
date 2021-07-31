<?php
/**
 * 
 * Use the grocerycart table (grocerycart.sql) from database.
 * 
 */
include "connect.php";

// get the parameter
$name = filter_input(INPUT_GET, "name", FILTER_SANITIZE_SPECIAL_CHARS);
$itemsNumber = filter_input(INPUT_GET, "itemsNumber", FILTER_VALIDATE_INT);

// // Prepare and execute the DB query
$command = "INSERT INTO grocerycart (Item_name, Item_quantity) VALUES (?,?)";
$stmt = $dbh->prepare($command);
$params = [$name, $itemsNumber];
$success = $stmt->execute($params);

// // Write the json encoded array to the HTTP Response
echo json_encode($success);