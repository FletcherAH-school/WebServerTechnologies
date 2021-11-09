<html>
<body>
  <h1>Database Stuff</h1>
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
echo "Connected successfully <br />";

// 
$sql = "SELECT * FROM fletcher_users ORDER BY firstname";

$result = $conn->query($sql);

if ($result->num_rows > 0) {
  // output data of each row
  while($row = $result->fetch_assoc()) {
    echo "person: " . $row["userID"] . " " . $row["username"]  . " " . $row["firstname"]  . " " . $row["email"]  . " " . $row["hkey"] . "<br />";
  }
} else {
  echo "0 results";
}
$conn->close();

?>

</body>
</html>