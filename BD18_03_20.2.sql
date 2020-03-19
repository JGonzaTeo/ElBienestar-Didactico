CREATE DATABASE  IF NOT EXISTS `mydb` /*!40100 DEFAULT CHARACTER SET latin1 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `mydb`;
-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: mydb
-- ------------------------------------------------------
-- Server version	8.0.17

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `asistencia`
--

DROP TABLE IF EXISTS `asistencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `asistencia` (
  `pkcodigoasistencia` int(11) NOT NULL,
  `fkcodigoempleado` int(11) NOT NULL,
  `fechaentrada` date DEFAULT NULL,
  `fechasalida` date DEFAULT NULL,
  `horaentrada` datetime DEFAULT NULL,
  `horasalida` datetime DEFAULT NULL,
  PRIMARY KEY (`pkcodigoasistencia`),
  KEY `fk_asistencia_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_asistencia_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asistencia`
--

LOCK TABLES `asistencia` WRITE;
/*!40000 ALTER TABLE `asistencia` DISABLE KEYS */;
/*!40000 ALTER TABLE `asistencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `candidatos_internos`
--

DROP TABLE IF EXISTS `candidatos_internos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `candidatos_internos` (
  `pkcodigocandidato` int(11) NOT NULL,
  `pksolicitudempleado` int(11) NOT NULL,
  `pkcodperfil` int(11) NOT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkcodigocandidato`,`pksolicitudempleado`,`pkcodperfil`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `candidatos_internos`
--

LOCK TABLES `candidatos_internos` WRITE;
/*!40000 ALTER TABLE `candidatos_internos` DISABLE KEYS */;
/*!40000 ALTER TABLE `candidatos_internos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `concepto`
--

DROP TABLE IF EXISTS `concepto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `concepto` (
  `pkcodigoconcepto` int(11) NOT NULL,
  `nombreconcepto` varchar(45) DEFAULT NULL,
  `tipo_concepto` tinyint(2) DEFAULT NULL,
  `saldo` double DEFAULT NULL,
  `tipo_accion` tinyint(2) DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`pkcodigoconcepto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `concepto`
--

LOCK TABLES `concepto` WRITE;
/*!40000 ALTER TABLE `concepto` DISABLE KEYS */;
/*!40000 ALTER TABLE `concepto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamentos`
--

DROP TABLE IF EXISTS `departamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departamentos` (
  `pkcodigodepto` int(11) NOT NULL,
  `nombredepto` varchar(45) DEFAULT NULL,
  `descripciondepto` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkcodigodepto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamentos`
--

LOCK TABLES `departamentos` WRITE;
/*!40000 ALTER TABLE `departamentos` DISABLE KEYS */;
/*!40000 ALTER TABLE `departamentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `despidoempleado`
--

DROP TABLE IF EXISTS `despidoempleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `despidoempleado` (
  `pkcodigodespidoempleado` int(11) NOT NULL,
  `fkcodigoempleado` int(11) NOT NULL,
  `razondespido` varchar(45) DEFAULT NULL,
  `descripciondespido` varchar(45) DEFAULT NULL,
  `fechadespido` date DEFAULT NULL,
  PRIMARY KEY (`pkcodigodespidoempleado`),
  KEY `fk_despidoempleado_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_despidoempleado_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `despidoempleado`
--

LOCK TABLES `despidoempleado` WRITE;
/*!40000 ALTER TABLE `despidoempleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `despidoempleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleado` (
  `pkcodigoempleado` int(11) NOT NULL,
  `fkcodigojornada` int(11) NOT NULL,
  `primernombre` varchar(45) DEFAULT NULL,
  `segundonombre` varchar(45) DEFAULT NULL,
  `primerapellido` varchar(45) DEFAULT NULL,
  `segundoapellido` varchar(45) DEFAULT NULL,
  `telefono` int(11) DEFAULT NULL,
  `celular` int(11) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `fechanacimiento` date DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  `TipoContratacion_pkcodigocontratacion` int(11) DEFAULT NULL,
  `nit` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkcodigoempleado`),
  KEY `fk_empleado_jornada_idx` (`fkcodigojornada`),
  CONSTRAINT `fk_empleado_jornada` FOREIGN KEY (`fkcodigojornada`) REFERENCES `jornada` (`pkcodigojornada`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleadocontable`
--

DROP TABLE IF EXISTS `empleadocontable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleadocontable` (
  `pkcodigolinea` int(11) NOT NULL AUTO_INCREMENT,
  `fkcodigoempleado` int(11) DEFAULT NULL,
  `fkcodigoconcepto` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkcodigolinea`),
  KEY `fk_empleadocontable_empleado1_idx` (`fkcodigoempleado`),
  KEY `fk_empleadocontable_concepto1_idx` (`fkcodigoconcepto`),
  CONSTRAINT `fk_empleadocontable_concepto1` FOREIGN KEY (`fkcodigoconcepto`) REFERENCES `concepto` (`pkcodigoconcepto`),
  CONSTRAINT `fk_empleadocontable_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleadocontable`
--

LOCK TABLES `empleadocontable` WRITE;
/*!40000 ALTER TABLE `empleadocontable` DISABLE KEYS */;
/*!40000 ALTER TABLE `empleadocontable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horasextras`
--

DROP TABLE IF EXISTS `horasextras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `horasextras` (
  `pkcodigohorasextras` int(11) NOT NULL,
  `fkcodigoempleado` int(11) NOT NULL,
  `cantidad` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkcodigohorasextras`),
  KEY `fk_horasextras_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_horasextras_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horasextras`
--

LOCK TABLES `horasextras` WRITE;
/*!40000 ALTER TABLE `horasextras` DISABLE KEYS */;
/*!40000 ALTER TABLE `horasextras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jornada`
--

DROP TABLE IF EXISTS `jornada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `jornada` (
  `pkcodigojornada` int(11) NOT NULL,
  `nombrejornada` varchar(45) DEFAULT NULL,
  `horasjornada` int(11) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkcodigojornada`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jornada`
--

LOCK TABLES `jornada` WRITE;
/*!40000 ALTER TABLE `jornada` DISABLE KEYS */;
/*!40000 ALTER TABLE `jornada` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mediodecomunicacion`
--

DROP TABLE IF EXISTS `mediodecomunicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mediodecomunicacion` (
  `idMediodeComunicacion` int(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  `Telefono` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idMediodeComunicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mediodecomunicacion`
--

LOCK TABLES `mediodecomunicacion` WRITE;
/*!40000 ALTER TABLE `mediodecomunicacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `mediodecomunicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nomina_encabezado`
--

DROP TABLE IF EXISTS `nomina_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nomina_encabezado` (
  `pkcodigonomina` int(11) NOT NULL,
  `tipo_nomina` tinyint(2) DEFAULT NULL,
  `fechainicio` date DEFAULT NULL,
  `fechafin` date DEFAULT NULL,
  `fkcodigoempleado` int(11) DEFAULT NULL,
  `Observaciones` varchar(45) DEFAULT NULL,
  `saldo_total` double DEFAULT '0',
  PRIMARY KEY (`pkcodigonomina`),
  KEY `fk_nomina_encabezado_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_nomina_encabezado_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nomina_encabezado`
--

LOCK TABLES `nomina_encabezado` WRITE;
/*!40000 ALTER TABLE `nomina_encabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `nomina_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nominadetalle`
--

DROP TABLE IF EXISTS `nominadetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nominadetalle` (
  `pkcodigonomina` int(11) NOT NULL,
  `cod_linea` int(11) NOT NULL,
  `subtotal_percepcion` double DEFAULT NULL,
  `subtotal_deduccion` double DEFAULT NULL,
  `nominadetallecol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkcodigonomina`,`cod_linea`),
  CONSTRAINT `fk_nominadetalle_nomina_encabezado1` FOREIGN KEY (`pkcodigonomina`) REFERENCES `nomina_encabezado` (`pkcodigonomina`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nominadetalle`
--

LOCK TABLES `nominadetalle` WRITE;
/*!40000 ALTER TABLE `nominadetalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `nominadetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfil_detalle`
--

DROP TABLE IF EXISTS `perfil_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `perfil_detalle` (
  `fkcodperfil` int(11) NOT NULL,
  `primaria` tinyint(1) DEFAULT NULL,
  `secundaria` tinyint(1) DEFAULT NULL,
  `bachillerato` tinyint(1) DEFAULT NULL,
  `estudiante_U` tinyint(1) DEFAULT NULL,
  `graduado_U` tinyint(1) DEFAULT NULL,
  `curso_extra` tinyint(1) DEFAULT NULL,
  `descripcion_curso` tinyint(1) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`fkcodperfil`),
  CONSTRAINT `fk_perfil_detalle_perfil_encabezado1` FOREIGN KEY (`fkcodperfil`) REFERENCES `perfil_encabezado` (`pkcodperfil`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfil_detalle`
--

LOCK TABLES `perfil_detalle` WRITE;
/*!40000 ALTER TABLE `perfil_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `perfil_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfil_encabezado`
--

DROP TABLE IF EXISTS `perfil_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `perfil_encabezado` (
  `pkcodperfil` int(11) NOT NULL,
  `fkcodigopuesto` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkcodperfil`),
  KEY `fk_perfil_encabezado_puesto1_idx` (`fkcodigopuesto`),
  CONSTRAINT `fk_perfil_encabezado_puesto1` FOREIGN KEY (`fkcodigopuesto`) REFERENCES `puesto` (`pkcodigopuesto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfil_encabezado`
--

LOCK TABLES `perfil_encabezado` WRITE;
/*!40000 ALTER TABLE `perfil_encabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `perfil_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `puesto`
--

DROP TABLE IF EXISTS `puesto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `puesto` (
  `pkcodigopuesto` int(11) NOT NULL,
  `fkcodigoempleado` int(11) NOT NULL,
  `fkcodigodepto` int(11) NOT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `sueldo` double DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkcodigopuesto`),
  KEY `fk_puesto_empleado1_idx` (`fkcodigoempleado`),
  KEY `fk_puesto_departamentos1_idx` (`fkcodigodepto`),
  CONSTRAINT `fk_puesto_departamentos1` FOREIGN KEY (`fkcodigodepto`) REFERENCES `departamentos` (`pkcodigodepto`),
  CONSTRAINT `fk_puesto_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `puesto`
--

LOCK TABLES `puesto` WRITE;
/*!40000 ALTER TABLE `puesto` DISABLE KEYS */;
/*!40000 ALTER TABLE `puesto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reuniones`
--

DROP TABLE IF EXISTS `reuniones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reuniones` (
  `pkcodigoreuniones` int(11) NOT NULL,
  `fkcodigoempleado` int(11) NOT NULL,
  `nombrereunion` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `fechainicio` date DEFAULT NULL,
  `fechafinal` date DEFAULT NULL,
  `horainicio` datetime DEFAULT NULL,
  `horafinal` datetime DEFAULT NULL,
  `cantidadempleados` int(11) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkcodigoreuniones`),
  KEY `fk_reuniones_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_reuniones_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reuniones`
--

LOCK TABLES `reuniones` WRITE;
/*!40000 ALTER TABLE `reuniones` DISABLE KEYS */;
/*!40000 ALTER TABLE `reuniones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sancionempleado`
--

DROP TABLE IF EXISTS `sancionempleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sancionempleado` (
  `pkcodigosansionempleado` int(11) NOT NULL,
  `fkcodigoempleado` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `descipcion` varchar(45) DEFAULT NULL,
  `fechainicio` date DEFAULT NULL,
  `fechafinal` date DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkcodigosansionempleado`),
  KEY `fk_sancionempleado_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_sancionempleado_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sancionempleado`
--

LOCK TABLES `sancionempleado` WRITE;
/*!40000 ALTER TABLE `sancionempleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `sancionempleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_bancotalento`
--

DROP TABLE IF EXISTS `tbl_bancotalento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_bancotalento` (
  `pkBancoTalento` int(11) NOT NULL AUTO_INCREMENT,
  `fkCurriculum` int(11) NOT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkBancoTalento`,`fkCurriculum`),
  KEY `FK_Curriculum_BancoT` (`fkCurriculum`),
  CONSTRAINT `FK_Curriculum_BancoT` FOREIGN KEY (`fkCurriculum`) REFERENCES `tbl_curriculums` (`pkidCurriculum`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bancotalento`
--

LOCK TABLES `tbl_bancotalento` WRITE;
/*!40000 ALTER TABLE `tbl_bancotalento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_bancotalento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_curriculums`
--

DROP TABLE IF EXISTS `tbl_curriculums`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_curriculums` (
  `pkidCurriculum` int(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Apellido` varchar(45) DEFAULT NULL,
  `Numero` varchar(45) DEFAULT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  `Correo_Electronico` varchar(45) DEFAULT NULL,
  `Primaria` tinyint(1) DEFAULT NULL,
  `Secundaria` tinyint(1) DEFAULT NULL,
  `Bachillerato` tinyint(1) DEFAULT NULL,
  `Estudiante_Universitario` tinyint(1) DEFAULT NULL,
  `GraduadoU` tinyint(1) DEFAULT NULL,
  `CursoExtra` tinyint(1) DEFAULT NULL,
  `DescripcionCursos` varchar(100) DEFAULT NULL,
  `Experiencia_Previa` varchar(45) DEFAULT NULL,
  `SueldoEsperado` double DEFAULT NULL,
  `fksolicitudempleado` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkidCurriculum`),
  KEY `FK_solicitud_empleado_encabezado_Curriculums` (`fksolicitudempleado`),
  CONSTRAINT `FK_solicitud_empleado_encabezado_Curriculums` FOREIGN KEY (`fksolicitudempleado`) REFERENCES `tbl_solicitud_empleado_encabezado` (`pksolicitudempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_curriculums`
--

LOCK TABLES `tbl_curriculums` WRITE;
/*!40000 ALTER TABLE `tbl_curriculums` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_curriculums` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_solicitud_empleado_detalle`
--

DROP TABLE IF EXISTS `tbl_solicitud_empleado_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_solicitud_empleado_detalle` (
  `pksolicitudempleado` int(11) NOT NULL,
  `primaria` tinyint(1) DEFAULT NULL,
  `secundaria` tinyint(1) DEFAULT NULL,
  `bachillerato` tinyint(1) DEFAULT NULL,
  `estudiante_U` tinyint(1) DEFAULT NULL,
  `grado_U` tinyint(1) DEFAULT NULL,
  `curso_extra` tinyint(1) DEFAULT NULL,
  `descripcion_curso` tinyint(1) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pksolicitudempleado`),
  CONSTRAINT `fk_tbl_solicitud_empleado_detalle_tbl_solicitud_empleado_enca1` FOREIGN KEY (`pksolicitudempleado`) REFERENCES `tbl_solicitud_empleado_encabezado` (`pksolicitudempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_solicitud_empleado_detalle`
--

LOCK TABLES `tbl_solicitud_empleado_detalle` WRITE;
/*!40000 ALTER TABLE `tbl_solicitud_empleado_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_solicitud_empleado_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_solicitud_empleado_encabezado`
--

DROP TABLE IF EXISTS `tbl_solicitud_empleado_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_solicitud_empleado_encabezado` (
  `pksolicitudempleado` int(11) NOT NULL,
  `fkcodigoempleado` int(11) DEFAULT NULL,
  `fkcodigocontratacion` int(11) DEFAULT NULL,
  `fecha_creacion` date DEFAULT NULL,
  PRIMARY KEY (`pksolicitudempleado`),
  KEY `fk_tbl_solicitud_empleado_encabezado_empleado1_idx` (`fkcodigoempleado`),
  KEY `fk_tbl_solicitud_empleado_encabezado_tipocontratacion1_idx` (`fkcodigocontratacion`),
  CONSTRAINT `fk_tbl_solicitud_empleado_encabezado_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`),
  CONSTRAINT `fk_tbl_solicitud_empleado_encabezado_tipocontratacion1` FOREIGN KEY (`fkcodigocontratacion`) REFERENCES `tipocontratacion` (`pkcodigocontratacion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_solicitud_empleado_encabezado`
--

LOCK TABLES `tbl_solicitud_empleado_encabezado` WRITE;
/*!40000 ALTER TABLE `tbl_solicitud_empleado_encabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_solicitud_empleado_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipocontratacion`
--

DROP TABLE IF EXISTS `tipocontratacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipocontratacion` (
  `pkcodigocontratacion` int(11) NOT NULL,
  `PorContrato` varchar(45) DEFAULT NULL,
  `PorMeses` varchar(45) DEFAULT NULL,
  `PorProyecto` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkcodigocontratacion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipocontratacion`
--

LOCK TABLES `tipocontratacion` WRITE;
/*!40000 ALTER TABLE `tipocontratacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipocontratacion` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-03-18 12:11:25
