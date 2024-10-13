USE `mydatabase`;

CREATE TABLE IF NOT EXISTS Practitioner (
    Id CHAR(36) NOT NULL PRIMARY KEY DEFAULT (UUID()),
    FullName VARCHAR(250),
    BloodType VARCHAR(4)
);

INSERT INTO Practitioner (fullname,bloodtype)
SELECT * FROM (SELECT  'Debora Alves','AB+') AS tmp
WHERE NOT EXISTS (
    SELECT fullname FROM Practitioner WHERE fullname = 'Debora Alves'
) LIMIT 1;

