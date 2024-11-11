create table TblWarehouse(
	warehouseId int not null identity(1,1),
	warehouseName nvarchar(40) not null,
	warehouseAddress nvarchar(255) not null,
	warehouseTelephoneNumber varchar(30) not null,
	warehouseEmail nvarchar(50) not null,
	constraint PK_warehouseId primary key(warehouseId),
	constraint CK_warehouseName check(len(warehouseName)>1)
);