create table TblCompanyHasWarehouse(
	companyHasWarehouseId int not null identity(1,1),
	companyId int not null,
	warehouseId int not null,
	ownershipStartDate date null,
	ownershipEndDate date null,
	constraint PK_companyHasWarehouseId primary key(companyHasWarehouseId),
	constraint FK_companyHWId foreign key(companyId) references TblCompany(companyId),
	constraint FK_warehouseHWId foreign key(warehouseId) references TblWarehouse(warehouseId)
);