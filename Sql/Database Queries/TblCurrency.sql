create table TblCurrency(
	currencyId int not null identity(1,1),
	currencyNameCode nvarchar(40) not null,
	constraint PK_currencyId primary key(currencyId),
	constraint CK_currencyNameCode check(len(currencyNameCode)>1)
);