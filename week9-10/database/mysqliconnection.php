<?php
$servername = "saffron.arvixe.com"; // this is the server name
$username = "mart461HCL";
$password = "mart461HCL";
$dbname = "mart461hcl";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}
?>