CREATE DATABASE HAMBA_HATT;

CREATE TABLE ADMIN_LIST
(
ID VARCHAR(50),
NAME VARCHAR(50),
PASS VARCHAR(50) ,
MOBILE VARCHAR(50),
ADDRESS VARCHAR(50),
EMAIL VARCHAR(50)
);

SELECT * FROM ADMIN_LIST;




CREATE TABLE BUYER_LIST
(
NAME VARCHAR(50),
PASS VARCHAR(50),
MOBILE VARCHAR(50),
ADDRESS VARCHAR(50),
EMAIL VARCHAR(50)
);
SELECT * FROM BUYER_LIST;

CREATE TABLE SELLER_LIST
(
NAME VARCHAR(50),
PASS VARCHAR(50),
MOBILE VARCHAR(50),
ADDRESS VARCHAR(50),
EMAIL VARCHAR(50)
);

SELECT * FROM SELLER_LIST;

CREATE TABLE COW_LIST
(

HEIGHT VARCHAR(50),
WEIGHT VARCHAR(50),
COLOR VARCHAR(50),
TYPE VARCHAR(50),
PRICE VARCHAR(50),
PICTURE IMAGE
);

SELECT*FROM COW_LIST;
SELLER VARCHAR(50),

ALTER TABLE COW_LIST ADD SELLER VARCHAR(50);

exec sp_rename 'COW_LIST.COW ID','ID','column';

CREATE TABLE GOAT_LIST
(
HEIGHT VARCHAR(50),
WEIGHT VARCHAR(50),
COLOR VARCHAR(50),
TYPE VARCHAR(50),
PRICE VARCHAR(50),
PICTURE IMAGE
);

SELECT*FROM GOAT_LIST;
ALTER TABLE GOAT_LIST ADD SELLER VARCHAR(50);

exec sp_rename 'GOAT_LIST.GOAT ID','ID','column';



CREATE TABLE CART_LIST
(
HEIGHT VARCHAR(50),
WEIGHT VARCHAR(50),
COLOR VARCHAR(50),
TYPE VARCHAR(50),
PRICE VARCHAR(50),
PICTURE IMAGE,
SELLER VARCHAR(50)
);

SELECT*FROM CART_LIST;
exec sp_rename 'CART_LIST.HEIGHT','ID','column';

CREATE TABLE BOOKING_LIST
(
PRICE VARCHAR(50),
SELLER VARCHAR(50),
WEIGHT VARCHAR(50),
PICTURE IMAGE
);

SELECT*FROM BOOKING_LIST;

ALTER TABLE  BOOKING_LIST ADD Phone VARCHAR(50);



CREATE TABLE SELLER_TRAX
(
PRICE VARCHAR(50),
FEES VARCHAR(50),
INCOME VARCHAR(50),
BUYERPHONE VARCHAR(50)
);
SELECT*FROM SELLER_TRAX;
ALTER TABLE  SELLER_TRAX ADD SELLER VARCHAR(50);