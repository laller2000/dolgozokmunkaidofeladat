-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Már 05. 16:40
-- Kiszolgáló verziója: 10.4.22-MariaDB
-- PHP verzió: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `dolgozokmunkaido`
--
CREATE DATABASE IF NOT EXISTS `dolgozokmunkaido` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `dolgozokmunkaido`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vizsga_dolgozo`
--

CREATE TABLE IF NOT EXISTS `vizsga_dolgozo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `vezeteknev` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `keresztnev` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `adoszam` varchar(11) COLLATE utf8_hungarian_ci NOT NULL,
  `anyja_neve` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `vizsga_dolgozo`
--

INSERT INTO `vizsga_dolgozo` (`id`, `vezeteknev`, `keresztnev`, `adoszam`, `anyja_neve`) VALUES
(1, 'Kiss ', 'Manyi', '12345678910', 'Nagy Erzsi'),
(2, 'Nagy ', 'Imre', '12345678916', 'Kiss Ilona'),
(3, 'Tompa', 'Mihály', '12345678911', 'Éles Janka'),
(4, 'Teszt', 'Gabor', '12345678919', 'Teszt Zsófi');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vizsga_munkaido`
--

CREATE TABLE IF NOT EXISTS `vizsga_munkaido` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `dolgozoID` int(11) NOT NULL,
  `mettol` date NOT NULL,
  `meddig` date NOT NULL,
  `tulora` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `dolgozoID` (`dolgozoID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `vizsga_munkaido`
--

INSERT INTO `vizsga_munkaido` (`id`, `dolgozoID`, `mettol`, `meddig`, `tulora`) VALUES
(1, 1, '2015-01-01', '2015-01-08', 7),
(2, 2, '2015-01-11', '2015-01-15', 2),
(3, 3, '2015-01-01', '2015-01-08', 5);

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `vizsga_munkaido`
--
ALTER TABLE `vizsga_munkaido`
  ADD CONSTRAINT `FK_dolgozo` FOREIGN KEY (`dolgozoID`) REFERENCES `vizsga_dolgozo` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
