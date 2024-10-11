

CREATE TABLE Practitioner (
    Id		  UNIQUEIDENTIFIER NOT NULL,         -- Mapeamento para Guid (Id)
    FullName  NVARCHAR(150) NOT NULL,			 -- Mapeamento para string (FullName)
    BloodType NVARCHAR(2),						 -- Mapeamento para string (BloodType)
    CONSTRAINT PK_Practitioner PRIMARY KEY (Id)  -- Definindo a chave primária
);