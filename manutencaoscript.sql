CREATE DATABASE  IF NOT EXISTS `manutencao_externa` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `manutencao_externa`;
-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: manutencao_externa
-- ------------------------------------------------------
-- Server version	5.7.13-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `equipamento`
--

DROP TABLE IF EXISTS `equipamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipamento` (
  `COD_EQUIPAMENTO` int(11) NOT NULL AUTO_INCREMENT,
  `DESCRICAO` varchar(80) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`COD_EQUIPAMENTO`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `externo`
--

DROP TABLE IF EXISTS `externo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `externo` (
  `COD_EXTERNO` int(11) NOT NULL AUTO_INCREMENT,
  `CODIGO` varchar(20) DEFAULT NULL,
  `OS` varchar(15) DEFAULT NULL,
  `DATA_ENTRADA` varchar(20) DEFAULT NULL,
  `DATA_SAIDA` varchar(20) DEFAULT NULL,
  `DATA_ORCAMENTO` varchar(20) DEFAULT NULL,
  `N_ORCAMENTO` varchar(20) DEFAULT NULL,
  `ORCAMENTO` varchar(240) DEFAULT NULL,
  `VALOR_ORCAMENTO` varchar(10) DEFAULT NULL,
  `DATA_REQUISICAO` varchar(20) DEFAULT NULL,
  `REQ_PECAS` varchar(10) DEFAULT NULL,
  `REQ_MOBRA` varchar(10) DEFAULT NULL,
  `DATA_APROVACAO` varchar(20) DEFAULT NULL,
  `DATA_PEDIDO` varchar(20) DEFAULT NULL,
  `PED_PECAS` varchar(12) DEFAULT NULL,
  `PED_MOBRA` varchar(12) DEFAULT NULL,
  `DATA_PREVISTA` varchar(20) DEFAULT NULL,
  `DATA_COBRANCA` varchar(20) DEFAULT NULL,
  `VIA_COBRANCA` varchar(20) DEFAULT NULL,
  `DATA_ENTREGA` varchar(20) DEFAULT NULL,
  `OBSERVACOES` varchar(250) DEFAULT NULL,
  `COD_EQUIPAMENTO` int(11) NOT NULL,
  `COD_SETOR` int(11) NOT NULL,
  `COD_FORNECEDOR` int(11) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`COD_EXTERNO`),
  KEY `COD_EQUIPAMENTO` (`COD_EQUIPAMENTO`),
  KEY `COD_SETOR` (`COD_SETOR`),
  KEY `COD_FORNECEDOR` (`COD_FORNECEDOR`),
  CONSTRAINT `externo_ibfk_1` FOREIGN KEY (`COD_EQUIPAMENTO`) REFERENCES `equipamento` (`COD_EQUIPAMENTO`),
  CONSTRAINT `externo_ibfk_2` FOREIGN KEY (`COD_SETOR`) REFERENCES `setor` (`COD_SETOR`),
  CONSTRAINT `externo_ibfk_3` FOREIGN KEY (`COD_FORNECEDOR`) REFERENCES `fornecedor` (`COD_FORNECEDOR`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `externo`
--

--
-- Table structure for table `fornecedor`
--

DROP TABLE IF EXISTS `fornecedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fornecedor` (
  `COD_FORNECEDOR` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(50) NOT NULL,
  `CONTATO` varchar(50) NOT NULL,
  `EMAIL` varchar(50) NOT NULL,
  `TELEFONE` varchar(50) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`COD_FORNECEDOR`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `setor`
--

DROP TABLE IF EXISTS `setor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `setor` (
  `COD_SETOR` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(50) NOT NULL,
  `ENFRESPONSAVEL` varchar(50) NOT NULL,
  `COORDRESPONSAVEL` varchar(50) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`COD_SETOR`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;



/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-09-01  8:15:31
