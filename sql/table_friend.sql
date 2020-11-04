BEGIN TRANSACTION;

	CREATE TABLE friends(
	
		id INT IDENTITY PRIMARY KEY NOT NULL,
		id_user INT NULL,
		CONSTRAINT fk_user FOREIGN KEY (id_user) REFERENCES dbo.users (id_user),

		id_friend INT NULL,
		CONSTRAINT fk_friend FOREIGN KEY (id_friend) REFERENCES dbo.users (id_user)

	);

COMMIT;