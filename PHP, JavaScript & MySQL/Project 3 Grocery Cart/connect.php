<?php
/**
 * Connect the database
 */
try {
    $dbh = new PDO(
        "mysql:host=localhost;dbname=root",
        "root",
        ""
    );
} catch (Exception $e) {
    die("ERROR: Couldn't connect. {$e->getMessage()}");
}