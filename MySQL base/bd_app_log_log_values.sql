-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: bd_app_log
-- ------------------------------------------------------
-- Server version	5.7.11-log

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
-- Table structure for table `log_values`
--

DROP TABLE IF EXISTS `log_values`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `log_values` (
  `id_log_value` int(11) NOT NULL AUTO_INCREMENT,
  `id_account_worker` int(11) NOT NULL,
  `id_account_sudent` int(11) NOT NULL,
  `id_discipline` int(11) NOT NULL,
  `log_value_date` date NOT NULL,
  `log_value` enum('1','2','3','4','5','Б','У','Н') NOT NULL,
  PRIMARY KEY (`id_log_value`),
  UNIQUE KEY `log_value_UNIQUE` (`id_account_sudent`,`id_discipline`,`log_value_date`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log_values`
--

LOCK TABLES `log_values` WRITE;
/*!40000 ALTER TABLE `log_values` DISABLE KEYS */;
INSERT INTO `log_values` VALUES (1,1,11,1,'2016-04-20','1'),(2,1,11,1,'2016-04-21','2'),(3,1,12,1,'2016-04-21','3'),(4,1,11,1,'2016-04-26','4'),(5,1,11,1,'2016-04-27','5'),(6,1,11,2,'2016-04-21','5'),(7,0,11,1,'2016-04-01','5'),(9,0,11,1,'2016-04-02','5'),(15,0,16,1,'2016-04-00','5'),(16,0,11,1,'2016-04-00','5'),(25,0,23,1,'2016-04-25','У'),(28,0,17,1,'2016-04-19','4'),(29,2,6,5,'2016-04-25','Б'),(30,2,8,5,'2016-11-21','5'),(31,2,7,5,'2016-09-12','Б'),(33,0,7,5,'2015-09-21','2'),(35,0,6,5,'2015-09-28','У');
/*!40000 ALTER TABLE `log_values` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-05-04 13:49:43
