<?php require('mysqliconnection.php'); ?>
<?php 

//insert part
// prepare and bind
if(isset($_GET["firstname"]))
{
  $firstname = $_GET["firstname"];
}
if(isset($_GET["lastname"]))
{
  $lastname = $_GET["lastname"];
} 
if(isset($_GET["u1"]))
{
  $username = $_GET["u1"];
} 
if(isset($_GET["email"]))
{
  $email= $_GET["email"];
} 
if(isset($_GET["hkey"]))
{
  $privatekey= $_GET["hkey"];
} 




$stmt = $conn->prepare("INSERT INTO fletcher_users (firstname, username, email, hkey, lastname) VALUES (?, ?, ?, ?, ?)");
$stmt->bind_param("sssss", $firstname, $username, $email, $privatekey, $lastname);

// set parameters and execute



$stmt->execute();

//$firstname = "Brewer";
//$lastname = "Johnanna";
//$username = "brewer@johana.com";
//$stmt->execute();

echo "New records created successfully<br>";

$stmt->close();

/// select part

$sql = "SELECT * FROM fletcher_users";
// where username ='' and privatekey=''";

$result = $conn->query($sql);

$controlthing = "<form action='basicquery.php' method='GET'><select name='username'>";
if ($result->num_rows > 0) {
  // output data of each row
  while($row = $result->fetch_assoc()) {
    // echo "person: " . $row["userID"] . " " . $row["username"]  . " " . $row["firstname"]  . " " . $row["email"]  . " " . $row["privatekey"] . "<br />";
    $controlthing = $controlthing . "<option id ='" . $row["userID"] . "' name='" . $row["userID"] . "'>" . $row["username"]  . "</option>";
  }
} else {
  echo "0 results";
}

$controlthing = $controlthing . "</select><input type='submit' value='submit'></form>";

echo ($controlthing);


$continueon = true;
?>
<form action='updateFletcher.php' method='GET'><select name='userID'>
  <?php


$controlthing = "";
// if it returns an error of false, check your query
if ($result->num_rows > 0) {
  // output data of each row
  
  while($continueon) {
    // echo "person: " . $row["userID"] . " " . $row["username"]  . " " . $row["firstname"]  . " " . $row["email"]  . " " . $row["privatekey"] . "<br />";
    $row = $result->fetch_assoc();
    if($row == null)
    {
      $continueon = false;
    }
    else
    {
      echo "<option value ='" . $row["userID"] . "' name='" . $row["userID"] . "'>" . $row["username"]  . "</option>";
      
    }
  }
} else {
  echo "0 results";
}

//$controlthing = $controlthing . "";

?>

</select><input type='submit' value='submit'></form>
<?php
//echo ($controlthing);



$conn->close();













/*
require('pdoconnection.php');

$statename = "Washington";
$stateabbreviation = "WA";

$sql = 'CALL spInsertNewState(:statename, :stateabbreviation)';

$stmt = $cn->prepare($sql);

$stmt->bindParam(':statename', $statename, PDO::PARAM_STR);
$stmt->bindParam(':stateabbreviation', $stateabbreviation, PDO::PARAM_STR);

$stmt->execute();

$stmt->closeCursor();


try {
    
  $stateid = 3;
  $sql = 'CALL spGetAllStates(:stateid)';
  $stmt = $cn->prepare($sql);
  $stmt->bindParam(':stateid', $stateid, PDO::PARAM_INT);
  $stmt->execute();
  $stmt->setFetchMode(PDO::FETCH_ASSOC);

} catch (PDOException $e) {
    die("Error occurred:" . $e->getMessage());
}
/// iterates over the array
while ($r = $stmt->fetch())
{
    echo $r['state_name'] . " " . $r['state_abbreviation'] . "<br />";
}
 


// prepare and bind
$stmt = $conn->prepare("INSERT INTO people (firstname, lastname, username) 
VALUES (?, ?, ?)");
$stmt->bind_param("sss", $firstname, $lastname, $username);

// set parameters and execute
$firstname = "Greg";
$lastname = "Hollenbeck";
$username = "greg@greg.com";
$stmt->execute();

$firstname = "Brewer";
$lastname = "Johnanna";
$username = "brewer@johana.com";
$stmt->execute();

echo "New records created successfully";

$stmt->close();

//$conn->close();


//$cn->close();

?>
*/

