-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 31 mai 2022 à 10:18
-- Version du serveur : 5.7.36
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `pokemon_fight`
--

-- --------------------------------------------------------

--
-- Structure de la table `be_friend`
--

DROP TABLE IF EXISTS `be_friend`;
CREATE TABLE IF NOT EXISTS `be_friend` (
  `ID_EMITTER` int(2) NOT NULL,
  `ID_RECEIVER` int(2) NOT NULL,
  `IS_FRIEND` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_EMITTER`,`ID_RECEIVER`),
  KEY `FK_BE_FRIEND_USERS1` (`ID_RECEIVER`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `card`
--

DROP TABLE IF EXISTS `card`;
CREATE TABLE IF NOT EXISTS `card` (
  `ID_CARD` int(2) NOT NULL AUTO_INCREMENT,
  `NAME` char(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `DESCRIPTION` char(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`ID_CARD`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `catch`
--

DROP TABLE IF EXISTS `catch`;
CREATE TABLE IF NOT EXISTS `catch` (
  `ID_USER` int(2) NOT NULL,
  `ID_CARD` int(2) NOT NULL,
  `NBR_CARD` int(2) DEFAULT NULL,
  PRIMARY KEY (`ID_USER`,`ID_CARD`),
  KEY `FK_CATCH_CARD` (`ID_CARD`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `deck`
--

DROP TABLE IF EXISTS `deck`;
CREATE TABLE IF NOT EXISTS `deck` (
  `ID_USER` int(2) NOT NULL,
  `ID_DECK` int(2) NOT NULL AUTO_INCREMENT,
  `NAME` char(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`ID_USER`,`ID_DECK`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `deck`
--

INSERT INTO `deck` (`ID_USER`, `ID_DECK`, `NAME`) VALUES
(1, 1, 'Nouveau Deck'),
(1, 2, 'Nouveau Deck'),
(1, 5, 'Nouveau Deck'),
(1, 4, 'Nouveau Deck'),
(1, 3, 'Nouveau Deck');

-- --------------------------------------------------------

--
-- Structure de la table `exist`
--

DROP TABLE IF EXISTS `exist`;
CREATE TABLE IF NOT EXISTS `exist` (
  `ID_USER` int(2) NOT NULL,
  `ID_CARD` int(2) NOT NULL,
  `ID_DECK` int(2) NOT NULL,
  `NBR_CARD` int(2) DEFAULT NULL,
  PRIMARY KEY (`ID_USER`,`ID_CARD`,`ID_DECK`),
  KEY `FK_EXIST_DECK` (`ID_USER`,`ID_DECK`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `fighting`
--

DROP TABLE IF EXISTS `fighting`;
CREATE TABLE IF NOT EXISTS `fighting` (
  `ID_FIGHT` double(5,2) NOT NULL AUTO_INCREMENT,
  `ID_USER` int(2) NOT NULL,
  `ID_USER_WINNER` int(2) NOT NULL,
  PRIMARY KEY (`ID_FIGHT`),
  KEY `FK_FIGHTING_USERS` (`ID_USER`),
  KEY `FK_FIGHTING_USERS1` (`ID_USER_WINNER`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `level`
--

DROP TABLE IF EXISTS `level`;
CREATE TABLE IF NOT EXISTS `level` (
  `ID_LEVEL` int(2) NOT NULL,
  `START_XP` char(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `END_XP` char(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`ID_LEVEL`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `ID_USER` int(2) NOT NULL AUTO_INCREMENT,
  `ID_USER_BE_SPONSORED` int(2) DEFAULT NULL,
  `ID_LEVEL` int(2) NOT NULL,
  `NAME` char(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `FIRSTNAME` char(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `NICKNAME` char(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `SPONSORSHIP_CODE` char(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `MAIL` char(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `PASSWORD` char(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CREATION_DATE` char(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `XP` bigint(4) DEFAULT NULL,
  PRIMARY KEY (`ID_USER`),
  KEY `FK_USERS_USERS` (`ID_USER_BE_SPONSORED`),
  KEY `FK_USERS_LEVEL` (`ID_LEVEL`)
) ENGINE=MyISAM AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`ID_USER`, `ID_USER_BE_SPONSORED`, `ID_LEVEL`, `NAME`, `FIRSTNAME`, `NICKNAME`, `SPONSORSHIP_CODE`, `MAIL`, `PASSWORD`, `CREATION_DATE`, `XP`) VALUES
(1, NULL, 0, 'SABI', 'Kader', 'custromix', 'K120220513S', 'test@gmail.com', '$2a$11$6xtCr5PRl1eXI.Gk6gtrWe5QntGufKb1I0qQkgw2YFGiTCseEoYmm', '2022-05-13 00:00:00', NULL);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
