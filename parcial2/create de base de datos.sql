CREATE DATABASE Parcial2DB;
GO
USE Parcial2DB;
GO

CREATE TABLE Conversiones (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    MonedaOrigen NVARCHAR(10),
    MonedaDestino NVARCHAR(10),
    Monto DECIMAL(18,4),
    Resultado DECIMAL(18,4),
    Tasa DECIMAL(18,4),
    Fecha DATETIME DEFAULT GETDATE()
);
use Parcial2DB
select * from Conversiones;