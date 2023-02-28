CREATE TABLE clienti (
ID int IDENTITY (1,1) PRIMARY KEY NOT NULL,
[Name] nvarchar(30) NOT NULL,
Surname nvarchar(30) NOT NULL,
Eta int NOT NULL,
Piva nvarchar(25),
Colore_capelli int NOT NULL,
Data_Inserimento DateTime NOT NULL,
Stato_Record bit NOT NULL
)
ALTER TABLE clienti
ADD FOREIGN KEY (Colore_capelli) REFERENCES colore_capelli(id);

