create table TblFactorySendsProductToWarehouse(
	factorySendsProductToWarehouseId int not null identity(1,1),
	factoryId int not null,
	warehouseId int not null,
	productTemplateId int not null,
	productQuantity bigint not null,
	sendDate date not null,
	sendVehicle int not null,
	constraint PK_factorySendsProductToWarehouse primary key(factorySendsProductToWarehouseId),
	constraint FK_factoryId foreign key(factoryId) references TblFactory(factoryId),
	constraint FK_warehouseId foreign key(warehouseId) references TblWarehouse(warehouseId),
	constraint FK_productTemplateId foreign key(productTemplateId) references TblProductTemplate(productTemplateId),
	constraint FK_sendVehicle foreign key(sendVehicle) references TblVehicle(vehicleId)

	);