-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 08, 2019 at 06:37 AM
-- Server version: 10.1.35-MariaDB
-- PHP Version: 7.2.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `aplikasi_kas`
--

-- --------------------------------------------------------

--
-- Table structure for table `isi_tablekas`
--

CREATE TABLE `isi_tablekas` (
  `NomorTransaksi` int(3) NOT NULL,
  `Tanggal` date NOT NULL,
  `Saldo` varchar(12) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Jenis` varchar(12) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Jumlah` varchar(12) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Keterangan` varchar(24) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `isi_tablekas`
--

INSERT INTO `isi_tablekas` (`NomorTransaksi`, `Tanggal`, `Saldo`, `Jenis`, `Jumlah`, `Keterangan`) VALUES
(41, '2019-12-07', '25000', 'Masuk', '2000', 'sgaga'),
(43, '2019-12-07', '25000', 'Keluar', '10000', 'bayar wifi'),
(45, '2019-12-08', '25000', 'Masuk', '25000', 'Setor');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `isi_tablekas`
--
ALTER TABLE `isi_tablekas`
  ADD PRIMARY KEY (`NomorTransaksi`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `isi_tablekas`
--
ALTER TABLE `isi_tablekas`
  MODIFY `NomorTransaksi` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
