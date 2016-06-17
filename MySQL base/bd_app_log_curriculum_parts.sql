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
-- Table structure for table `curriculum_parts`
--

DROP TABLE IF EXISTS `curriculum_parts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `curriculum_parts` (
  `id_curriculum_part` int(11) NOT NULL AUTO_INCREMENT,
  `id_curriculum` int(11) NOT NULL DEFAULT '0',
  `id_discipline` int(11) NOT NULL DEFAULT '0',
  `curr_part_count_lectures` int(11) NOT NULL DEFAULT '0' COMMENT 'количество лекций этого предмета в этом семестре',
  `curr_part_count_workexp` int(11) NOT NULL DEFAULT '0' COMMENT 'количество домашней работы этого предмета в этом семестре',
  `curr_part_count_selfwork` int(11) NOT NULL DEFAULT '0' COMMENT 'Самостоятельная работа',
  `curr_part_cred_term` bit(2) NOT NULL DEFAULT b'0' COMMENT 'Будет ли зачет в этом симестре',
  `curr_part_exam_term` bit(2) NOT NULL DEFAULT b'0' COMMENT 'Будет ли экзамен в этом симестре',
  PRIMARY KEY (`id_curriculum_part`),
  UNIQUE KEY `fk_uniqum_curiculumb_discipline` (`id_curriculum`,`id_discipline`),
  UNIQUE KEY `id_curriculum_UNIQUE` (`id_curriculum`,`id_discipline`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `curriculum_parts`
--

LOCK TABLES `curriculum_parts` WRITE;
/*!40000 ALTER TABLE `curriculum_parts` DISABLE KEYS */;
INSERT INTO `curriculum_parts` VALUES (3,1,5,0,0,0,'\0',''),(5,3,4,0,0,0,'\0',''),(6,3,6,0,0,0,'','\0'),(7,3,7,0,0,0,'\0',''),(8,1,4,0,0,0,'\0','\0'),(13,1,7,0,0,0,'\0','\0'),(14,1,3,0,0,0,'\0','\0'),(15,1,6,0,0,0,'\0','\0'),(16,1,9,0,0,0,'\0','\0'),(19,1,1,0,0,0,'\0','\0'),(20,1,2,0,0,0,'\0','\0');
/*!40000 ALTER TABLE `curriculum_parts` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-05-04 13:49:41
