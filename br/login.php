<?php
session_start();
if (!isset($_SESSION["email"])){
    $_SESSION["email"]=[];
}
if (!isset($_SESSION["senha"])){
    $_SESSION["senha"]=[];
}
$email = $_POST['email'];
$senha = $_POST['senha'];
$contemail = file_get_contents('email.json');
$_SESSION ['email'] = json_decode($contemail,true);
$contesenha = file_get_contents('senha.json');
$_SESSION ['senha'] = json_decode($contesenha,true);
$femail = array_search($email,$_SESSION['email']);
$fsenha = array_search($senha,$_SESSION['senha']);
if(isset($femail) && isset($fsenha)){
header("Location:inicial.php");
}
else{
echo "<script>alert('credenciais nao validas. tente novamente!')</script>";
echo "<script>window.location.replace('index.php')</script>";
}
echo $femail;
?>