<?php require('mysqliconnection.php'); ?>

<?php
if(isset($_GET["userID"]))
{
  $user_id = $_GET["userID"];
}
$stmt = $conn->prepare("UPDATE fletcher_users SET username = ? WHERE userID = ?");
$stmt->bind_param("si", $username, $userid);

$username = "hi there";
$userid = $user_id;
$stmt->execute();

echo ("yeah");
?>

<?php //header("Location: basicquery.php"); ?>