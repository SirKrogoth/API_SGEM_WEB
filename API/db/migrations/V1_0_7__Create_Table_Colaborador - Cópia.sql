CREATE TABLE IF NOT EXISTS Colaborador(
	Codigo int not null,
	CodEmpresa int,
	Nome varchar(200) not null,
	Idade char not null,
	Login varchar(20) not null,
	Senha varchar(20) not null,
	AdministradorEmpresa bit default 0,
	AdministradorSistema bit default 0,
	Foreign Key(CodEmpresa) references Empresa(Codigo)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


ALTER TABLE Colaborador MODIFY Codigo int not null AUTO_INCREMENT PRIMARY KEY;