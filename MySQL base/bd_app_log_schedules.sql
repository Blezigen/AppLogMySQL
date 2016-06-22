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
-- Table structure for table `schedules`
--

DROP TABLE IF EXISTS `schedules`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `schedules` (
  `id_schedules` int(11) NOT NULL AUTO_INCREMENT,
  `id_group` int(11) NOT NULL,
  `id_discipline` int(11) NOT NULL,
  `id_para` int(11) NOT NULL DEFAULT '1',
  `id_account_teacher` int(11) NOT NULL DEFAULT '0',
  `schedules_index_day_of_week` enum('1','2','3','4','5','6') DEFAULT '1',
  PRIMARY KEY (`id_schedules`),
  UNIQUE KEY `id_group_UNIQUE` (`id_group`,`id_para`,`schedules_index_day_of_week`),
  UNIQUE KEY `id_discipline_UNIQUE` (`id_group`,`schedules_index_day_of_week`,`id_para`,`id_discipline`),
  KEY `fk_schedule_para_idx` (`id_para`),
  KEY `fk_schedule_discipline_idx` (`id_discipline`),
  KEY `fk_schedule_group_idx` (`id_group`),
  KEY `fk_schedule_account_idx` (`id_account_teacher`),
  CONSTRAINT `fk_schedule_account` FOREIGN KEY (`id_account_teacher`) REFERENCES `accounts` (`id_account`),
  CONSTRAINT `fk_schedule_discipline` FOREIGN KEY (`id_discipline`) REFERENCES `discipline` (`id_discipline`),
  CONSTRAINT `fk_schedule_group` FOREIGN KEY (`id_group`) REFERENCES `groups` (`id_group`),
  CONSTRAINT `fk_schedule_para` FOREIGN KEY (`id_para`) REFERENCES `para` (`id_para`)
) ENGINE=InnoDB AUTO_INCREMENT=211 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `schedules`
--

