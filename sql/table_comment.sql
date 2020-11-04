BEGIN TRANSACTION;

	CREATE TABLE comment(
		
		id_comment INT PRIMARY KEY NOT NULL,
		id_post INT NOT NULL,
		CONSTRAINT fk_post FOREIGN KEY (id_post) REFERENCES dbo.post (id_post),

		comment VARCHAR(255) NOT NULL

	);

COMMIT;