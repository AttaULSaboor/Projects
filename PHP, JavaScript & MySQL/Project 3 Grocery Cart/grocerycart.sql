-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 29, 2020 at 02:36 AM
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
-- Table structure for table `grocerycart`
--

CREATE TABLE `grocerycart` (
  `Item_id` int(11) NOT NULL,
  `Item_name` varchar(40) NOT NULL,
  `Item_quantity` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `grocerycart`
--

INSERT INTO `grocerycart` (`Item_id`, `Item_name`, `Item_quantity`) VALUES
(121, 'Bread', 2),
(122, 'Milk', 1),
(123, 'Milk', 1),
(124, 'Tea', 1),
(125, 'Tea', 1),
(126, 'Bagel', 2),
(127, 'Bagel', 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `grocerycart`
--
ALTER TABLE `grocerycart`
  ADD PRIMARY KEY (`Item_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `grocerycart`
--
ALTER TABLE `grocerycart`
  MODIFY `Item_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=128;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
