CREATE DATABASE IF NOT EXISTS tododb;

USE tododb;

CREATE TABLE IF NOT EXISTS Tarea (
    IdTarea INT AUTO_INCREMENT PRIMARY KEY,
    NombreTarea NVARCHAR(250),
    Completada BOOLEAN
);

INSERT INTO Tarea (NombreTarea, Completada) VALUES
('Hacer la compra', 0),
('Limpiar la casa', 1),
('Preparar la presentación', 0),
('docker compose.yml', 0);