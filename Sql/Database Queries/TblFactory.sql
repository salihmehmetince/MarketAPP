create table TblFactory(
	factoryId int not null identity(1,1),
	factoryName nvarchar(40) not null,
	factoryAddress nvarchar(255) not null,
	factoryTelephoneNumber varchar(30) not null,
	factoryEmail nvarchar(50) not null,
	constraint PK_factoryId primary key(factoryId),
	constraint CK_factoryName check(len(factoryName)>1)
);