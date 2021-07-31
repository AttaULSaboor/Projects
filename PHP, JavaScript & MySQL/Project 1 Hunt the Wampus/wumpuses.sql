-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 24, 2020 at 03:20 AM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `000395780`
--

-- --------------------------------------------------------

--
-- Table structure for table `wumpuses`
--

CREATE TABLE `wumpuses` (
  `wumpusId` int(11) NOT NULL,
  `wumpusRow` int(11) NOT NULL,
  `wumpusColumn` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `wumpuses`
--

INSERT INTO `wumpuses` (`wumpusId`, `wumpusRow`, `wumpusColumn`) VALUES
(1, 2, 2),
(2, 1, 2),
(3, 2, 2),
(4, 2, 2),
(5, 1, 2),
(6, 2, 2),
(7, 4, 2),
(8, 2, 2),
(9, 5, 3),
(10, 0, 3),
(11, 6, 3),
(12, 3, 6);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `wumpuses`
--
ALTER TABLE `wumpuses`
  ADD PRIMARY KEY (`wumpusId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
