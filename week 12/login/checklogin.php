<html>
    <head>
        <title>Login!</title>
        <link href="styles.css" type="text/css" rel="stylesheet" >
            
    </head>
    <body>

<?php
require('pdoconnection.php');
// require('mysqliconnection.php'); ?>

<?php
$user_name="";
$pwd="";
if(isset($_POST["username"]))
{
  $user_name = $_POST["username"];
}

if(isset($_POST["hkey"]))
{
  $pwd = $_POST["hkey"];
}
$pwdhash = password_hash ( $pwd)

//$sql = "SELECT * FROM people WHERE username='" . $user_name . "' AND hkey='" . $hkey . "'";
$sql = "CALL spCheckUser(?,?)";

$stmt = $conn->prepare($sql);
$stmt->bindParam(2, $pwdhash, PDO::PARAM_STR);
$stmt->bindParam(1, $user_name, PDO::PARAM_STR);


$stmt->execute();
$stmt->setFetchMode(PDO::FETCH_ASSOC);

if ($stmt->fetch() > 0)
{
  //echo($r);
  // if($r > 0)
  // {
  echo "Logged In";
}
else
{
   header("Location: login.php?error=1");
}
   // echo $r['username'] . " " . $r["pwd"] . "<br />";
//}

//$stmt->closeCursor();

//if ($stmt->num_rows > 0)
//{
//    echo ("Logged in!");
//}

?>

</body>
</html>