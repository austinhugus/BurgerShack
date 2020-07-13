USE burgershack208;

-- MySql : MongoDb => Table : Collection


--CREATE COLLECTION
-- CREATE TABLE burgers
-- (
-- id INT AUTO_INCREMENT
-- name VARCHAR(255) NOT NULL UNIQUE,
-- description VARCHAR(255),
-- price DECIMAL (5, 2) NOT NULL; -- 5 CHARACTERS WITH 2 AFTER THE DECIMAL, 100.00

-- PRIMARY KEY(id)
-- );

-- GET ALL
-- SELECT * FROM burgers;

-- GET BY ID
-- SELECT * FROM burgers WHERE id = 1; --WHERE is equvialent to our filter

--CREATE
-- INSERT INTO burgers
-- (name, price, description) --Columns I will provide you
-- VALUES
-- ("Aloha Zach", 7.99. "Taste of the Islands and Pineapple");

--EDIT
-- UPDATE burgers 
-- SET
--     description = "",
--     price = 5.99
-- WHERE id = 4; --burger ID you want to edit

-- DELETE
-- DELETE FROM burgers WHERE id = 4;


-- DANGER ZONE
-- DELETE FROM burgers; --DELETES ALL DATA IN TABLE
-- DROP TABLE burgers; --DESTROYS WHOLE TABLE
-- DROP BATABASE burgershack208; --DESTROYS WHOLE DATABASE