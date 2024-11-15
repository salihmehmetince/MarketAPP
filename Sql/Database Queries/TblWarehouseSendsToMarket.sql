create table TblWarehouseSendsToMarket(
	warehouseSendsToMarketId int not null identity(1,1),
	warehouseId int not null,
	marketId int not null,
	productTemplateId int not null,
	productQuantity bigint not null,
	sendDate date not null,
	sendVehicle int not null,
	constraint PK_warehouseSendsToMarketId primary key(warehouseSendsToMarketId),
	constraint FK_warehouseId foreign key(warehouseId) references TblWarehouse(warehouseId),
	constraint FK_marketId foreign key(marketId) references TblMarket(marketId),
	constraint FK_productTemplateId foreign key(productTemplateId) references TblProductTemplate(productTemplateId),
	constraint FK_sendVehicle foreign key(sendVehicle) references TblVehicle(vehicleId)

);