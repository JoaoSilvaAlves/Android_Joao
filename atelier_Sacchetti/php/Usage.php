<?php
include_once('class/ApiSimpleGetRestClient.php');

$clientTransports = new ApiSimpleGetRestClient('http://transport.opendata.ch/v1');
$responseTransports=$clientTransports->get('stationboard?station=Neuchâtel&limit=10)');
$dataTransports = json_decode(($responseTransports),True);

?>

<html>
	<body>
		<table style="width:100%" border="1p" border-collapse: "collapse">
			<tr>
				<th>Pays</th>
				<th>Nombre d'habitants</th> 
				<th>Capitale</th>
			</tr>
			
			<?php
			foreach($dataTransports as $name => $value){
				echo'<tr>',
				'<td>', $value['departure'], '</td>',
				'</tr>';
			}
			?>
		</table>
	</body>
</html>