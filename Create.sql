DROP TABLE IF EXISTS client;

CREATE TABLE client
(
	id INT PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
	username VARCHAR(200) NOT NULL,
	age SMALLINT NOT NULL
);

INSERT INTO client(username, age) VALUES('Test', 20);
INSERT INTO client(username, age) VALUES('Test1', 22);
INSERT INTO client(username, age) VALUES('Test2', 23);
INSERT INTO client(username, age) VALUES('Test3', 24);