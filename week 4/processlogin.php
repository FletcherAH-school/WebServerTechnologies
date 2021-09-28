<?php

$user_name = $_GET["username"];
echo("my username is: " . $user_name); // "." for concatenation

session_start();


$_SESSION["favcolor"] = "green";
$_SESSION["favanimal"] = "cat";


echo "Favorite color is " . $_SESSION["favcolor"] . ".<br>";
echo "Favorite animal is " . $_SESSION["favanimal"] . ".";

$cookie_name = "user";
  $cookie_value = "its working";
  setcookie($cookie_name, $cookie_value, time() + (86400 * 30), "/"); // 86400 = 1 day

echo $_COOKIE[$cookie_name]

?>