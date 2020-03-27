CREATE TABLE IF NOT EXISTS Item(
	Codigo INT not null,
    Descricao VARCHAR(100) not null,
	Estoque Decimal(10,2) not null,
	Preco Decimal(10,2) not null,
	Cadastro Date not null,
	Ativo bit not null
)ENGINE=InnoDB DEFAULT CHARSET=latin1;