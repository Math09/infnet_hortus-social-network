﻿BEGIN TRANSACTION;

	CREATE TABLE users(
	
		id_user INT IDENTITY PRIMARY KEY NOT NULL,
		photo VARCHAR(255) NULL,
		name_user VARCHAR(50) NOT NULL,
		email VARCHAR(50) NOT NULL,
		password_user VARCHAR(255) NOT NULL

	);
	
COMMIT;