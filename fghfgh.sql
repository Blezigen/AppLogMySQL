-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: bd_app_log
-- ------------------------------------------------------
-- Server version	5.7.12-log

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
-- Table structure for table `account_data`
--

DROP TABLE IF EXISTS `account_data`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `account_data` (
  `id_account_data` int(11) NOT NULL AUTO_INCREMENT,
  `id_account` int(11) NOT NULL DEFAULT '0',
  `id_account_data_field` int(11) NOT NULL,
  `account_data_field_value` varchar(128) NOT NULL,
  PRIMARY KEY (`id_account_data`),
  KEY `fk_account_data_account_data_field1_idx` (`id_account_data_field`),
  KEY `fk_account_data_accounts1_idx` (`id_account`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `account_data`
--

LOCK TABLES `account_data` WRITE;
/*!40000 ALTER TABLE `account_data` DISABLE KEYS */;
/*!40000 ALTER TABLE `account_data` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `account_data_field`
--

DROP TABLE IF EXISTS `account_data_field`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `account_data_field` (
  `id_account_data_field` int(11) NOT NULL AUTO_INCREMENT,
  `account_data_field_name` varchar(25) NOT NULL,
  `account_data_field_title` varchar(60) NOT NULL,
  PRIMARY KEY (`id_account_data_field`),
  UNIQUE KEY `account_data_field_name_UNIQUE` (`account_data_field_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `account_data_field`
--

LOCK TABLES `account_data_field` WRITE;
/*!40000 ALTER TABLE `account_data_field` DISABLE KEYS */;
/*!40000 ALTER TABLE `account_data_field` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `accounts`
--

DROP TABLE IF EXISTS `accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `accounts` (
  `id_account` int(11) NOT NULL AUTO_INCREMENT,
  `id_permission` int(11) NOT NULL,
  `account_login` varchar(25) NOT NULL,
  `account_password` varchar(25) NOT NULL,
  `account_first_name` varchar(65) NOT NULL,
  `account_last_name` varchar(65) NOT NULL,
  `account_second_name` varchar(65) DEFAULT 'не указано',
  `account_legal_adress` varchar(60) DEFAULT 'не указан',
  `account_telphone` varchar(20) DEFAULT 'jhjhjjh',
  `account_gender` enum('Мужской','Женский') DEFAULT 'Мужской',
  `account_bithdate` date DEFAULT NULL,
  `account_image` longblob,
  PRIMARY KEY (`id_account`),
  UNIQUE KEY `account_login` (`account_login`),
  KEY `fk_accounts_permissions1_idx` (`id_permission`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accounts`
--

LOCK TABLES `accounts` WRITE;
/*!40000 ALTER TABLE `accounts` DISABLE KEYS */;
INSERT INTO `accounts` VALUES (-1,2,'Empty','Empty',' ',' ',' ','не указан','jhjhjjh','Мужской',NULL,NULL),(0,1,'Admin','admin','Ильяс','Хайруллин','Шамилевич','Курчатова 5 56','89274361277','Мужской','1996-06-21','�\��\�\0JFIF\0\0\0\0\0\0�\�\0~Exif\0\0II*\0\0\0\0\01\0\0\0\0&\0\0\0i�\0\0\0\0.\0\0\0\0\0\0\0Google\0\0\0\0�\0\0\0\00220�\0\0\0\0\0\0\0�\0\0\0\0X\0\0\0\0\0\0\0\0\0\0\0\0\0R98\0\0\0\0\0\00100\0\0\0\0�\�\0�\0\n			\r\n\r	\r\r\r\r\r\r��\0\0�\0�\0�\�\0\0\0\0\0\0\0\0\0\0\0\0\0\0	�\�\0D\0\0\0\0\0\0!1Q�\�\"ARa	2�#3Bq��$Us�\�\�%&45CSr����\�\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0�\�\0\0\0\0\0\0\0\0\0\0\0q!��\���\�\0\0\0?\0�ڛ\�o3A�\�\�3y�����\�\�`���\�\�\�f�>��\�\�o\�}hV��1��7P\�3~c\�A���?\�>�C|\�����\�o\�}hg��1��\�\�7\�ߘ�\�\Z���\�\�|����\�\�g�7\�\�f�=��f�4\�M�7��J�(6A�Z₁\�V�ȱ\�\\;����\� �Qq�b~�0\�\\g҈g-�9m���E�P�Z\rH��A�A��(CoPI\�\�kEM\�bI�QS���A-o��J)�\�Ur�$<#T*4����9J\"H`(e\�\�F��\�9|:)�\�\��(!opJ\"\n��ª!\�-4�#冨@�Ƞ\��P(�@�*	{+h�l^]9TQv3����pJ�z\�fυ�ĤH\�J\�h5grTx�y�\��e�;2�\�H\�\Z�\�\�_u\�r\"��\�\�>?��}(r�?�P%�\�\�T]Z\�FQ�\�T7aA��\�E�x�&,mu��\�F+Z(\��\�ʢ��\rt\�P\�`�ap\\\�M��\��p=\�\�]�CI\�V\�ZM\�\�fPO�*�d��\�.I\Z|e���1�\�:�����*\�^(L^��䑪\��f_\�\�M;\��\Z\�[�<\ro��\��`\�\�5�A��+\'?�SRI\�\�m��-�ͪ�\n���`*�\�\08|��@O\�\�R\�g��\�\�e���\�6?{u�bʯ�ЋvH\�\\rF\��\��xUuߍ�\��d!��\�\Z��\rEe��yPfp�yULv�\n���Ҍ�eM*�H�R1A)g\r@S��\�J4?�c:r���\�NU\�\��k�\��,C%\�\��Fi�ۀ�`h\�m^!�����:�%u��O�\�v<\"�\�=\�Iѣ|�\�\�.�	,�J�ꑛt�3\"���f:\�VWr\�\�\n{5j�\�<�\�Q�h8O�7q�\�\�}��8M)Y�5��>\�!\0P\�3�3<\�\�+�#�\�\�A���\�;\�u��㷞[[�\�K�\��N���\�J����\�\���9�\�U\0\�;]5����&dUۭ\�6\Z�;�\�t�\�\�\��v�PX	\"۬%�޸��\�\"\0!f�~l��xj\�\�\�m\�tV\�Dz3݋�2`�k�\�$\�\�\�Y9��V��\�I/٢�8\� ���\�\����#Q~\�T;H\�PcE@��\�3�=9�Py\�\�۰$\�\�.VԨ\�\�\\ ����l�f2�����\�@F%\�\�sղֹ\�jp�I\�\�QU�zǭQ\\\�\�t֪/c�(\�*�6���1Yic\���J*ᠴ��@�\�IWxj�Ȥ�@ ����:�\�g�Rm5��v;�\�vYs���Mk��\�\�\�h��D��I��0w�+�Z�kӸ9��&��\0I�Vem���#2��Z�e:2�3ꬤhAЃAfc�\�TIbt�9d�H\�:I�dtu\�YHee$0 �A��>4t�m\�>;#9������\�\��j%(q�t\�(K\�wxk���/d{V\�d���\�\��\rV�lom�\�%rB4�\�I\n+B�\��\�j{C\��K\�i!���\�\�+�c�1,H\�9BJ��H\�%\\\rWS�\Z\�x�6g3i\�I��\�kL\�>{�F����%�19���*�X̜\�\��\�h5���\�Z\�MW\�\�\�DdS�TC?Z�qg@W�\�E�3gW�F�9�\0�m���I����\�\�\�\��\�`���c��y��\�U�dv��\�\�Oimq��a�\�)��\�\��cT*#@ڰ�$z�B>\�\�(4\�\��H@2K-��W��\\�$���1\��\'�\�c}�ɋ�\����)n\�\�fUD��d� \�[*3kl��}91\�PX\�T|�PQ�Aݺ\����\�7\"f-�\'�\�䡆KlIH�\'�-�O��Ѵ��\�5�5\�wl\�X\�Z]a���J\�y:\�)	\������#���\�\�\�\�E���T�\�K�\0�TZv�(8�\�� \�\�2Z\�u\�[{\05ӧ�X���������u�\02}j����T-hh\np\�\�TU���t�\�\�\�+��,^\�;s��\�|\�\�qX[σ�f�\�I\n5\�\���n�!�w\�*���C\�|t\�z��[ck����\�x\�mgVhg�S��ѱR�N�ї�\�\�G#}�\�\�l�6�W\�2�\�Y\�V\�I\'\�-�#tch�d� �\�5\�{J\�?+#<�|e�\�\�\�C!�\�\�G��&|NZ\\=�GD�\�\�\�\�tER\��9ߓ\� �zh%�lYvK\���\�IQ_$��\�~��w�\�\��c��\�X[Z�\�T�.V���C��\�\�}Wywy���|[׽�&���_oR{8\�\�\�e3Cgle\�F\�\�3/g�Md�䑵�Goy��\�4\0\�\�x�%\�\�%�����զ�	\�\�\�)8���\�0\�i#u�\�O*�\�.\��~|e��so�\���M5UbBu:�\0Ti�R����hd\�U\0Y&��Y:�R\��#\�\�Ңŋ��]*4��j�\0{\�l\\�\��5�m\�Xɽ�;��]\�\�罯ҵ���4���\�\�f��(���p�\�P]^\\�\��	\��\�Ì\�#( k�Tu�z[\�2��h1�\�v\�/Q\�\�\rؠ����3�h\ZC�;\�@\r\�\��\�\�\�\�,�n\�{M��\�\�\�3\�?<�\�k��{<���{h\�t�\�e<Xd!F�W\�\']%�m�&L�:(v\���\�yY�P|n\�p�\��\�+/�\�>;t\�\�\�<\�O#m��-�C!a{&�\�=�(\�A��I\"R@,\�7H��,���g�{�\�nԻ\�a1�WY	/\�.��Q#[\�^YOw(i7a�\�T;\r�\�7���ԀG�\�q�\�ѽ��6��-���2�L\�\\�#�\�\�O\rH]�؋[hm�\ZA�hI�<��	�\�\n�����\�PV�Aqִ���\�FQD\�antX�j(\�{Ң����\�EE��\�.Bu\0\�U��s]\�<�T\�[`>\�XQ�H��Qئ�kr6��4.GN�V� ��\�ٹ��\�\�en\�\�k\�\0\�٩h%M�b\ZPT���\�TR��\0f�\�0�+cnE\���ac\�\�O��Z\n�}�\�\\1��\�ܛ@~��x$��<\�+.\���f6pƹX\"�\�\�\Z\�`���#v�#\�財մ\�S\�j���\�\��*�\Z\�~r�x\�7��\r㶑[X\��\��\��\�Yj\n��)�<\�*�\�\���+�\�֤\�@�\�d���\�	Y�lM\�QV\'ңK�\�Nu�\�lZd��W�����ތ\�A\��?Ϊ9hp/o!G\Zds7�G\�f�O\�Z\�/E�����\�=��\�]2Cm�t�(-\�ᶊ;k3\r��y_��7\ZM\�;�\�\�Pt��.\�*\�\�f큵3q�\0Gu�=\�\�k�\�h�;E߻eR\�F�/o4�e��H.U�E\�*�[\�f\�u\�\�y�\�\�]\�\�\�e�`\�؉L�v���߂�\r4QF�\�;È[t�Q	\�?f\�u�U\�,A?�%�MREu\�p�s\�Ù�c�s�P�t\n�\�(���:\�J\�;�\�΂�\�d:\�@NF\�Z���꡹4��x�^\�\�.\�d�ӝ\Z\�r�9\�Q�=�\�۶(^ۙ�MfA\�@9��I\�6vb\\t<�\0�Ts%\�\�O!\�H$s�\�BG\�G\�V�#�\\��\���\�A�q��\\95�\0��(�?\�\�\�BN���ZEx���h�e\'�/���\�\�\�OƱZB ���}	\�\�;\�\�̪��:r\�Yh�\�u\�@�\��\�Te/�֫!۩���5Bf��QM\�y�	�\�(�\�N[\�QFX�\�NtQ~3h�i�/�@\�l}��䷉�\�J�\'\��:\�g�\��A�\0�hm�ǎb\�\r�_\�A�\�G\"$Xƚh�NCS�\0\�\�P\r\�3\�\�Ψ\�f~��<��P9ws�E\�&�B,h5�\��hF�{����C�\�i�;\�֊��\����?_\�Pi.\��j�ۼ�\0ւ�\09��\��\�w7Zєt�\�\r�\�iA�A�)�Q�\�7\�/4����tfM\�fύA�\�P\�|�񠍸\�Q�\\\����@�ɠ\�����|[\�zPg\�\�\�c҃>\�_���|[\�zQcq�_�ᩡDů�/Jhr���o1\�SL*�\�\�\�cҨPc\�\�\�cҦ�\�c��y�J�\�\'\Z<[�zT\�ɋ_�^�P�b�[\����|[\�zV�h\�u�o1\�Dk�B�����Ϻżǥ}о-\�=(?�\�'),(1,2,'teacher_test','12345','Lucas','Teacher','Liches','adress','88002003535','Мужской','0000-00-00',NULL),(2,2,'evIM','111111','Ирина','Евдокимова','Мехайловна','adress','88002003535','Женский','0000-00-00',NULL),(3,2,'safina','111111','Венера','Сафина','Карамовна','adress','88002003535','Женский','0000-00-00',NULL),(4,3,'login1','111111','Арсен','Абдурашитов','Шамильевич','adress','88002003535','Мужской','2016-10-21',NULL),(5,3,'login2','111111','Роберт','Аскаров','Ирекович','adress','88002003535','Мужской','2016-10-21',NULL),(6,3,'login3','111111','Алина','Байрутдинова','Маратовна','adress','88002003535','Мужской','2016-10-21',NULL),(7,3,'login4','111111','Святослав','Баранов','Вячеславович','adress','89273336677','Мужской','2016-10-21',NULL),(8,3,'login5','111111','Арсен','Галеев','Дамирович','adress','89273336677','Мужской','2016-10-21',NULL),(9,3,'login6','111111','Ангелина','Гамалий','Юрьевна','adress','89273336677','Мужской','2016-10-21',NULL),(10,3,'login7','111111','Андрей','Гецев','Сергеевич','adress','89273336677','Мужской','2016-10-21',NULL),(11,3,'login8','111111','Анна','Григорьева','Дмитриевна','adress','89273336677','Мужской','2016-10-21',NULL),(12,3,'login9','111111','Александра','Гришина','Витальевна','adress','89273336677','Мужской','2016-10-21',NULL),(13,3,'login10','111111','Илья','Еналеев','Андреевич','adress','89273336677','Мужской','2016-10-21',NULL),(14,3,'login11','111111','Рустем','Забиров','Рафаэлевич','adress','89273336677','Мужской','2016-10-21',NULL),(15,3,'login12','111111','Руслан','Зиганшин','Ривалевич','adress','89273336677','Мужской','2016-10-21',NULL),(16,3,'login13','111111','Артур','Иванов','Луидович','adress','89273336677','Мужской','2016-10-21',NULL),(17,3,'login14','111111','Иван','Киселев','Дмитриевич','adress','89273336677','Мужской','2016-10-21',NULL),(18,3,'login15','111111','Артур','Локоман','Эмилевич','adress','89273336677','Мужской','2016-10-21',NULL),(19,3,'login16','111111','Михаил','Матвеев','Михайлович','adress','89273336677','Мужской','2016-10-21',NULL),(20,3,'login17','111111','Диана','Мясникова','Владимировна','adress','89273336677','Мужской','2016-10-21',NULL),(21,3,'login18','111111','Севастьян','Новиков','Михайлович','adress','89273336677','Мужской','2016-10-21',NULL),(22,3,'login19','111111','Жавохир','Норов','Шодиевич','adress','89273336677','Мужской','2016-10-21',NULL),(23,3,'login20','111111','Илья','Павлов','Дмитриевич','adress','89273336677','Мужской','2016-10-21',NULL),(24,3,'login21','111111','Леонид','Петров','Олегович','adress','89273336677','Мужской','2016-10-21',NULL),(25,3,'login22','111111','Алмаз','Пудов','Альбертович','adress','89273336677','Мужской','2016-10-21',NULL),(26,3,'login23','111111','Альфия','Садыкова','Фоатовна','adress','89273336677','Мужской','2016-10-21',NULL),(27,3,'login24','111111','Салават','Сайфутдинов','Ирекович','adress','89273336677','Мужской','2016-10-21',NULL),(28,3,'login25','111111','Амир','Сибгатуллин','Агзамович','adress','89273336677','Мужской','2016-10-21',NULL),(29,3,'login26','111111','Антон','Чернов','Генадьевич','adress','89273336677','Мужской','2016-10-21',NULL),(30,3,'login27','111111','Данил','Шафигуллин','Маратович','adress','89273336677','Мужской','2016-10-21',NULL),(31,3,'login28','111111','Константин','Шингирей','Андреевич','adress','89273336677','Мужской','2016-10-21',NULL),(32,3,'login29','111111','Кирилл','Шляхтин','Алексеевич','adress','89273336677','Мужской','2016-10-21',NULL);
/*!40000 ALTER TABLE `accounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `curriculum`
--

DROP TABLE IF EXISTS `curriculum`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `curriculum` (
  `id_curriculum` int(11) NOT NULL AUTO_INCREMENT,
  `id_specialization` int(11) NOT NULL,
  `curriculum_term` int(11) NOT NULL COMMENT 'Номер симестра ученого плана ',
  PRIMARY KEY (`id_curriculum`),
  UNIQUE KEY `fk_uniqum_specialization_term` (`id_specialization`,`curriculum_term`),
  KEY `fk_curriculum_specializations1_idx` (`id_specialization`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `curriculum`
--

LOCK TABLES `curriculum` WRITE;
/*!40000 ALTER TABLE `curriculum` DISABLE KEYS */;
INSERT INTO `curriculum` VALUES (1,1,1),(2,1,2),(3,2,1);
/*!40000 ALTER TABLE `curriculum` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `discipline`
--

DROP TABLE IF EXISTS `discipline`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `discipline` (
  `id_discipline` int(11) NOT NULL AUTO_INCREMENT,
  `discipline_code` varchar(30) NOT NULL,
  `discipline_name` varchar(256) NOT NULL,
  PRIMARY KEY (`id_discipline`),
  UNIQUE KEY `discipline_code_UNIQUE` (`discipline_code`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `discipline`
--

LOCK TABLES `discipline` WRITE;
/*!40000 ALTER TABLE `discipline` DISABLE KEYS */;
INSERT INTO `discipline` VALUES (0,'0',''),(1,'AO','Программирование'),(2,'ывфы','Системное Администрирование'),(3,'фывф','Класика Лексики'),(4,'фыв','Детерминантное программирование'),(5,'ффыв','Практика'),(6,'0284','Логика'),(7,'228','Кирриллатор'),(9,'999','ПМ999');
/*!40000 ALTER TABLE `discipline` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `getacctountdataview`
--

DROP TABLE IF EXISTS `getacctountdataview`;
/*!50001 DROP VIEW IF EXISTS `getacctountdataview`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `getacctountdataview` AS SELECT 
 1 AS `id:`,
 1 AS `Имя:`,
 1 AS `Фамилия:`,
 1 AS `Отчество:`,
 1 AS `Домашний адресс:`,
 1 AS `Телефон:`,
 1 AS `Пол:`,
 1 AS `Дата рождения:`,
 1 AS `account_image`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `groups`
--

DROP TABLE IF EXISTS `groups`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `groups` (
  `id_group` int(11) NOT NULL AUTO_INCREMENT,
  `id_specialization` int(11) NOT NULL,
  `id_account_curator` int(11) NOT NULL DEFAULT '0',
  `group_name` varchar(25) NOT NULL,
  `group_date_start_learn` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_group`),
  UNIQUE KEY `group_name_UNIQUE` (`group_name`),
  KEY `fk_groups_specializations1_idx` (`id_specialization`),
  CONSTRAINT `FK_specialisation_group` FOREIGN KEY (`id_specialization`) REFERENCES `specializations` (`id_specialization`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `groups`
--

LOCK TABLES `groups` WRITE;
/*!40000 ALTER TABLE `groups` DISABLE KEYS */;
INSERT INTO `groups` VALUES (1,1,2,'ПМ121-1',1),(2,1,0,'ПМ131-1',1),(3,1,3,'ПМ141-1',1),(4,1,0,'ПМ151-1',1),(5,1,0,'ПМ161-1',1);
/*!40000 ALTER TABLE `groups` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `load_politic`
--

DROP TABLE IF EXISTS `load_politic`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `load_politic` (
  `id_load_politic` int(11) NOT NULL AUTO_INCREMENT,
  `id_account_worker` int(11) NOT NULL,
  `id_discipline` int(11) NOT NULL,
  PRIMARY KEY (`id_load_politic`),
  KEY `Fk_discipline_idx` (`id_discipline`),
  KEY `Fk_account_idx` (`id_account_worker`),
  CONSTRAINT `Fk_account` FOREIGN KEY (`id_account_worker`) REFERENCES `accounts` (`id_account`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Fk_discipline` FOREIGN KEY (`id_discipline`) REFERENCES `discipline` (`id_discipline`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `load_politic`
--

LOCK TABLES `load_politic` WRITE;
/*!40000 ALTER TABLE `load_politic` DISABLE KEYS */;
/*!40000 ALTER TABLE `load_politic` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `log_all_view`
--

DROP TABLE IF EXISTS `log_all_view`;
/*!50001 DROP VIEW IF EXISTS `log_all_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `log_all_view` AS SELECT 
 1 AS `id_g`,
 1 AS `id_d`,
 1 AS `name_g`,
 1 AS `name_d`,
 1 AS `id_t`*/;
SET character_set_client = @saved_cs_client;

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
) ENGINE=InnoDB AUTO_INCREMENT=47 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log_values`
--

LOCK TABLES `log_values` WRITE;
/*!40000 ALTER TABLE `log_values` DISABLE KEYS */;
INSERT INTO `log_values` VALUES (1,1,11,1,'2016-04-20','1'),(2,1,11,1,'2016-04-21','2'),(3,1,12,1,'2016-04-21','3'),(4,1,11,1,'2016-04-26','4'),(5,1,11,1,'2016-04-27','5'),(6,1,11,2,'2016-04-21','5'),(7,0,11,1,'2016-04-01','5'),(9,0,11,1,'2016-04-02','5'),(15,0,16,1,'2016-04-00','5'),(16,0,11,1,'2016-04-00','5'),(25,0,23,1,'2016-04-25','У'),(28,0,17,1,'2016-04-19','4'),(29,2,6,5,'2016-04-25','Б'),(30,2,8,5,'2016-11-21','5'),(31,2,7,5,'2016-09-12','Б'),(33,0,7,5,'2015-09-21','2'),(35,0,6,5,'2015-09-28','У'),(36,0,16,1,'2015-09-19','Н'),(37,0,17,1,'2015-09-14','Н'),(38,0,11,1,'2015-09-15','Н'),(39,0,29,1,'2015-09-15','4'),(40,0,16,1,'2015-09-15','Н'),(41,0,17,1,'2015-09-15','Н'),(42,0,23,1,'2015-09-15','Н'),(43,0,27,1,'2015-09-15','Н'),(44,0,29,1,'2015-09-12','5'),(45,2,16,1,'2015-09-12','У'),(46,0,20,1,'2015-09-15','3');
/*!40000 ALTER TABLE `log_values` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `para`
--

DROP TABLE IF EXISTS `para`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `para` (
  `id_para` int(11) NOT NULL AUTO_INCREMENT,
  `para_number` int(11) DEFAULT '1',
  `para_time_start` time DEFAULT NULL,
  `para_time_end` time DEFAULT NULL,
  PRIMARY KEY (`id_para`),
  UNIQUE KEY `para_number_UNIQUE` (`para_number`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `para`
--

LOCK TABLES `para` WRITE;
/*!40000 ALTER TABLE `para` DISABLE KEYS */;
INSERT INTO `para` VALUES (1,1,'09:00:00','09:55:00'),(2,2,'10:00:00','10:55:00'),(3,3,'11:00:00','11:55:00'),(4,4,'12:00:00','12:55:00'),(5,5,'13:00:00','13:55:00'),(6,6,'14:00:00','14:55:00'),(7,7,'15:00:00','15:55:00'),(8,8,'16:00:00','16:55:00'),(9,9,'17:00:00','17:55:00'),(10,10,'18:00:00','18:55:00');
/*!40000 ALTER TABLE `para` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permissions`
--

DROP TABLE IF EXISTS `permissions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `permissions` (
  `id_permission` int(11) NOT NULL AUTO_INCREMENT,
  `permission_name` varchar(50) NOT NULL,
  `is_Admin` bit(1) DEFAULT b'0',
  `getAccountData` bit(1) DEFAULT b'1',
  `getAllLogs` bit(1) DEFAULT b'0',
  `insertStudentIntoGroup` bit(1) DEFAULT b'0',
  `getStudentsIntoGroup` bit(1) DEFAULT b'0',
  PRIMARY KEY (`id_permission`),
  UNIQUE KEY `permission_name_UNIQUE` (`permission_name`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permissions`
--

LOCK TABLES `permissions` WRITE;
/*!40000 ALTER TABLE `permissions` DISABLE KEYS */;
INSERT INTO `permissions` VALUES (1,'Admin','','','','',''),(2,'Teacher','\0','','','\0','\0'),(3,'Students','\0','','\0','\0','\0');
/*!40000 ALTER TABLE `permissions` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `specializations`
--

DROP TABLE IF EXISTS `specializations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `specializations` (
  `id_specialization` int(11) NOT NULL AUTO_INCREMENT,
  `specialization_number` varchar(10) NOT NULL,
  `specialization_name` varchar(120) NOT NULL,
  `specialization_type` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_specialization`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `specializations`
--

LOCK TABLES `specializations` WRITE;
/*!40000 ALTER TABLE `specializations` DISABLE KEYS */;
INSERT INTO `specializations` VALUES (1,'090203','Программирование в компьютерных системах',1),(2,'080109','Финансы',1),(3,'101101','Гостиничный сервис',1),(4,'070602','Дизайн (по отраслям)',1),(5,'040406','Организация сурдокоммуникации',1);
/*!40000 ALTER TABLE `specializations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students_list_in_to_group`
--

DROP TABLE IF EXISTS `students_list_in_to_group`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `students_list_in_to_group` (
  `id_students_list_in_to_group` int(11) NOT NULL AUTO_INCREMENT,
  `id_account` int(11) NOT NULL,
  `id_group` int(11) NOT NULL,
  PRIMARY KEY (`id_students_list_in_to_group`),
  UNIQUE KEY `id_account_UNIQUE` (`id_account`),
  CONSTRAINT `FK_ACC` FOREIGN KEY (`id_account`) REFERENCES `accounts` (`id_account`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students_list_in_to_group`
--

LOCK TABLES `students_list_in_to_group` WRITE;
/*!40000 ALTER TABLE `students_list_in_to_group` DISABLE KEYS */;
INSERT INTO `students_list_in_to_group` VALUES (1,12,1),(2,13,1),(3,20,1),(4,25,1),(5,28,1),(6,31,1),(7,32,1),(8,4,2),(9,5,2),(10,6,2),(11,7,2),(12,8,2),(13,9,2),(14,10,2),(15,11,3),(16,16,3),(17,17,3),(18,23,3),(19,27,3),(20,29,3),(21,14,4),(22,15,4),(23,18,4),(24,19,4),(25,21,4),(26,22,4),(27,24,4),(28,26,5),(29,30,5);
/*!40000 ALTER TABLE `students_list_in_to_group` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'bd_app_log'
--

--
-- Dumping routines for database 'bd_app_log'
--
/*!50003 DROP PROCEDURE IF EXISTS `edit_curriculum_part` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `edit_curriculum_part`(
	in count_l int(11), # Колличество лекций
    in count_w int(11), # Колличество работы на дому
    in count_s int(11), # Колличество самостоятельной работы 
    in check_c bit(1), # Будет ли зачет по предмету в этом семестре
    in check_e bit(1)  # Будет ли экзамен по предмету в этом семестре
)
BEGIN
	UPDATE curriculum_parts 
	SET 
		curr_part_count_lectures = count_l, 
		curr_part_count_workexp = count_w,
		curr_part_count_selfwork = count_s,
		curr_part_cred_term = check_c,
		curr_part_exam_term = check_e
	WHERE 
		id_curriculum = @my_select_curriculum and
		id_discipline = @my_insert_select_discipline;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `exist_discipline_weekday` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `exist_discipline_weekday`(IN var int(11))
BEGIN
	declare count INT default 0;
	if @my_insert_select_discipline > 0 then
		SELECT distinct count(*)
		into count
		FROM schedules 
		where schedules.schedules_index_day_of_week = var and schedules.id_discipline = @my_insert_select_discipline and schedules.id_group = @my_insert_select_group;

		set @exist_discipline_weekday = (count > 0);
	else
		set @exist_discipline_weekday = 0;
    end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_account_data` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_account_data`()
BEGIN
	declare permision varchar(25) default 0;
    
    if @validAccount = true then
		if @myPermision != -1 then
			
            if @myPermision = 1 then
				set permision = "Администратор";
			elseif @myPermision = 2 then
				set permision = "Преподаватель";
            elseif @myPermision = 3 then
				set permision = "Студент";
			else
				set permision = "Неизвестраня ошибка";
			end if;
            
			SELECT 
				permision as `Права доступа:`,
				getacctountdataview.*
			FROM getacctountdataview
			WHERE `id:` = @myAccountId;
		else
			select 0 as 'is_run','Нет доступа' as 'message';
		end if;
	else
		select 0 as 'is_run','Сначала войдите в систему используя, loginAccount(login,password);' as 'message';
	end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_affordable_discipline_by_specialization` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_affordable_discipline_by_specialization`()
BEGIN
	SELECT 
		d.id_discipline as `id`,
		d.discipline_name as `name`
	FROM discipline d
	left join curriculum_parts cp on cp.id_discipline = d.id_discipline
    left join curriculum c on c.id_curriculum = cp.id_curriculum
    where c.id_specialization = (select id_specialization from groups where id_group = @my_select_group) or d.id_discipline = 0
    group by `name`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_curators` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_curators`()
BEGIN
	declare AdminPermision BIT(1) default 0;
	declare permision BIT(1) default 0;
    declare id_index int(11) default -1;
    
    set id_index = @my_select_curator;
    
    set @row_number = 0;
	if @myPermision >-1 then
		select getAllLogs INTO permision FROM permissions 
		where id_permission = @myPermision;
        select is_Admin INTO AdminPermision FROM permissions 
		where id_permission = @myPermision;
		if permision = 1 or AdminPermision = 1 then
			if id_index != -1 then
				SELECT
					`accounts`.`id_account` as `id`,
					concat(`accounts`.`account_last_name`,' ',`accounts`.`account_first_name`,' ',`accounts`.`account_second_name`) as `name`
				FROM `accounts`
                WHERE `accounts`.`id_account` = id_index and `accounts`.`id_permission` < 3
                LIMIT 1;
			else
				SELECT
					(@row_number := @row_number + 1) as `numberx`,
					`accounts`.`id_account` as `id`,
					concat(`accounts`.`account_last_name`,' ',`accounts`.`account_first_name`,' ',`accounts`.`account_second_name`) as `name`
				FROM `accounts`
				WHERE `accounts`.`id_permission` = 2;
            end if;
		else
			select 0 as 'is_run','Нет доступа' as 'message';
		end if;
    else
		select 0 as 'is_run','Сначала войдите в систему используя, loginAccount(login,password);' as 'message';
	end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_curiculumbs` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_curiculumbs`()
BEGIN
	declare AdminPermision BIT(1) default 0;
	declare permision BIT(1) default 0;
    declare id_index int(11) default -1;
     
    set id_index = @my_select_curriculum;
    
    set @row_number = 0;
	if @myPermision >-1 then
		select getAllLogs INTO permision FROM permissions 
		where id_permission = @myPermision;
        select is_Admin INTO AdminPermision FROM permissions 
		where id_permission = @myPermision;
		if permision = 1 or AdminPermision = 1 then
			if id_index != -1 then
            
            
            
				SELECT 
					c.id_curriculum AS `id_curr`,
                    d.id_discipline AS `id_disp`,
					#c.id_specialization AS `id_spec`,
					#c.curriculum_term AS `term`,
					d.discipline_name as `discipline`,
					cp.curr_part_count_lectures as `l`,
                    cp.curr_part_count_workexp as `w`,
                    cp.curr_part_count_selfwork as `s`,
                    cp.curr_part_cred_term as `c`,
                    cp.curr_part_exam_term as `e`
				FROM
					curriculum c
						INNER JOIN
					curriculum_parts cp ON c.id_curriculum = cp.id_curriculum
					inner join
						discipline d on d.id_discipline = cp.id_discipline
				where
					c.id_curriculum = id_index and d.id_discipline > 0;
                
                
                
			else
				SELECT
					(@row_number := @row_number + 1) as `numberx`,
					c.id_curriculum AS `id_curr`,
					c.id_specialization AS `id_spec`,
					c.curriculum_term AS `term`,
					(SELECT 
							IFNULL(SUM(curr_part_exam_term),0)
						FROM
							curriculum_parts
						WHERE
							c.id_curriculum = curriculum_parts.id_curriculum) AS `exams`,
					(SELECT 
							IFNULL(SUM(curr_part_cred_term),0)
						FROM
							curriculum_parts
						WHERE
							c.id_curriculum = curriculum_parts.id_curriculum) AS `credit`
				FROM
					curriculum c
						left JOIN
					curriculum_parts cp ON c.id_curriculum = cp.id_curriculum
				WHERE
					c.id_specialization = @my_select_specialization
				GROUP BY c.curriculum_term;
            end if;
		else
			select 0 as 'is_run','Нет доступа' as 'message';
		end if;
    else
		select 0 as 'is_run','Сначала войдите в систему используя, loginAccount(login,password);' as 'message';
	end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_disciplines` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_disciplines`()
BEGIN
	declare AdminPermision BIT(1) default 0;
	declare permision BIT(1) default 0;
    set @row_number = 0;
	if @myPermision >-1 then
		select getAllLogs INTO permision FROM permissions 
		where id_permission = @myPermision;
        select is_Admin INTO AdminPermision FROM permissions 
		where id_permission = @myPermision;
		if permision = 1 or AdminPermision = 1 then
			if @my_insert_select_discipline != -1 then
				SELECT
					d.id_discipline as 'id',
                    d.discipline_code as 'code',
					d.discipline_name as 'name'
				FROM discipline d
                WHERE d.id_discipline = @my_insert_select_discipline
                LIMIT 1;
			else
				if @my_select_curriculum != -1 then
					SELECT 
						d.id_discipline AS `id`,
						d.discipline_code AS `code`,
						d.discipline_name AS `name`,
						if(cp.id_curriculum <> @my_select_curriculum or isnull(cp.id_curriculum),0,1) AS `check`
					FROM
						discipline d
							LEFT JOIN
						curriculum_parts cp ON d.id_discipline = cp.id_discipline
					WHERE 
						d.id_discipline > 0
					group by d.discipline_name;
				else
					SELECT
						(@row_number := @row_number + 1) as 'numberx',
						d.id_discipline as 'id',
						d.discipline_name as 'name'
					FROM discipline d;
				end if;
            end if;
		else
			select 0 as 'is_run','Нет доступа' as 'message';
		end if;
    else
		select 0 as 'is_run','Сначала войдите в систему используя, loginAccount(login,password);' as 'message';
	end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_groups` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_groups`()
BEGIN
	declare AdminPermision BIT(1) default 0;
	declare permision BIT(1) default 0;
    set @row_number = 0;
	if @myPermision >-1 then
		select getAllLogs INTO permision FROM permissions 
		where id_permission = @myPermision;
        select is_Admin INTO AdminPermision FROM permissions 
		where id_permission = @myPermision;
		if permision = 1 or AdminPermision = 1 then
			if @my_insert_select_group != -1 then
				SELECT
					`groups`.`id_group` as `id`,
                    `groups`.`id_specialization` as `spec`,
                    `groups`.`id_account_curator` as `curator`,
					`groups`.`group_name` as `name`
				FROM `groups`
                WHERE `groups`.`id_group` = @my_insert_select_group
                LIMIT 1;
			else
				SELECT
					(@row_number := @row_number + 1) as `numberx`,
					`groups`.`id_group` as `id`,
                    `specializations`.`specialization_name` as `spec`,
					`groups`.`group_name` as `name`
				FROM `groups`
                INNER JOIN `specializations` on `groups`.`id_specialization` = `specializations`.`id_specialization`;
            end if;
		else
			select 0 as 'is_run','Нет доступа' as 'message';
		end if;
    else
		select 0 as 'is_run','Сначала войдите в систему используя, loginAccount(login,password);' as 'message';
	end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_load_politic` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_load_politic`()
BEGIN
	SELECT  lp.id_account_worker as 'id',
			lp.is_default as 'is_default',
			Concat(account_first_name,' ', account_second_name) as 'name'
	FROM load_politic lp
    INNER JOIN accounts a ON a.id_account = lp.id_account_worker
    WHERE lp.id_discipline = @my_insert_select_discipline;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_logs` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_logs`()
BEGIN
	declare v_max int unsigned default 1000;
	declare v_counter int unsigned default 1;
    declare AdminPermision BIT(1) default 0;
    
    select is_Admin INTO AdminPermision FROM permissions 
	where id_permission = @myPermision;
        
    if @my_insert_select_group != -1 and @my_insert_select_discipline != -1 then
		#если группа и дисциплина выделенны
		call max_day(concat(@my_log_year,'-',@my_log_month,'-01'));
		set @sqlprep = '
			SELECT 
				(@num_row := @num_row +(if(a.id_account != @curType, 1 AND @curType := a.id_account,0))) AS `numberx`,
				a.id_account, 
				concat(a.account_last_name," ",a.account_first_name," ",a.account_second_name) as `full_name`';
		set v_max = @max_day;
		while v_counter <= v_max do
			call exist_discipline_weekday(weekday(concat(@my_log_year,'-',@my_log_month,'-',v_counter))+1);
			if @exist_discipline_weekday > 0 then
				set @sqlprep = concat(@sqlprep,',
				(SELECT log_value 
                FROM log_values 
                WHERE log_value_date = "',concat(@my_log_year,'-',@my_log_month,'-',v_counter),'" and 
                log_values.id_account_sudent = l.id_account_sudent and 
                log_values.id_discipline = @my_insert_select_discipline) AS `',v_counter,'`');
			end if;
			set v_counter=v_counter+1;
		  end while;
		#set @new_p = v_maxs;

		set @sqlprep = concat(@sqlprep,' 
			FROM students_list_in_to_group s 
			LEFT JOIN accounts a on a.id_account = s.id_account 
			LEFT JOIN log_values l  on a.id_account = l.id_account_sudent 
			,(SELECT @curType := "") r
            WHERE s.id_group = @my_insert_select_group
			GROUP BY (a.id_account);
		');
        
        set @num_row = 0;
		PREPARE getCountrySql FROM @sqlprep;
		EXECUTE getCountrySql;
		DEALLOCATE PREPARE getCountrySql;
	elseif @my_insert_select_group = -1 and @my_insert_select_discipline = -1 then
		#если группа и дисциплина не выделенны
		if @myPermision = 1 then
			set @numberx = 0;
			SELECT 
				@numberx:=@numberx +1 as 'numberx',
				log_all_view.*
			FROM log_all_view;
		elseif @myPermision = 2 then
			set @numberx = 0;
			SELECT 
				@numberx:=@numberx +1 as 'numberx',
				log_all_view.*
			FROM log_all_view
            where id_t = @myAccountId;
        else
			set @numberx = 0;
			SELECT "У вас нет прав!" as `Ошибка`;
		end if;

	end if;
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_logs_all` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_logs_all`()
BEGIN
	declare permision BIT(1) default 0;
	if @myPermision >-1 then
		select getAllLogs INTO permision FROM permissions 
		where id_permission = @myPermision;
		
		if permision = 1 then
			SELECT
				g.group_name as 'Группа',
				d.discipline_name as 'Дисциплина'
			FROM load_politic l
            INNER JOIN groups g on l.id_group = g.id_group
            INNER JOIN discipline d on d.id_discipline = l.id_discipline
			WHERE l.id_account_worker = @myAccountId;
		else
			select 0 as 'is_run','Нет доступа' as 'message';
		end if;
    else
		select 0 as 'is_run','Сначала войдите в систему используя, loginAccount(login,password);' as 'message';
	end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_logs_avg` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_logs_avg`()
BEGIN
	set @num_row = 0;  
    if @mySelectedStudents != -1 then
		#если студент выделен
		SELECT 
			(@num_row := @num_row +(if(id_account_sudent != @curStud and discipline.id_discipline != @curDisp, 1 AND @curStud := id_account_sudent AND @curDisp := discipline.id_discipline,0))) AS `numberx`,
			log_values.id_account_sudent as `id_s`,
			discipline.discipline_name `discipline`,
			ROUND(AVG(IF(log_values.log_value = 'Б',
						0,
						IF(log_values.log_value = 'Н',
							0,
							IF(log_values.log_value = 'У',
								0,
								log_values.log_value)))),
					2) AS `avg`
		FROM
			log_values
				INNER JOIN
			discipline ON discipline.id_discipline = log_values.id_discipline
            ,(SELECT @curStud := "",@curDisp := "") r
		WHERE log_values.id_account_sudent = @mySelectedStudents
		GROUP BY log_values.id_account_sudent , log_values.id_discipline;
	end if;
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_schedules` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_schedules`()
BEGIN
	if @my_insert_select_weekday = -1 then
	SELECT  
			d.id_discipline as 'id',
			d.discipline_name as 'discipline',
			s.id_para as 'para',
			s.schedules_index_day_of_week as 'day',
            s.id_account_teacher as 'teacher'
	FROM schedules s
    INNER JOIN discipline d ON d.id_discipline = s.id_discipline
    WHERE s.id_group = @mySelectedGroup ;
    else
    	SELECT  
			d.id_discipline as 'id_disp',
			d.discipline_name as 'discipline',
			s.id_para as 'para',
			s.schedules_index_day_of_week as 'day',
            s.id_account_teacher as 'teacher'
		FROM schedules s
		INNER JOIN discipline d ON d.id_discipline = s.id_discipline
		WHERE s.id_group = @mySelectedGroup and s.schedules_index_day_of_week = @my_insert_select_weekday;
    end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_specializations` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_specializations`()
BEGIN
	declare AdminPermision BIT(1) default 0;
	declare permision BIT(1) default 0;
    declare id_index int(11) default -1;
    
    set id_index = @my_select_specialization;
    
    set @row_number = 0;
	if @myPermision >-1 then
		select getAllLogs INTO permision FROM permissions 
		where id_permission = @myPermision;
        select is_Admin INTO AdminPermision FROM permissions 
		where id_permission = @myPermision;
		if permision = 1 or AdminPermision = 1 then
			if id_index != -1 then
				SELECT
					`specializations`.`id_specialization` as `id`,
                    `specializations`.`specialization_number` as `code`,
					`specializations`.`specialization_name` as `name`
				FROM `specializations`
                WHERE `specializations`.`id_specialization` = id_index
                LIMIT 1;
			else
				SELECT
					(@row_number := @row_number + 1) as `numberx`,
					`specializations`.`id_specialization` as `id`,
                    `specializations`.`specialization_number` as `code`,
					`specializations`.`specialization_name` as `name`
				FROM `specializations`;
            end if;
		else
			select 0 as 'is_run','Нет доступа' as 'message';
		end if;
    else
		select 0 as 'is_run','Сначала войдите в систему используя, loginAccount(login,password);' as 'message';
	end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_students` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_students`(in filter varchar(20))
BEGIN
	declare AdminPermision BIT(1) default 0;
	declare permision BIT(1) default 0;
    declare id_index int(11) default -1;
    
    set id_index = @my_select_group;
    
    set @row_number = 0;
	if @myPermision >-1 then
		select getAllLogs INTO permision FROM permissions 
		where id_permission = @myPermision;
        select is_Admin INTO AdminPermision FROM permissions 
		where id_permission = @myPermision;
		if permision = 1 or AdminPermision = 1 then
			if id_index != -1 then
				if filter = 'show_no_group' then
					SELECT 
						(@row_number := @row_number + 1) as `numberx`, 
						`g`.`id_group` AS `id_group`,
						`a`.`id_account` AS `id_account`,
						`g`.`group_name` AS `group_name`,
						CONCAT(`a`.`account_second_name`,
								' ',
								`a`.`account_first_name`,
								' ',
								`a`.`account_last_name`) AS `name`
					FROM
						((`accounts` `a`
						LEFT JOIN `students_list_in_to_group` `s` ON ((`s`.`id_account` = `a`.`id_account`)))
						LEFT JOIN `groups` `g` ON ((`s`.`id_group` = `g`.`id_group`)))
					WHERE (`g`.`id_group` = id_index or `g`.`id_group` is null) and `a`.`id_permission` > 2;
				else
					SELECT 
						(@row_number := @row_number + 1) as `numberx`, 
						`g`.`id_group` AS `id_group`,
						`a`.`id_account` AS `id_account`,
						`g`.`group_name` AS `group_name`,
						CONCAT(`a`.`account_second_name`,
								' ',
								`a`.`account_first_name`,
								' ',
								`a`.`account_last_name`) AS `name`
					FROM
						((`accounts` `a`
						LEFT JOIN `students_list_in_to_group` `s` ON ((`s`.`id_account` = `a`.`id_account`)))
						LEFT JOIN `groups` `g` ON ((`s`.`id_group` = `g`.`id_group`)))
					WHERE `g`.`id_group` = id_index and `a`.`id_permission` > 2;
                end if;
			else
				SELECT 
						(@row_number := @row_number + 1) as `numberx`, 
						`g`.`id_group` AS `id_group`,
						`a`.`id_account` AS `id_account`,
						`g`.`group_name` AS `group_name`,
						CONCAT(`a`.`account_second_name`,
								' ',
								`a`.`account_first_name`,
								' ',
								`a`.`account_last_name`) AS `name`
					FROM
						((`accounts` `a`
						LEFT JOIN `students_list_in_to_group` `s` ON ((`s`.`id_account` = `a`.`id_account`)))
						LEFT JOIN `groups` `g` ON ((`s`.`id_group` = `g`.`id_group`)))
				WHERE `a`.`id_permission` > 2;
            end if;
		else
			select 0 as 'is_run','Нет доступа' as 'message';
		end if;
    else
		select 0 as 'is_run','Сначала войдите в систему используя, loginAccount(login,password);' as 'message';
	end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_students_into_group` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_students_into_group`()
BEGIN
	declare permision BIT(1) default 0;
	if @myPermision >-1 then
		select getAccountData INTO permision FROM permissions 
		where id_permission = @myPermision;
		
		if permision = 1 then
		SELECT *
			FROM getstudentsintogroupview
			WHERE id = @mySelectedGroup;
		else
			select 0 as 'is_run','Нет доступа' as 'message';
		end if;
    else
		select 0 as 'is_run','Сначала войдите в систему используя, loginAccount(login,password);' as 'message';
	end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_teachers` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_teachers`()
BEGIN
	SELECT 
		id_account as 'id',
		Concat(account_first_name,' ', account_second_name) as 'name'
	FROM accounts
    where id_permission = 2
    order by `name`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_curriculumb_part` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_curriculumb_part`(in checked int(11))
BEGIN
	declare countRows INT default 0;
	declare permision BIT(1) default 0;
    
	if @myPermision >-1 then
		select insertStudentIntoGroup INTO permision FROM permissions 
		where id_permission = @myPermision;
		
		if permision = 1 then
        
			SELECT COUNT(*)
			INTO countRows
			FROM curriculum_parts
			WHERE 
				id_curriculum = @my_select_curriculum and
                id_discipline = @my_insert_select_discipline
			limit 1;
                
			if countRows = 0 and checked = 1 then
				#если не нашел
				INSERT INTO curriculum_parts 
				VALUES 
				(
					null, 
					@my_select_curriculum, 
					@my_insert_select_discipline,
					DEFAULT,
					DEFAULT,
					DEFAULT,
					DEFAULT,
					DEFAULT
				);
				SELECT 1 AS 'is_run','Дисциплина успешно добалена!' AS 'message';
			elseif countRows = 1 AND checked = 0 then
				DELETE FROM curriculum_parts 
				WHERE 
					id_curriculum = @my_select_curriculum and
					id_discipline = @my_insert_select_discipline;
				select 1 as 'is_run','Дисциплина успешно удалена!' as 'message';
            else
				select 1 as 'is_run','В добавлении или удалении нет необходимости' as 'message';
            end if;
            
		else
			select 0 as 'is_run','Нет доступа' as 'message';
		end if;
    else
		select 0 as 'is_run','Сначала войдите в систему используя, loginAccount(login,password);' as 'message';
	end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_discipline` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_discipline`(IN _code varchar(30), IN _name varchar(256))
BEGIN
    
    declare countRows INT default 0;
    
	SELECT 
		COUNT(*) into countRows
    FROM discipline
    WHERE 
		discipline.discipline_code = _code
	Limit 1;
		
	if (countRows = 0 and @my_insert_select_discipline = -1) then
		#если не нашел то insrert
		INSERT INTO discipline
        VALUES (
			null, 
			_code, 
			_name
		);
        select 1 as 'is_run','Значение успешно добавлено!' as 'message';
        
	elseif @my_insert_select_discipline > 0 then
		UPDATE discipline 
		SET 
            discipline_code = _code,
            discipline_name = _name
		WHERE 
			id_discipline = @my_insert_select_discipline;
		select 1 as 'is_run','Значение успешно обновленно!' as 'message';
	else
		select 0 as 'is_run','Выберите дисциплину перед изменением!' as 'message';
    end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_group` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_group`(in name_group varchar(45),in spec int(11), in curator int(11))
BEGIN
	declare countRows INT default 0;
    
	SELECT 
		COUNT(*) into countRows
    FROM groups
    WHERE 
		groups.group_name = name_group
	Limit 1;
		
	if (countRows = 0 and @mySelectedGroup = -1) then
		#если не нашел то insrert
		INSERT INTO groups
        VALUES (
			null, 
			spec, 
			curator, 
			name_group,
			1
		);
        
        set @weekday = 1;
        set @para = 1;
        WHILE @weekday <7 DO 
			WHILE @para <8 DO 
				INSERT INTO schedules
					VALUES (
						null, 
						(select id_group from groups where group_name = name_group limit 1), 
						0, 
						@para,
						-1,
						@weekday
					);
				set @para = @para+1;
            END WHILE;
            set @para = 1;
            set @weekday = @weekday+1;
        END WHILE;
        
        select 1 as 'is_run','Значение успешно добавлено!' as 'message';
        
	elseif @mySelectedGroup > 0 then
		UPDATE groups 
		SET 
			id_specialization = spec, 
			id_account_curator = curator,
            group_name = name_group,
            group_date_start_learn = 1
		WHERE 
			id_group = @mySelectedGroup;
		select 1 as 'is_run','Значение успешно обновленно!' as 'message';
	else
		select 0 as 'is_run','Выберите группу перед изменением!' as 'message';
    end if;
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_log_value` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_log_value`(in dates int(11),in val varchar(5))
BEGIN
    if val = 'C' then
		DELETE FROM log_values
        WHERE id_account_sudent = @mySelectedStudents AND
            id_discipline = @my_insert_select_discipline AND
            log_value_date = concat(@my_log_year,'-',@my_log_month,'-',dates);
            
		select 1 as 'is_run','Значение успешно удалено!' as 'message',@mySelectedStudents, @my_insert_select_discipline,concat(@my_log_year,'-',@my_log_month,'-',dates);
	else
		DELETE FROM log_values
		WHERE id_account_sudent = @mySelectedStudents AND
			  id_discipline = @my_insert_select_discipline AND
			  log_value_date = concat(@my_log_year,'-',@my_log_month,'-',dates);
				
		INSERT INTO `bd_app_log`.`log_values`
			(`id_log_value`,
			`id_account_worker`,
			`id_account_sudent`,
			`id_discipline`,
			`log_value_date`,
			`log_value`)
		VALUES
			(default,
			@myAccountId,
			@mySelectedStudents,
			@my_insert_select_discipline,
			concat(@my_log_year,'-',@my_log_month,'-',dates),
			val);
		select 1 as 'is_run','Значение успешно добавлено!' as 'message';
	end if;
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_schedules` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_schedules`()
BEGIN
	declare countRows INT default 0;
	select COUNT(*) into countRows
    FROM schedules
    WHERE 
    id_group = @mySelectedGroup AND
    id_para = @my_insert_select_para AND 
    schedules_index_day_of_week = @my_insert_select_weekday;
		
	if countRows = 0 then
		#если не нашел insrert
		INSERT INTO schedules
        VALUES (
			null, 
			@mySelectedGroup, 
			@my_insert_select_discipline, 
			@my_insert_select_para,
			@my_insert_select_teacher,
			@my_insert_select_weekday
		);
        select 1 as 'is_run','Значение успешно добавлено!' as 'message';
	else
		#если нашел то update
        if @my_insert_select_teacher != -1 then
			UPDATE schedules 
			SET 
				id_discipline = @my_insert_select_discipline, 
				id_account_teacher = @my_insert_select_teacher
			WHERE 
				id_group = @mySelectedGroup AND
				id_para = @my_insert_select_para AND 
				schedules_index_day_of_week = @my_insert_select_weekday;
		elseif @my_insert_select_teacher = -1 then
			UPDATE schedules 
			SET 
				id_discipline = @my_insert_select_discipline
			WHERE 
				id_group = @mySelectedGroup AND
				id_para = @my_insert_select_para AND 
				schedules_index_day_of_week = @my_insert_select_weekday;
        end if;
		select 0 as 'is_run','Значение успешно обновленно!' as 'message';
	end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_specialization` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_specialization`(IN _code varchar(30), IN _name varchar(256))
BEGIN
    declare countRows INT default 0;
    
	SELECT 
		COUNT(*) into countRows
    FROM specializations
    WHERE 
		specializations.specialization_number = _code
	Limit 1;
		
	if (countRows = 0 and @my_select_specialization = -1) then
		#если не нашел то insrert
		INSERT INTO specializations
        VALUES (
			null, 
			_code, 
			_name,
            null
		);
        select 1 as 'is_run','Значение успешно добавлено!' as 'message';
        
	elseif @my_select_specialization > 0 then
		UPDATE specializations 
		SET 
            specialization_number = _code,
            specialization_name = _name
		WHERE 
			id_specialization = @my_select_specialization;
		select 1 as 'is_run','Значение успешно обновленно!' as 'message';
	else
		select 0 as 'is_run','Выберите дисциплину перед изменением!' as 'message';
    end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_student_into_group` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_student_into_group`(in id_acc int(11),in id_act int(11))
BEGIN
	declare countRows INT default 0;
    declare group_id INT default 0;
	declare permision BIT(1) default 0;
    
	if @myPermision >-1 then
    
		select insertStudentIntoGroup INTO permision FROM permissions 
		where id_permission = @myPermision;
		
		if permision = 1 then
			SELECT COUNT(*),id_group
			INTO countRows,group_id
			FROM students_list_in_to_group
			WHERE id_account = id_acc;
            
			if countRows = 0 then
				if id_act != 0 then
					INSERT INTO students_list_in_to_group VALUES (null, id_acc, @mySelectedGroup);
					select 1 as 'is_run','Студент успешно добавлен' as 'message';
				end if;
			elseif countRows = 1 AND group_id = @mySelectedGroup then
				if id_act = 0 then
					DELETE FROM students_list_in_to_group WHERE id_account=id_acc;
				else
					select 0 as 'is_run','Студент уже присутствует в этой группе!' as 'message';
				end if;
            else
				select 0 as 'is_run','Студент уже присутствует в другой группе!' as 'message';
            end if;
		else
			select 0 as 'is_run','Нет доступа' as 'message';
		end if;
    else
		select 0 as 'is_run','Сначала войдите в систему используя, loginAccount(login,password);' as 'message';
	end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_term_curriculumb` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_term_curriculumb`()
BEGIN
	declare countRows INT default 0;
    
	SELECT 
		COUNT(*)
	INTO countRows FROM
		curriculum
	WHERE
		id_specialization = @my_select_specialization;
    
	INSERT 
		INTO 
			curriculum
	VALUES (
		null, 
		@my_select_specialization, 
		countRows+1
	);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `max_day` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `max_day`(IN var date)
BEGIN
	declare count INT default 0;
	SELECT DATE_FORMAT(DATE_SUB(DATE_ADD(DATE_FORMAT(var,'%Y-%m-01'),interval 1 MONTH),interval 1 DAY),'%d') into count;
	set @max_day = count;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `new_procedure` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `new_procedure`()
BEGIN
	
	declare v_max int unsigned default 1000;
	declare v_counter int unsigned default 1;
    
    call max_day(now());
    
	set @sqlprep = 'SELECT l.id_account_sudent, concat(a.account_last_name," ",a.account_first_name," ",a.account_second_name) as `full_name`';
    set v_max = @max_day;
	while v_counter <= v_max do
		call exist_discipline_weekday(weekday(concat('2016-04-',v_counter))+1);
		if @exist_discipline_weekday > 0 then
			set @sqlprep = concat(@sqlprep,',(SELECT log_value FROM log_values WHERE log_value_date = \'2016-04-',v_counter,'\' and log_values.id_account_sudent = l.id_account_sudent) AS `',v_counter,'`');
        end if;
		set v_counter=v_counter+1;
	  end while;
	#set @new_p = v_maxs;

    set @sqlprep = concat(@sqlprep,' FROM log_values l inner join accounts a on a.id_account = l.id_account_sudent where l.id_discipline = @my_insert_select_discipline  group by (l.id_account_sudent);');
	   PREPARE getCountrySql FROM @sqlprep;
	   EXECUTE getCountrySql;
	   DEALLOCATE PREPARE getCountrySql;
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `set_account` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `set_account`(IN user_login varchar(30), IN user_password varchar(30))
BEGIN
	#Зайти в аккаунт (Логин и пароль)
	declare countRows INT default 0;
    declare account_id INT default -1;
    declare permision_id int default -1;
    declare message_error varchar(65) default 'Ошибок нет!';
    
    #Ищем аккаунт
	SELECT COUNT(a.id_account), a.id_account, a.id_permission 
    INTO countRows, account_id, permision_id 
    FROM accounts a 
    WHERE a.account_login = user_login AND a.account_password = user_password;
    
    if countRows = 1 then
		#Если найден один аккаунт
        set @myPermision = permision_id;
		set @validAccount = true;
		set @myAccountId = account_id;
        set message_error = 'Ошибок нет!';
	elseif countRows > 1 then
		#Если найдено больше одиного аккаунта
        set @myPermision = -1;
		set @validAccount = false;
        set @myAccountId = -1;
        set message_error = 'Неизвестная ошибка!';
	else
		#Если аккаунт не найден
        set @myPermision = -1;
		set @validAccount = false;
        set @myAccountId = -1;
        set message_error = 'Пользователя с таким логином или паролем, не найденно!';
    end if;
    
    
    SELECT (@validAccount) AS validator, 
			(message_error) AS message;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `set_curator` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `set_curator`(IN id INT(11))
BEGIN
	set @my_select_curator = id;
    select 1 as 'is_run', CONCAT('Выделенн куратор:',id) as 'message';
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `set_curriculumb` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `set_curriculumb`(IN id INT(11))
BEGIN
	set @my_select_curriculum = id;
    select 1 as 'is_run', CONCAT('Выделенн учебный план:',id) as 'message';
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `set_discipline` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `set_discipline`(IN id INT(11))
BEGIN
	set @my_insert_select_discipline = id;
    select 1 as 'is_run', CONCAT('Выделенна дисциплина:',@my_insert_select_discipline) as 'message';
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `set_group` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `set_group`(IN id INT(11))
BEGIN
	set @mySelectedGroup = id;
    set @my_insert_select_group = id;
    set @my_select_group = id;
    select 1 as 'is_run', CONCAT('Выделенна группа:',id) as 'message';
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `set_log_month` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `set_log_month`(IN id INT(11))
BEGIN
	set @my_log_month = id;
    select 1 as 'is_run', CONCAT('Выделен Месяц:',id) as 'message';
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `set_log_year` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `set_log_year`(IN id INT(11))
BEGIN
	set @my_log_year = id;
    select 1 as 'is_run', CONCAT('Выделен год:',id) as 'message';
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `set_para` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `set_para`(IN id INT(11))
BEGIN
	set @my_insert_select_para = id;
    select 1 as 'is_run', CONCAT('Выделенна группа:',@my_insert_select_para) as 'message';
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `set_specialization` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `set_specialization`(IN id INT(11))
BEGIN
    set @my_select_specialization = id;
    select 1 as 'is_run', CONCAT('Выделенна специальность:',id) as 'message';
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `set_student` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `set_student`(IN id INT(11))
BEGIN
	set @mySelectedStudents = id;
    select 1 as 'is_run',CONCAT('Выделен студент:',@mySelectedStudents) as 'message';
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `set_teacher` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `set_teacher`(IN id INT(11))
BEGIN
	set @my_insert_select_teacher = id;
    select 1 as 'is_run', CONCAT('Выделен преподаватель:',@my_insert_select_teacher) as 'message';
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `set_weekday` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `set_weekday`(IN id INT(11))
BEGIN
	if id = -2 then
		set @my_insert_select_weekday = weekday(now())+1;
	else
		set @my_insert_select_weekday = id;
	end if;
    select 1 as 'is_run', CONCAT('Выделенна группа:',@my_insert_select_weekday) as 'message';
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `getacctountdataview`
--

/*!50001 DROP VIEW IF EXISTS `getacctountdataview`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `getacctountdataview` AS select `a`.`id_account` AS `id:`,`a`.`account_first_name` AS `Имя:`,`a`.`account_last_name` AS `Фамилия:`,`a`.`account_second_name` AS `Отчество:`,`a`.`account_legal_adress` AS `Домашний адресс:`,`a`.`account_telphone` AS `Телефон:`,`a`.`account_gender` AS `Пол:`,date_format(`a`.`account_bithdate`,'%d-%m-%Y') AS `Дата рождения:`,`a`.`account_image` AS `account_image` from `accounts` `a` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `log_all_view`
--

/*!50001 DROP VIEW IF EXISTS `log_all_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `log_all_view` AS select `g`.`id_group` AS `id_g`,`d`.`id_discipline` AS `id_d`,`g`.`group_name` AS `name_g`,`d`.`discipline_name` AS `name_d`,`s`.`id_account_teacher` AS `id_t` from ((`schedules` `s` join `discipline` `d` on((`d`.`id_discipline` = `s`.`id_discipline`))) join `groups` `g` on((`g`.`id_group` = `s`.`id_group`))) where (`d`.`id_discipline` > 0) group by `id_g`,`id_d` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-06-17  8:46:11
