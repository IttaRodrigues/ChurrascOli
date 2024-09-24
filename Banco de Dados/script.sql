CREATE DATABASE IF NOT EXISTS ChurrascOLi;
USE ChurrascOli;

CREATE TABLE IF NOT EXISTS Tipo (
    Id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE IF NOT EXISTS Churrasco (
    Id INT UNSIGNED NOT NULL AUTO_INCREMENT,
    Nome VARCHAR(30) NOT NULL UNIQUE,
    Descricao VARCHAR(1000),
    Imagem VARCHAR(200),
    TipoId INT UNSIGNED NOT NULL,
   PRIMARY KEY (Id),
   FOREIGN KEY (TipoId) REFERENCES Tipo(Id)
);

INSERT INTO Tipo (Id, Nome) VALUES 
(1, 'Carne Bovina'),
(2, 'Aves'),
(3, 'Linguiça');

INSERT INTO Churrasco (Id, Nome, Descricao, Imagem, TipoId) VALUES 
(1, 'Fraldinha', 'Corte macio e saboroso, ideal para grelhar.', '/img/Fraldinha.jpg', 1),
(2, 'Frango', 'Carne leve e versátil, perfeita para diversas receitas.', '/img/frango.jpg', 2),
(3, 'Linguiça Toscana', 'Linguiça saborosa, ideal para churrasco.', '/img/linguiça.jpg', 3),
(4, 'Picanha', 'Corte nobre, suculento e muito apreciado no Brasil.', '/img/picanha.jpg', 1),
(5, 'Tomahawk', 'Corte grande e impressionante, com osso e muito sabor.', '/img/tomahowk.jpg', 1);