<?php
require_once "connexion.php";
header('content-Type: application/json ');
$user_name = $_POST["user_name"];
$user_pass = $_POST["password"];
$cnn = getConnexion("my_bd");

if(!$cnn)
{
	exit;
}

$mysql_qry = "SELECT username, password, role FROM table1 WHERE username LIKE :username AND password LIKE :password;";
$stmt = $cnn->prepare($mysql_qry);
$stmt->bindValue(':username', $user_name, PDO::PARAM_STR);
$stmt->bindValue(':password', $user_pass, PDO::PARAM_STR);
$stmt->execute();

$row = $stmt->fetch(PDO::FETCH_OBJ);
if(!$row)
{
	echo 'Connection failed - Verify your data';
	exit;
}

echo 'Bonjour Monsieur ' . $user_name . ' !';
echo 'Vos droits sont : ' . $row->role;
/*//Renvoi
while($row = $stmt->fetch(PDO::FETCH_OBJ))
{
	echo 'Bonjour, bonne connexion';
}*/
?>