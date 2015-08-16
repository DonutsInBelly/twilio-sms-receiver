<?php 

$file = '/var/www/html/log.txt';

$from = $_POST["From"];
$body = $_POST["Body"];

file_put_contents($file, $from . "," . $body . "\n", FILE_APPEND);

?>
