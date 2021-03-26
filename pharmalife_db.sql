-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 25, 2021 at 11:57 PM
-- Server version: 10.4.6-MariaDB
-- PHP Version: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pharmalife_db`
--
CREATE DATABASE IF NOT EXISTS `pharmalife_db` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `pharmalife_db`;

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `id` int(11) NOT NULL,
  `name` varchar(150) NOT NULL,
  `presentation` varchar(150) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`id`, `name`, `presentation`) VALUES
(1, 'xd', 'xddd'),
(2, 'producto1', 'presentacion1'),
(3, 'producto2', 'presentacion2'),
(4, 'producto3', 'presentacion3'),
(5, 'producto4', 'presentacion4'),
(6, 'producto5', 'presentacion5'),
(7, 'producto6', 'presentacion6'),
(8, 'producto7', 'presentacion7'),
(9, 'producto8', 'presentacion8'),
(10, 'producto9', 'presentacion9'),
(11, 'producto10', 'presentacion10'),
(12, 'p1', 'pr1'),
(13, 'p2', 'pr2'),
(14, 'p3', 'pr3'),
(15, 'PruebaCarlos', 'pastillas'),
(16, 'Vulva', 'Vulvasaurio'),
(17, 'nuevo', 'nueva mierda'),
(18, 'nuevo2222222', 'nuevo2222'),
(19, 'hola', 'gola'),
(20, 'diego', 'diegop'),
(21, 'deigo', 'velara'),
(22, '123', '1233'),
(23, '34545345', '45345'),
(24, 'prod1', 'pres1'),
(25, 'prod2', 'pres2'),
(26, 'peneeee', 'peneee1'),
(27, '7676', '767676'),
(28, 'ty', 'yyy'),
(29, 'quebin', 'quebingo'),
(30, 'quebin2', 'quebingo2'),
(31, 'Acetaminofen', 'TABLETAS X 12');

-- --------------------------------------------------------

--
-- Table structure for table `providers`
--

CREATE TABLE `providers` (
  `id` int(11) NOT NULL,
  `name` varchar(150) NOT NULL,
  `address` varchar(150) NOT NULL,
  `phone` int(11) NOT NULL,
  `status` tinyint(3) UNSIGNED DEFAULT 1
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `providers`
--

INSERT INTO `providers` (`id`, `name`, `address`, `phone`, `status`) VALUES
(1, 'GenomaLab', 'soyapango', 22345678, 1),
(2, 'Cimberton2', '9 calle poniente 7 av sur', 22346768, 1),
(3, 'Diego\'sLab', 'Calle Velara 45', 73737879, 0),
(4, 'SerranosFakeCompany', 'San Salvador', 73737373, 1),
(5, 'Bayern es bueno', 'Santa Ana', 23242526, 1),
(6, 'Prueba1', 'xd', 23232323, 0),
(7, 'Prueba2', 'dee', 77777777, 0),
(8, 'Prueba3', 'ddd', 45454545, 0);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(150) NOT NULL,
  `password` text NOT NULL,
  `status` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `status`) VALUES
(1, 'carlos.serrano', 'Pa$$w0rd', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `products_name_unique` (`name`);

--
-- Indexes for table `providers`
--
ALTER TABLE `providers`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`,`name`),
  ADD UNIQUE KEY `providers_phone_unique` (`phone`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `users_username_unique` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `providers`
--
ALTER TABLE `providers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
