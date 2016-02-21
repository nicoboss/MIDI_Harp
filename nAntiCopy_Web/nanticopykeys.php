<?php
  $h='localhost';
  $u='31879_nanticopy';
  $p='ndjaAG6G89$%';
  $db=new mysqli($h, $u, $p, '31879_nanticopy');
  $c=0;
  $cnt=0;
  $enable=0;
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
		$cnt=$fetch_windows;
	} elseif ($os == "Mac") {
		$cnt=$fetch_mac;
	} elseif ($os == "Linux") {
		$cnt=$fetch_linux;
	} else {
		echo "Ihr Betriebssystem ist ungueltig!";
	}
  }
  
  if ($c>0) 	$enable=1;
  if ($enable==1) echo '1;';
  else echo '0;';
  if ($cnt>0) {
	if ($os == "Windows") {
		$q = $db->prepare('UPDATE `Keys` SET `Windows`=`Windows`-1 WHERE `AppID` LIKE ? AND `Key` LIKE ?');
	} elseif ($os == "Mac") {
		$q = $db->prepare('UPDATE `Keys` SET `Mac`=`Mac`-1 WHERE `AppID` LIKE ? AND `Key` LIKE ?');
	} elseif ($os == "Linux") {
		$q = $db->prepare('UPDATE `Keys` SET `Linux`=`Linux`-1 WHERE `AppID` LIKE ? AND `Key` LIKE ?');
	} else {
		echo "Ihr Betriebssystem ist ungueltig!";
	}
	$q->bind_Param('ss', $app, $key);
	$q->execute();
	$a = $db->prepare('UPDATE `Keys` SET `Activated`=`Activated`+1 WHERE `AppID` LIKE ? AND `Key` LIKE ?');
	$a->bind_Param('ss', $app, $key);
	$a->execute();
  }
  echo $cnt;
  $db->close();
?>