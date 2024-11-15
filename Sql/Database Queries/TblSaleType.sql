create table TblSaleType(
	saleTypeId int not null identity(1,1),
	saleTypeName nvarchar(40) not null,
	constraint PK_saleTypeId primary key(saleTypeId),
	constraint CK_saleTypeName check(len(saleTypeName)>1)
);