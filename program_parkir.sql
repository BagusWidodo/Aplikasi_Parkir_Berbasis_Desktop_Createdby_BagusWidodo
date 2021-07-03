-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 07 Jun 2021 pada 16.20
-- Versi server: 10.4.17-MariaDB
-- Versi PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `program_parkir`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `admin`
--

CREATE TABLE `admin` (
  `username` varchar(25) NOT NULL,
  `nama_user` varchar(25) NOT NULL,
  `password` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `admin`
--

INSERT INTO `admin` (`username`, `nama_user`, `password`) VALUES
('Yusnizar', 'Yusnizar', '12345678');

-- --------------------------------------------------------

--
-- Struktur dari tabel `parkir_keluar`
--

CREATE TABLE `parkir_keluar` (
  `no_antrian` varchar(8) NOT NULL,
  `no_polisi` varchar(12) NOT NULL,
  `jenis_kendaraan` varchar(15) NOT NULL,
  `jam_masuk` varchar(15) NOT NULL,
  `jam_keluar` varchar(15) NOT NULL,
  `lama_parkir` varchar(15) NOT NULL,
  `tarif_3jam` int(11) NOT NULL,
  `biaya_parkir` int(11) NOT NULL,
  `tanggal` date NOT NULL,
  `operator` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `parkir_keluar`
--

INSERT INTO `parkir_keluar` (`no_antrian`, `no_polisi`, `jenis_kendaraan`, `jam_masuk`, `jam_keluar`, `lama_parkir`, `tarif_3jam`, `biaya_parkir`, `tanggal`, `operator`) VALUES
('00001', 'BK 2343 VAM', 'Sepeda Motor', '00:00:40', '01:43:55', '1:43:11', 2000, 2000, '2021-06-07', 'Yusnizar'),
('00003', 'BK 2390 QAC', 'Sepeda Motor', '00:04:16', '15:03:18', '14:59:59', 2000, 10000, '2021-06-07', 'Yusnizar');

-- --------------------------------------------------------

--
-- Struktur dari tabel `parkir_masuk`
--

CREATE TABLE `parkir_masuk` (
  `no_antrian` varchar(8) NOT NULL,
  `no_polisi` varchar(12) NOT NULL,
  `jenis_kendaraan` varchar(15) NOT NULL,
  `jam_masuk` varchar(15) NOT NULL,
  `operator` varchar(25) NOT NULL,
  `tanggal` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `parkir_masuk`
--

INSERT INTO `parkir_masuk` (`no_antrian`, `no_polisi`, `jenis_kendaraan`, `jam_masuk`, `operator`, `tanggal`) VALUES
('00001', 'BK 2343 VAM', 'Sepeda Motor', '00:00:40', 'Yusnizar', '2021-06-07'),
('00002', 'BK 1212 RAX', 'Sepeda Motor', '00:03:37', 'Yusnizar', '2021-06-07'),
('00003', 'BK 2390 QAC', 'Sepeda Motor', '00:04:16', 'Yusnizar', '2021-06-07'),
('00004', 'BK 2376 QAD', 'Sepeda Motor', '00:57:43', 'Yusnizar', '2021-06-07');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`username`);

--
-- Indeks untuk tabel `parkir_keluar`
--
ALTER TABLE `parkir_keluar`
  ADD PRIMARY KEY (`no_antrian`);

--
-- Indeks untuk tabel `parkir_masuk`
--
ALTER TABLE `parkir_masuk`
  ADD PRIMARY KEY (`no_antrian`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