LOCK TABLES `schedules` WRITE;
/*!40000 ALTER TABLE `schedules` DISABLE KEYS */;
INSERT INTO `schedules` VALUES (1,1,4,1,-1,'1'),(2,1,1,2,-1,'1'),(3,1,2,3,-1,'1'),(4,1,9,4,-1,'1'),(5,1,0,5,-1,'1'),(6,1,0,6,-1,'1'),(7,1,0,7,-1,'1'),(8,1,1,1,2,'2'),(9,1,1,2,3,'2'),(10,1,0,3,-1,'2'),(11,1,1,4,3,'2'),(12,1,0,5,-1,'2'),(13,1,0,6,-1,'2'),(14,1,0,7,-1,'2'),(15,1,0,1,-1,'3'),(16,1,0,2,-1,'3'),(17,1,0,3,-1,'3'),(18,1,0,4,-1,'3'),(19,1,0,5,-1,'3'),(20,1,0,6,-1,'3'),(21,1,0,7,-1,'3'),(22,1,0,1,-1,'4'),(23,1,0,2,-1,'4'),(24,1,0,3,-1,'4'),(25,1,0,4,-1,'4'),(26,1,0,5,-1,'4'),(27,1,0,6,-1,'4'),(28,1,0,7,-1,'4'),(29,1,0,1,-1,'5'),(30,1,0,2,-1,'5'),(31,1,0,3,-1,'5'),(32,1,0,4,-1,'5'),(33,1,0,5,-1,'5'),(34,1,0,6,-1,'5'),(35,1,0,7,-1,'5'),(36,1,0,1,-1,'6'),(37,1,0,2,-1,'6'),(38,1,0,3,-1,'6'),(39,1,0,4,-1,'6'),(40,1,0,5,-1,'6'),(41,1,0,6,-1,'6'),(42,1,0,7,-1,'6'),(43,2,5,1,2,'1'),(44,2,0,2,-1,'1'),(45,2,0,3,-1,'1'),(46,2,0,4,-1,'1'),(47,2,0,5,-1,'1'),(48,2,0,6,-1,'1'),(49,2,0,7,-1,'1'),(50,2,0,1,-1,'2'),(51,2,0,2,-1,'2'),(52,2,0,3,-1,'2'),(53,2,0,4,-1,'2'),(54,2,0,5,-1,'2'),(55,2,0,6,-1,'2'),(56,2,0,7,-1,'2'),(57,2,0,1,-1,'3'),(58,2,0,2,-1,'3'),(59,2,0,3,-1,'3'),(60,2,0,4,-1,'3'),(61,2,0,5,-1,'3'),(62,2,0,6,-1,'3'),(63,2,0,7,-1,'3'),(64,2,0,1,-1,'4'),(65,2,0,2,-1,'4'),(66,2,0,3,-1,'4'),(67,2,0,4,-1,'4'),(68,2,0,5,-1,'4'),(69,2,0,6,-1,'4'),(70,2,0,7,-1,'4'),(71,2,0,1,-1,'5'),(72,2,0,2,-1,'5'),(73,2,0,3,-1,'5'),(74,2,0,4,-1,'5'),(75,2,0,5,-1,'5'),(76,2,0,6,-1,'5'),(77,2,0,7,-1,'5'),(78,2,0,1,-1,'6'),(79,2,0,2,-1,'6'),(80,2,0,3,-1,'6'),(81,2,0,4,-1,'6'),(82,2,0,5,-1,'6'),(83,2,0,6,-1,'6'),(84,2,0,7,-1,'6'),(85,3,1,1,2,'1'),(86,3,0,2,-1,'1'),(87,3,0,3,-1,'1'),(88,3,0,4,-1,'1'),(89,3,0,5,-1,'1'),(90,3,0,6,-1,'1'),(91,3,0,7,-1,'1'),(92,3,1,1,2,'2'),(93,3,0,2,-1,'2'),(94,3,0,3,-1,'2'),(95,3,0,4,-1,'2'),(96,3,0,5,-1,'2'),(97,3,0,6,-1,'2'),(98,3,0,7,-1,'2'),(99,3,1,1,2,'3'),(100,3,0,2,-1,'3'),(101,3,0,3,-1,'3'),(102,3,0,4,-1,'3'),(103,3,0,5,-1,'3'),(104,3,0,6,-1,'3'),(105,3,0,7,-1,'3'),(106,3,5,1,2,'4'),(107,3,0,2,-1,'4'),(108,3,0,3,-1,'4'),(109,3,0,4,-1,'4'),(110,3,0,5,-1,'4'),(111,3,0,6,-1,'4'),(112,3,0,7,-1,'4'),(113,3,1,1,2,'5'),(114,3,0,2,-1,'5'),(115,3,0,3,-1,'5'),(116,3,0,4,-1,'5'),(117,3,0,5,-1,'5'),(118,3,0,6,-1,'5'),(119,3,0,7,-1,'5'),(120,3,1,1,2,'6'),(121,3,0,2,-1,'6'),(122,3,0,3,-1,'6'),(123,3,0,4,-1,'6'),(124,3,0,5,-1,'6'),(125,3,0,6,-1,'6'),(126,3,0,7,-1,'6'),(127,4,6,1,-1,'1'),(128,4,0,2,-1,'1'),(129,4,3,3,-1,'1'),(130,4,0,4,-1,'1'),(131,4,0,5,-1,'1'),(132,4,0,6,-1,'1'),(133,4,0,7,-1,'1'),(134,4,0,1,-1,'2'),(135,4,0,2,-1,'2'),(136,4,0,3,-1,'2'),(137,4,0,4,-1,'2'),(138,4,0,5,-1,'2'),(139,4,0,6,-1,'2'),(140,4,0,7,-1,'2'),(141,4,0,1,-1,'3'),(142,4,0,2,-1,'3'),(143,4,0,3,-1,'3'),(144,4,0,4,-1,'3'),(145,4,0,5,-1,'3'),(146,4,0,6,-1,'3'),(147,4,0,7,-1,'3'),(148,4,0,1,-1,'4'),(149,4,0,2,-1,'4'),(150,4,0,3,-1,'4'),(151,4,0,4,-1,'4'),(152,4,0,5,-1,'4'),(153,4,0,6,-1,'4'),(154,4,0,7,-1,'4'),(155,4,0,1,-1,'5'),(156,4,0,2,-1,'5'),(157,4,0,3,-1,'5'),(158,4,0,4,-1,'5'),(159,4,0,5,-1,'5'),(160,4,0,6,-1,'5'),(161,4,0,7,-1,'5'),(162,4,0,1,-1,'6'),(163,4,0,2,-1,'6'),(164,4,0,3,-1,'6'),(165,4,0,4,-1,'6'),(166,4,0,5,-1,'6'),(167,4,0,6,-1,'6'),(168,4,0,7,-1,'6'),(169,5,0,1,-1,'1'),(170,5,0,2,-1,'1'),(171,5,0,3,-1,'1'),(172,5,0,4,-1,'1'),(173,5,0,5,-1,'1'),(174,5,0,6,-1,'1'),(175,5,0,7,-1,'1'),(176,5,0,1,-1,'2'),(177,5,0,2,-1,'2'),(178,5,0,3,-1,'2'),(179,5,0,4,-1,'2'),(180,5,0,5,-1,'2'),(181,5,0,6,-1,'2'),(182,5,0,7,-1,'2'),(183,5,0,1,-1,'3'),(184,5,0,2,-1,'3'),(185,5,0,3,-1,'3'),(186,5,0,4,-1,'3'),(187,5,0,5,-1,'3'),(188,5,0,6,-1,'3'),(189,5,0,7,-1,'3'),(190,5,0,1,-1,'4'),(191,5,0,2,-1,'4'),(192,5,0,3,-1,'4'),(193,5,0,4,-1,'4'),(194,5,0,5,-1,'4'),(195,5,0,6,-1,'4'),(196,5,0,7,-1,'4'),(197,5,0,1,-1,'5'),(198,5,0,2,-1,'5'),(199,5,0,3,-1,'5'),(200,5,0,4,-1,'5'),(201,5,0,5,-1,'5'),(202,5,0,6,-1,'5'),(203,5,0,7,-1,'5'),(204,5,0,1,-1,'6'),(205,5,0,2,-1,'6'),(206,5,0,3,-1,'6'),(207,5,0,4,-1,'6'),(208,5,0,5,-1,'6'),(209,5,0,6,-1,'6'),(210,5,0,7,-1,'6');
/*!40000 ALTER TABLE `schedules` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-05-04 13:49:42