create table TblFactorySendsProductToMarket(
	factorySendsProductToMarketId int not null identity(1,1),
	factoryId int not null,
	marketId int not null,
	productTemplateId int not null,
	productQuantity bigint not null,
	senddate date not null,
	sendVehicle int not null,
	constraint PK_factorySendsProductToMarketId primary key(factorySendsProductToMarketId),
	constraint FK_factoryId foreign key(factoryId) references TblFactory(factoryId),
	constraint FK_marketId foreign key(marketId) references TblMarket(marketId),
	constraint FK_productTemplateId foreign key(productTemplateId) references TblProductTemplate(productTemplateId),
	constraint FK_sendVehicle foreign key(sendVehicle) references TblVehicle(vehicleId)

	);