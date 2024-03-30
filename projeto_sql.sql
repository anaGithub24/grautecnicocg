CREATE DATABASE biblioteca2


CREATE TABLE livros

(
id_livro smallint primary key,
nome_livro varchar(50) not null,
id_autor smallint not null
);

use biblioteca2

CREATE TABLE AUTORES
(
id_autores smallint primary key not null,
nome_autor varchar(50),
sobrenome_autor varchar(60)
);

INSERT INTO livros VALUES (1, 'a casa' , 12)

SELECT * FROM livros