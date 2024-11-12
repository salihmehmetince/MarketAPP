create table TblProductBrand(
	productBrandId int not null identity(1,1),
	productBrandName nvarchar(40) not null,
	constraint PK_productBrandId primary key(productBrandId),
	constraint CK_productBrandName check(len(productBrandName)>1)
);