<?php 

require('pdoconnection.php');

try {
    
   // connecting to the database
   //  execute the stored procedure
    $sql = 'CALL spSelectAllStates()';
    // call the stored procedure
    $stmt = $cn->query($sql);
    // gets array
    $stmt->setFetchMode(PDO::FETCH_ASSOC);
} catch (PDOException $e) {
    die("Error occurred:" . $e->getMessage());
}
/// iterates over the array
$stateinfo = "<select name='states' id='states'>";
while ($r = $stmt->fetch())
{
    $stateinfo = $stateinfo . "<option value='" . $r['state_id'] . "'>" . $r['state_abbreviation'] . "</option>";
}

$stateinfo = $stateinfo . "</select>";
echo $stateinfo;
$stmt->closeCursor();
?>

