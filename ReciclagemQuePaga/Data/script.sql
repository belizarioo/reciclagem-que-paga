CREATE DATABASE reciclagemQuePaga;

CREATE TABLE Usuarios
(
	usuario_id INT PRIMARY KEY IDENTITY(1,1),
	nome_usuario VARCHAR(64) NOT NULL,
	email_usuario VARCHAR(70) UNIQUE NOT NULL,
	senha_usuario VARCHAR(120) NOT NULL,
	cpf_usuario CHAR(14) UNIQUE NOT NULL
);


CREATE TABLE Materiais
(
	material_id INT PRIMARY KEY IDENTITY(1,1),
	tipo_material VARCHAR(40) NOT NULL,
	preco_material_por_kilo DECIMAL(7,2) NOT NULL
);

CREATE TABLE Transacoes
(
	transacao_id INT PRIMARY KEY IDENTITY(1,1),
	usuario_id INT NOT NULL,
	material_id INT NOT NULL,
	data_hora_transacao DATETIME DEFAULT GETDATE(),
	valor_transacao DECIMAL(7,2) NOT NULL,
	peso_transacao DECIMAL(7,2) NOT NULL,

	CONSTRAINT Fk_Transacoes_Usuarios FOREIGN KEY(usuario_id) REFERENCES Usuarios(usuario_id),
	CONSTRAINT Fk_Transacoes_Materiais FOREIGN KEY(material_id) REFERENCES Materiais(material_id)
);