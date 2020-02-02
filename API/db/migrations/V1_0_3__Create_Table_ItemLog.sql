CREATE TABLE IF NOT EXISTS ItemLog(
	Codigo int not null,
	Registro varchar(1000) not null,
	Tipo varchar(100) not null,
	DataRegistro datetime not null
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

ALTER TABLE ItemLog MODIFY Codigo int not null AUTO_INCREMENT PRIMARY KEY;