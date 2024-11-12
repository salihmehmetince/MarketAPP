create table TblProductType(
	productTypeId int not null identity(1,1),
	productTypeName nvarchar(40) not null,
	constraint PK_productTypeId primary key(productTypeId),
	constraint CK_productTypeName check(len(productTypeName)>1)
);