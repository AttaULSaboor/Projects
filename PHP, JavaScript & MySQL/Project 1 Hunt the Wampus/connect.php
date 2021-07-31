<?php
    try {
        $dbh = new PDO(
            "mysql:host=localhost;dbname=000395780",
            "000395780",
            "19861007"
        );
    } catch (Exception $e){
        die("ERROR: Couldn't connect. {$e->getMessage()}");
    }