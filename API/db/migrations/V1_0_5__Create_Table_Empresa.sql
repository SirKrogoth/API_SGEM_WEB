CREATE TABLE IF NOT EXISTS Empresa(
	Codigo int not null,
	Cnpj varchar(20) not null,
	RazaoSocial varchar(200) not null
) ENGINE=InnoDB DEFAULT CHARSET=latin1;