#'*********************************************************************************************
#'READ FIRST
#################################################
#THIS SQL SCRIPT WAS WRITTEN AND MAINTAINED
#BY EXISTENCE INNOVATIVE TECHNOLOGIES    
#
#
#'THIS CODE SNIPPET IS FREE TO DISTRIBUTE AND SHARE BUT MUST BE
#'ATTRIBUTED TO THE ORIGINAL DEVELOPERS.
#'
#'███████╗██╗  ██╗███████╗   FOUNDED BY: ROMEO MANUEL E. DAVID
#'██╔════╝╚██╗██╔╝██╔════╝   SPIMSDB SCRIPT Developed, Updated and Maintained by:
#'█████╗   ╚███╔╝ ███████╗       -Romeo Manuel David
#'██╔══╝   ██╔██╗ ╚════██║  
#'███████╗██╔╝ ██╗███████║       
#'╚══════╝╚═╝  ╚═╝╚══════╝
#'___________________________________________________________________________



#CREATE DATABASE

DROP DATABASE IF EXISTS spimsdb;
CREATE DATABASE IF NOT EXISTS spimsdb;
#SWICTH DATABASE
use spimsdb;

#CREATE USERS
#ADMIN USER WITH ALL PRIVILEGES
CREATE USER admin@'%' IDENTIFIED BY '5f4dcc3b5aa765d61d8327deb882cf99';
GRANT ALL PRIVILEGES ON spimsdb.* TO admin@'%';

#NORMAL USER WITH ONLY VIEW INSERT AND UPDATE PRIVILEGES
CREATE USER normal@'%' IDENTIFIED BY 'mY_p@s$w0rD+1s^$tR0n6';
GRANT SELECT, INSERT, UPDATE ON spimsdb.* TO normal@'%';


#USERS TABLE IS USED TO STORE USER/EMPLOYEE INFORMATION
CREATE TABLE USERS(

UID INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
#USER IDENTIFIER
USERNAME VARCHAR(30) NOT NULL,
#USER'S CHARACTER IDENTIFIER ON THE SYSTEM
PASSWD VARCHAR(200) NOT NULL,
#USER'S PASSWORD HASHED USING SHA512
FULL_NAME VARCHAR(50),
#USER'S WHOLE NAME DOESN'T REALLY NEED TO BE FRAGMENTED BECAUSE THEY WERE ONLY 10
JOB VARCHAR(20),
#USER'S ROLE ON THE BUSINESS
RX VARCHAR(10) NOT NULL,
#USER'S RESTRICTION LEVEL ASSIGNED BY THE ADMINISTRATOR
USER_LOCK VARCHAR(20)
#ADMIN CAN EITHER LOCK OR UNLOCK AN ACCOUNT, HENCE THE USER_LOCK FIELD
);

CREATE TABLE PATIENT(
    #ALL HERE ARE PRETTY MUCH SELF EXPLANATORY
    #MOST OF THE DATA TYPES ARE MAXXED OUT BECAUSE 
    #THEY ARE ENCRYPTED AND TAKES UP A REALLY HUGE SPACE ON THE DATABASE
PT_ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
PT_CASE_NO VARCHAR(20),
PT_LN VARCHAR(20),
PT_FN VARCHAR(20),
PT_MN VARCHAR(20),
PT_DOB VARCHAR(255), 
PT_CSTAT VARCHAR(255),
PT_SEX VARCHAR(255),
PT_CONTACT_NO VARCHAR(255),
PT_TYPE VARCHAR(255),

PT_BRGY VARCHAR(255),
PT_CITY VARCHAR(255),
PT_PROV VARCHAR(255),
PT_OCC VARCHAR(255),
PT_ALLERGY VARCHAR(255),
PT_IMPLANT VARCHAR(255),
PT_CLAUSTRO VARCHAR(255),

PT_ENAME VARCHAR(255),
PT_ECONTACT VARCHAR(255),
PT_HMO VARCHAR(255),
PT_LAST_UPDATE VARCHAR(25),

UID_LOCK INT,
#UID_LOCK - AN EXCLUSIVE LOCK ONLY GRANTED TO THE USER WHO IS ACCESSING THE PATIENT DATA
FOREIGN KEY (UID_LOCK) REFERENCES USERS(UID)
);

#AUDIT TRAIL TO TRACK USER ACTIONS, INTEGRATED ON ALL MODULES
CREATE TABLE AUDIT_TRAIL(
ACTION_ID INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
UID INT NOT NULL,
ACTION_TIME VARCHAR(25),
ACTION VARCHAR(100) NOT NULL,
FOREIGN KEY (UID) REFERENCES USERS(UID)
);

CREATE TABLE CASH_TRANS(
TRANS_ID INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
TRANS_OR_ID VARCHAR(15) NOT NULL,
TRANS_VISIT_ID INT NOT NULL,
TRANS_TIME VARCHAR(25),
TRANS_NOTE VARCHAR(20)
);

CREATE TABLE SALES_REPORT(
SALE_DAY_ID INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
SALE_DATE VARCHAR(25),
SALE_CASH DECIMAL(19,2) NOT NULL DEFAULT 0,
SALE_NOTES VARCHAR(255)
);


#PT_VISIT IS THE TABLE WHERE THE DETAILS OF THE PATIENT'S VISIT IS STORED
CREATE TABLE PT_VISIT(
    #SELF EXPLANATORY
VS_ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
PT_ID INT NOT NULL, 
VS_DATE_VISIT VARCHAR(25),
VS_DOC VARCHAR(30),
VS_HISTORY VARCHAR(65536),
VS_DIAG VARCHAR(65536),
VS_NOTES VARCHAR(65536),
FOREIGN KEY (PT_ID) REFERENCES PATIENT(PT_ID)
);

#THE TYPES OF SERVICES ARE STORED HERE
CREATE TABLE SV_CLASS(
SV_CLASS_ID INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
SV_CLASS_NAME VARCHAR(20) NOT NULL
);

#THE SERVICES ARE STORED HERE
CREATE TABLE SERVICES(
SV_ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
SV_NAME VARCHAR(20) NOT NULL,
SV_CLASS_ID INT NOT NULL,
SV_TYPE VARCHAR(20) NOT NULL,
PRICE DECIMAL(19,2) NOT NULL,
FOREIGN KEY (SV_CLASS_ID) REFERENCES SV_CLASS(SV_CLASS_ID)
);

#THE BRIDGE BETWEEN THE VISIT RECORD AND SERVICES
CREATE TABLE PT_VISIT_SERVICE( 
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,

SV_ID VARCHAR(20) NOT NULL,

PV_ID INT NOT NULL,

#PRICE HAS A SEPARATE ENTITY BECAUSE THE ADMIN CAN EDIT THE PRICE OF THE PRICE
#OF THE SERVICE IN THE TRANSACTION
SV_PRICE DECIMAL(19,2), 

PT_STATUS VARCHAR(10) DEFAULT 'UNPAID',

SV_DATE VARCHAR(25),

SV_ATTENDANT INT NOT NULL,

FOREIGN KEY (PV_ID) REFERENCES PT_VISIT(VS_ID),

FOREIGN KEY (SV_ATTENDANT) REFERENCES USERS(UID)
);




INSERT INTO `USERS` (`USERNAME`, `PASSWD`, `FULL_NAME`, `RX`) VALUES
( 'user', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', 'Level 1 User', 'g'),
( 'admin', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', 'Admin User', 'gca');
