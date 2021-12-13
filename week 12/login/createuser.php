<?php 
require('mysqliconnection.php'); 

if(isset($_POST["username"]))
{
  $user_name = $_POST["username"];
}

if(isset($_POST["hkey"]))
{
  $pwd = $_POST["hkey"];
}

if(isset($_POST["confirmhkey"]))
{
  $confirm_hkey = $_POST["confirmhkey"];
}

if($pwd != $confirm_hkey)
{
    header("Location: register.php?error=1");
}
else
{
    $stmt = $conn->prepare("INSERT INTO people (username, hkey) VALUES (?, ?)");
    $stmt->bind_param("ss", $user_name, $hkey);

    // set parameters and execute
    $stmt->execute();

    header("Location: default.php");
}

?>