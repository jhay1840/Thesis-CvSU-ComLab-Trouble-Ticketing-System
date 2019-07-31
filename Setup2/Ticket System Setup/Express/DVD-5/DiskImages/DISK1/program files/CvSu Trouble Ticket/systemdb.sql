-- phpMyAdmin SQL Dump
-- version 4.0.9
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 06, 2019 at 01:59 PM
-- Server version: 5.5.34
-- PHP Version: 5.4.22
create database if not exists systemdb;
USE `systemdb`;
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `systemdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE IF NOT EXISTS `accounts` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `user_lvl` int(11) NOT NULL,
  `lastname` varchar(45) NOT NULL,
  `firstname` varchar(45) NOT NULL,
  `mobileNum` varchar(45) NOT NULL,
  `sec_ques` int(11) NOT NULL,
  `sec_ans` varchar(255) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`user_id`, `username`, `password`, `user_lvl`, `lastname`, `firstname`, `mobileNum`, `sec_ques`, `sec_ans`) VALUES
(1, 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 1, 'Bauyon', 'John Erick', 'johnerickbauyon@gmail.com', 0, 'dog');

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE IF NOT EXISTS `category` (
  `idcategory` int(11) NOT NULL AUTO_INCREMENT,
  `category` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idcategory`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`idcategory`, `category`) VALUES
(1, 'Hardware'),
(2, 'Software'),
(3, 'Network'),
(4, 'others');

-- --------------------------------------------------------

--
-- Table structure for table `computers`
--

CREATE TABLE IF NOT EXISTS `computers` (
  `idcomputers` int(11) NOT NULL,
  `clab` int(11) DEFAULT NULL,
  `pcs` int(11) DEFAULT NULL,
  PRIMARY KEY (`idcomputers`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `computers`
--

INSERT INTO `computers` (`idcomputers`, `clab`, `pcs`) VALUES
(1, 1, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

CREATE TABLE IF NOT EXISTS `subject` (
  `idSubject` int(11) NOT NULL AUTO_INCREMENT,
  `category` varchar(255) DEFAULT NULL,
  `Subject` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idSubject`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=23 ;

--
-- Dumping data for table `subject`
--

INSERT INTO `subject` (`idSubject`, `category`, `Subject`) VALUES
(10, 'Hardware', 'Keyboard'),
(11, 'Hardware', 'Mouse'),
(12, 'Hardware', 'Monitor'),
(13, 'Hardware', 'System Unit'),
(14, 'Hardware', 'Ram'),
(15, 'Hardware', 'Video Card'),
(16, 'Software', 'OS'),
(17, 'Software', 'Application'),
(18, 'Network', 'Lan'),
(20, 'Hardware', 'Speaker');

-- --------------------------------------------------------

--
-- Table structure for table `tickets`
--

CREATE TABLE IF NOT EXISTS `tickets` (
  `tktID` int(11) NOT NULL AUTO_INCREMENT,
  `message` varchar(255) NOT NULL,
  `username` varchar(45) NOT NULL,
  `date` datetime NOT NULL,
  `status` varchar(45) NOT NULL,
  `subject` varchar(255) NOT NULL,
  `priority` varchar(45) NOT NULL,
  `cl_num` varchar(255) DEFAULT NULL,
  `due_date` varchar(255) DEFAULT NULL,
  `pc_num` varchar(45) DEFAULT NULL,
  `category` varchar(45) DEFAULT NULL,
  `new` int(11) NOT NULL,
  PRIMARY KEY (`tktID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=42 ;

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE IF NOT EXISTS `transaction` (
  `tranID` int(11) NOT NULL AUTO_INCREMENT,
  `tktid` varchar(45) NOT NULL,
  `transaction` varchar(255) NOT NULL,
  `details` varchar(255) DEFAULT NULL,
  `date_finished` varchar(255) DEFAULT NULL,
  `subject` varchar(255) NOT NULL,
  `closedby` varchar(255) NOT NULL,
  PRIMARY KEY (`tranID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=22 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
