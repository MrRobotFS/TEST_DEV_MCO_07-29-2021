<?php 
$serverName = "HP-STARWARS" //Server Name/Instance 

//Connection will be with windows auth

$connectionInfo = array('Database' => "master");
$con = sqlsrv_connect($serverName, $connectionInfo);

if($con){
    echo"Connection established";
} else{
    echo"The connection could not be established";
}


?>