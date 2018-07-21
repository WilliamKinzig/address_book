# Hair Salon
##### July 19th, 2018

## William Kinzig
##### Email: wippawill@gmail.com
##### Github: github.com/WilliamKinzig
____
#### Setup instructions:

* mysql> CREATE DATABASE HairSalon;
* mysql> USE HairSolon;
* mysql> CREATE TABLE stylist (id serial PRIMARY KEY, name VARCHAR(255));
* mysql>
* mysql> CREATE TABLE clients (id serial PRIMARY KEY, name VARCHAR(255));
* mysql>
* mysql>
----
### Database Tables:
* | | stylists
* |---------
* | id
* | name
* | client_id


* | | clients  
* |-----------
* | id
* | name
* | employee_id
------
### Specs and BDD:

* view list of stylists
* select a stylist and see their clients
* add new stylist
* add new clients
* each client only belongs to one stylist
* no adding clients if there are no stylists


|Behavior|Input|Output|
|--------|-----|------|
|GetList of Stylists|.|.|
|GetList of Clients|.|.|
|Add new stylist|.|.|
|Add new client|.|.|
---
### Naming

* Production Database:
* * first_last


* export file:
* * first_last.sql


* Test Database:
* * first_last_test


* export files:
* * first_last_test.sql


* Main Project Folder:
* * HairSalon


* Test Project Folder:
* * HairSalon.Tests

---
