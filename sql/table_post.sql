BEGIN TRANSACTION;

	CREATE TABLE post(
		
		id_post INT IDENTITY PRIMARY KEY NOT NULL,
		id_user INT NOT NULL,
		CONSTRAINT fk_post_user FOREIGN KEY (id_user) REFERENCES dbo.users (id_user),

		photo VARCHAR(255) NULL,
		description_post VARCHAR(255) NULL,
		like_post INT NULL,

	);

COMMIT;