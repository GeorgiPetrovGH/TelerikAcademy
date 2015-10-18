-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema universities
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema universities
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `universities` DEFAULT CHARACTER SET utf8 ;
USE `universities` ;

-- -----------------------------------------------------
-- Table `universities`.`universities`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`universities` (
  `university_id` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `name` VARCHAR(50) NOT NULL COMMENT '',
  PRIMARY KEY (`university_id`)  COMMENT '')
ENGINE = MyISAM
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `universities`.`faculties`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`faculties` (
  `faculty_id` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `name` VARCHAR(50) NOT NULL COMMENT '',
  `university_id` INT(11) NOT NULL COMMENT '',
  PRIMARY KEY (`faculty_id`)  COMMENT '',
  INDEX `fk_faculties_universities1_idx` (`university_id` ASC)  COMMENT '')
ENGINE = MyISAM
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `universities`.`departments`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`departments` (
  `department_id` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `name` VARCHAR(50) NOT NULL COMMENT '',
  `faculty_id` INT(11) NOT NULL COMMENT '',
  PRIMARY KEY (`department_id`)  COMMENT '',
  INDEX `fk_departments_faculties1_idx` (`faculty_id` ASC)  COMMENT '')
ENGINE = MyISAM
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `universities`.`professors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`professors` (
  `professor_id` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `name` VARCHAR(50) NOT NULL COMMENT '',
  `department_id` INT(11) NOT NULL COMMENT '',
  PRIMARY KEY (`professor_id`)  COMMENT '',
  INDEX `fk_professors_departments1_idx` (`department_id` ASC)  COMMENT '')
ENGINE = MyISAM
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `universities`.`courses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`courses` (
  `course_id` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `name` VARCHAR(50) NOT NULL COMMENT '',
  `department_id` INT(11) NOT NULL COMMENT '',
  `professor_id` INT(11) NOT NULL COMMENT '',
  PRIMARY KEY (`course_id`)  COMMENT '',
  INDEX `fk_courses_professors1_idx` (`professor_id` ASC)  COMMENT '',
  INDEX `fk_courses_departments1_idx` (`department_id` ASC)  COMMENT '')
ENGINE = MyISAM
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `universities`.`titles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`titles` (
  `title_id` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `name` VARCHAR(50) NOT NULL COMMENT '',
  PRIMARY KEY (`title_id`)  COMMENT '')
ENGINE = MyISAM
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `universities`.`professors_titles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`professors_titles` (
  `professor_id` INT(11) NOT NULL COMMENT '',
  `title_id` INT(11) NOT NULL COMMENT '',
  PRIMARY KEY (`professor_id`, `title_id`)  COMMENT '',
  INDEX `fk_professors_titles_professors1_idx` (`professor_id` ASC)  COMMENT '')
ENGINE = MyISAM
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `universities`.`students`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`students` (
  `student_id` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `name` VARCHAR(50) NOT NULL COMMENT '',
  `faculty_id` INT(11) NOT NULL COMMENT '',
  PRIMARY KEY (`student_id`)  COMMENT '',
  INDEX `fk_students_faculties1_idx` (`faculty_id` ASC)  COMMENT '')
ENGINE = MyISAM
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `universities`.`students_courses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`students_courses` (
  `student_id` INT(11) NULL DEFAULT NULL COMMENT '',
  `course_id` INT(11) NULL DEFAULT NULL COMMENT '',
  INDEX `fk_students_courses_courses1_idx` (`course_id` ASC)  COMMENT '',
  INDEX `fk_students_courses_students1_idx` (`student_id` ASC)  COMMENT '',
  CONSTRAINT `fk_students_courses_courses1`
    FOREIGN KEY (`course_id`)
    REFERENCES `universities`.`courses` (`course_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_students_courses_students1`
    FOREIGN KEY (`student_id`)
    REFERENCES `universities`.`students` (`student_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
