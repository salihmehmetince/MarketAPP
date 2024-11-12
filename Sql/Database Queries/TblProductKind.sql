create table TblProductKind(
	productKindId int not null identity(1,1),
	productKindName nvarchar(40) not null,
	constraint PK_productKindId primary key(productKindId),
	constraint CK_productKindName check(len(productKindName)>1)
);