<?php
    try {
        $dbh = new PDO(
            "mysql:host=localhost;dbname=000395780",
            "root",
            ""
        );
    } catch (Exception $e){
        die("ERROR: Couldn't connect. {$e->getMessage()}");
    }
