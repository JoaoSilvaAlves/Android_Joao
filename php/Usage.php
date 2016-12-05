<?php

require_once 'class/ApiSimpleGetRestClient.php';
$client = new ApiSimpleGetRestClient('http://www.prevision-meteo.ch/services/json');
$response = $client->get('Neuchâtel');
$data = json_decode(($response), True);
echo 'Ville : '.$data['city_info']['name'].'</br>';
echo 'Date du jour : '.$data['current_condition']['date'].'</br>';
echo 'Temp : '.$data['current_condition']['tmp'].'deg.</br>';

var_dump($data['fcst_day_0']['hourly_data']['12H00']);
//var_dump($data); //Toutes les données sur plusieurs jours
//var_dump($data['fcst_day_0']); //Pour le jours en cours
//var_dump($data['fcst_day_2']); //Pour dans deux jours

?>