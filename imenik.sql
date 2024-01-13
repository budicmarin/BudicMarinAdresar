-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jan 13, 2024 at 10:28 PM
-- Server version: 8.0.32
-- PHP Version: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `imenik`
--

-- --------------------------------------------------------

--
-- Table structure for table `adresar`
--

DROP TABLE IF EXISTS `adresar`;
CREATE TABLE IF NOT EXISTS `adresar` (
  `AdresaID` int NOT NULL AUTO_INCREMENT,
  `KontaktID` int DEFAULT NULL,
  `Ulica` varchar(100) COLLATE utf16_croatian_ci DEFAULT NULL,
  `Grad` varchar(50) COLLATE utf16_croatian_ci DEFAULT NULL,
  `Drzava` varchar(50) COLLATE utf16_croatian_ci DEFAULT NULL,
  `PostanskiBroj` varchar(10) COLLATE utf16_croatian_ci DEFAULT NULL,
  PRIMARY KEY (`AdresaID`),
  KEY `KontaktID` (`KontaktID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_croatian_ci;

--
-- Dumping data for table `adresar`
--

INSERT INTO `adresar` (`AdresaID`, `KontaktID`, `Ulica`, `Grad`, `Drzava`, `PostanskiBroj`) VALUES
(1, 1, 'Prva ulica 1', 'Zagreb', 'Hrvatska', '10000'),
(2, 2, 'Druga ulica 2', 'Split', 'Hrvatska', '20000'),
(3, 3, 'Treća ulica 3', 'Rijeka', 'Hrvatska', '30000');

-- --------------------------------------------------------

--
-- Table structure for table `osoba`
--

DROP TABLE IF EXISTS `osoba`;
CREATE TABLE IF NOT EXISTS `osoba` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Ime` varchar(10) COLLATE utf16_croatian_ci NOT NULL,
  `Prezime` varchar(10) COLLATE utf16_croatian_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf16 COLLATE=utf16_croatian_ci;

--
-- Dumping data for table `osoba`
--

INSERT INTO `osoba` (`Id`, `Ime`, `Prezime`) VALUES
(1, 'Ana', 'Bakic'),
(2, 'Ivan', 'Horvat'),
(3, 'Petra', 'Kovac');

-- --------------------------------------------------------

--
-- Table structure for table `telefon`
--

DROP TABLE IF EXISTS `telefon`;
CREATE TABLE IF NOT EXISTS `telefon` (
  `TelefonID` int NOT NULL AUTO_INCREMENT,
  `KontaktID` int DEFAULT NULL,
  `Broj` varchar(20) COLLATE utf16_croatian_ci DEFAULT NULL,
  PRIMARY KEY (`TelefonID`),
  KEY `KontaktID` (`KontaktID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_croatian_ci;

--
-- Dumping data for table `telefon`
--

INSERT INTO `telefon` (`TelefonID`, `KontaktID`, `Broj`) VALUES
(1, 1, '111-222-3333'),
(2, 2, '444-555-666'),
(3, 3, '777-888-999');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `adresar`
--
ALTER TABLE `adresar`
  ADD CONSTRAINT `adresar_ibfk_1` FOREIGN KEY (`KontaktID`) REFERENCES `osoba` (`Id`);

--
-- Constraints for table `telefon`
--
ALTER TABLE `telefon`
  ADD CONSTRAINT `telefon_ibfk_1` FOREIGN KEY (`KontaktID`) REFERENCES `osoba` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
