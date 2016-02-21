<?php
  $h='localhost';
  $u='31879_nanticopy';
  $p='ndjaAG6G89$%';
  $db=new mysqli($h, $u, $p, '31879_nanticopy');
  $c=0;
  $app=$_GET['app'];
  $key=$_GET['key'];
  $os=$_GET['os'];
  $sth = $db->prepare('SELECT * FROM `Keys` WHERE `AppID` = ? AND `Key` = ?');
  $sth->bind_Param('ss', $app, $key);
  $sth->execute();
  $sth->bind_result($fetch_vornamen, $fetch_nachnamen, $fetch_kundennummer, $fetch_key, $fetch_windows, $fetch_mac, $fetch_linux,  $fetch_openw, $fetch_opwnm, $fetch_openl, $fetch_activated, $fetch_nachrichtw, $fetch_nachrichtm, $fetch_nachrichtl, $fetch_kommentar, $fetch_app);
  
  while($x=$sth->fetch()) {
    $c++;
	if ($os == "Windows") {
		echo "<p><pre>\r\n". $fetch_nachrichtw ."\r\n</pre></p>";
	} elseif ($os == "Mac") {
		echo "<p><pre>\r\n". $fetch_nachrichtw ."\r\n</pre></p>";
	} elseif ($os == "Linux") {
		echo "<p><pre>\r\n". $fetch_nachrichtw ."\r\n</pre></p>";
	} else {
		echo "Ihr Betriebssystem ist ungueltig!";
	}
  }  
  
  if ($os == "Windows") {
	$q = $db->prepare('UPDATE `Keys` SET `OpenW`=`OpenW`+1 WHERE `AppID` LIKE ? AND `Key` LIKE ?');
  } elseif ($os == "Mac") {
	$q = $db->prepare('UPDATE `Keys` SET `OpenM`=`OpenM`+1 WHERE `AppID` LIKE ? AND `Key` LIKE ?');
  } elseif ($os == "Linux") {
	$q = $db->prepare('UPDATE `Keys` SET `OpenL`=`OpenL`+1 WHERE `AppID` LIKE ? AND `Key` LIKE ?');
  } else {
	echo "Ihr Betriebssystem ist ungueltig!";
  }
  	$q->bind_Param('ss', $app, $key);
	$q->execute();
	
  
  if ($c == 0) {
	echo "<p><pre>\r\n";
	if ($os == "Windows") {
		echo "@Ihr Lizenzschlüssel ist nicht mehr in der Datenbank vorhanden. Dies könnte die Folge eines Technischen Problemes oder einer Lizenzsperre sein. Sollte der Fehler nicht in den nöächsten Stunden behoben werden, melden Sie sich bitte umgehend per  Mail an nico@bosshome.ch\nWir entschuldigen uns für die dadurch entstandenden unannehmlichkeiten.";
		echo "end";
	} elseif ($os == "Mac") {
		echo "@Ihr Lizenzschlüssel ist nicht mehr in der Datenbank vorhanden. Dies könnte die Folge eines Technischen Problemes oder einer Lizenzsperre sein. Sollte der Fehler nicht in den nöächsten Stunden behoben werden, melden Sie sich bitte umgehend per  Mail an nico@bosshome.ch\nWir entschuldigen uns für die dadurch entstandenden unannehmlichkeiten.";
		echo "@Durch Drücken von Enter wird das Programm beendet.";
		echo "?1";
		echo "end";
	} elseif ($os == "Linux") {
		echo "@Ihr Lizenzschlüssel ist nicht mehr in der Datenbank vorhanden. Dies könnte die Folge eines Technischen Problemes oder einer Lizenzsperre sein. Sollte der Fehler nicht in den nöächsten Stunden behoben werden, melden Sie sich bitte umgehend per  Mail an nico@bosshome.ch\nWir entschuldigen uns für die dadurch entstandenden unannehmlichkeiten.";
		echo "end";
	} else {
	echo "Lizenzschlüssel ist nicht mehr in der Datenbank vorhanden sowie ihr Betriebssystem ist ungültig!";
	}
	echo "\r\n</pre></p>";
  }
  

  //z.B. um Nachricht nur 1mal anzuzeigen
  //$a = $db->prepare('UPDATE `Keys` SET `Activated`=`Activated`+1 WHERE `AppID` LIKE ? AND `Key` LIKE ?');
  //$a->bind_Param('ss', $app, $key);
  //$a->execute();
  
  $db->close();
?>