-- phpMyAdmin SQL Dump
-- version 3.5.7
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Erstellungszeit: 21. Feb 2016 um 12:58
-- Server Version: 5.0.95-log
-- PHP-Version: 5.3.23

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

--
-- Datenbank: `31879_nanticopy`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `keys`
--

CREATE TABLE `keys` (
  `Vornamen` varchar(30) NOT NULL,
  `Nachnamen` varchar(30) NOT NULL,
  `Kundennummer` int(10) unsigned NOT NULL,
  `Key` varchar(30) NOT NULL,
  `Windows` tinyint(3) unsigned NOT NULL,
  `Mac` tinyint(3) unsigned NOT NULL,
  `Linux` tinyint(3) unsigned NOT NULL,
  `Activated` mediumint(8) unsigned NOT NULL,
  `OpenW` int(10) unsigned NOT NULL,
  `OpenM` int(10) unsigned NOT NULL,
  `OpenL` int(10) unsigned NOT NULL,
  `NachrichtW` text NOT NULL,
  `NachrichtM` text NOT NULL,
  `NachrichtL` text NOT NULL,
  `Kommentar` text NOT NULL,
  `AppID` varchar(30) NOT NULL,
  UNIQUE KEY `Vornamen_2` (`Vornamen`,`Nachnamen`,`Kundennummer`,`Key`,`Windows`,`Mac`,`Linux`,`Activated`,`OpenW`,`OpenM`,`OpenL`),
  FULLTEXT KEY `NachrichtW` (`NachrichtW`),
  FULLTEXT KEY `Vornamen` (`Vornamen`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8;

--
-- Daten für Tabelle `keys`
--

INSERT INTO `keys` (`Vornamen`, `Nachnamen`, `Kundennummer`, `Key`, `Windows`, `Mac`, `Linux`, `Activated`, `OpenW`, `OpenM`, `OpenL`, `NachrichtW`, `NachrichtM`, `NachrichtL`, `Kommentar`, `AppID`) VALUES
('Nico', 'Bosshard', 777777777, 'PLMMD-YNOJG-EBJET-MEBXU-YLEJX', 223, 254, 255, 505, 170, 123, 0, '=V1.1\n@Hallo Nico\n', '=V1.1\n@Hallo Nico\n\n\n\n', '65675', 'Nicos Lizenzschlüssel :D', 'MIDIHarfe'),
('', '', 0, 'BPPGK-FPRHD-RFKVG-EKEOH-DNEJS', 0, 0, 0, 4, 0, 0, 0, '', '', '', '', 'MIDIHarfe'),
('', '', 0, 'WJRUP-GCUYX-TQNNF-NRHXJ-JRIAG', 0, 0, 0, 5, 0, 0, 0, '', '', '', '', 'MIDIHarfe'),
('', '', 0, 'KOQXC-NLFNN-UWVQW-PJKXM-MVQIT', 0, 0, 0, 5, 0, 0, 0, '', '', '', '', 'MIDIHarfe'),
('', '', 0, 'LGFAI-EAQOF-QKWWK-ILAYJ-PUPBS', 0, 0, 0, 5, 0, 0, 0, '', '', '', '', 'MIDIHarfe'),
('', '', 0, 'AGKNS-OXIDP-GFEFI-TGHKF-FLNMD', 0, 0, 0, 5, 0, 0, 0, '', '', '', '', 'MIDIHarfe'),
('', '', 0, 'BUQXD-QPEHH-XPCUQ-SCSGD-DGUQP', 0, 0, 0, 5, 0, 0, 0, '', '', '', '', 'MIDIHarfe'),
('', '', 0, 'JMFUN-NSWKQ-SGJYY-PAWWK-EDMTL', 0, 0, 0, 5, 0, 0, 0, '', '', '', '', 'MIDIHarfe'),
('', '', 0, 'CRGJA-UYYIT-EKITS-ESREW-MRTHM', 0, 0, 0, 5, 0, 0, 0, '', '', '', '', 'MIDIHarfe'),
('', '', 0, 'CIWGK-FAKJK-VLNKU-SGBFT-FRDDF', 0, 0, 0, 5, 0, 0, 0, '', '', '', '', 'MIDIHarfe'),
('', '', 0, 'KLHWY-KXXVW-LCSWN-EAYIW-RFGID', 0, 0, 0, 5, 0, 0, 0, '', '', '', '', 'MIDIHarfe');
