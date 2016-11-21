<?php
require_once "connexion.php";
header('content-Type: application/json ');
$user_name = $_POST["v_username"];
$user_pass = $_POST["v_password"];
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
	echo 'false';
	exit;
}

//Renvoi
echo '{"users" : ['.json_encode($row);
while($row = $stmt->fetch(PDO::FETCH_OBJ))
{
	echo ','.json_encode($row);
	echo 'Bonjour, bonne connexion';
}
echo ']}';
?>