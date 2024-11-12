create table TblProductUnit(
	productUnitId int not null identity(1,1),
	productUnitName nvarchar(40) not null,
	constraint PK_productUnitId primary key(productUnitId),
	constraint CK_productUnitName check(len(productUnitName)>1)
);