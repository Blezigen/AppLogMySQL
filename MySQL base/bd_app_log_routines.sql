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
		set @num_row = 0;
		set @sqlprep = '
			SELECT 
				(@num_row := @num_row+1) as `numberx`,
				a.id_account, 
				concat(a.account_last_name," ",a.account_first_name," ",a.account_second_name) as `full_name`';
		set v_max = @max_day;
		while v_counter <= v_max do
			call exist_discipline_weekday(weekday(concat(@my_log_year,'-',@my_log_month,'-',v_counter))+1);
			if @exist_discipline_weekday > 0 then
				set @sqlprep = concat(@sqlprep,',
				(SELECT log_value FROM log_values WHERE log_value_date = "',concat(@my_log_year,'-',@my_log_month,'-',v_counter),'" and log_values.id_account_sudent = l.id_account_sudent and log_values.id_discipline = @my_insert_select_discipline) AS `',v_counter,'`');
			end if;
			set v_counter=v_counter+1;
		  end while;
		#set @new_p = v_maxs;

		set @sqlprep = concat(@sqlprep,' 
			FROM students_list_in_to_group s 
			LEFT JOIN accounts a on a.id_account = s.id_account 
			LEFT JOIN log_values l  on a.id_account = l.id_account_sudent 
			WHERE s.id_group = @my_insert_select_group
			GROUP BY (a.id_account);
		');
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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-05-04 13:49:44
