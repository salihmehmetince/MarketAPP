create table TblFactorySendsProductToMarket(
	factorySendsProductToMarketId int not null identity(1,1),
	factoryId int not null,
	marketId int not null,
	productTemplateId int not null,
	productQuantity bigint not null,
	senddate date not null,
	sendVehicle int not null,
	constraint PK_factorySendsProductToMarketId primary key(factorySendsProductToMarketId),
	constraint FK_factoryIdFactorySendsProductToMarket foreign key(factoryId) references TblFactory(factoryId),
	constraint FK_marketIdFactorySendsProductToMarket foreign key(marketId) references TblMarket(marketId),
	constraint FK_productTemplateIdFactorySendsProductToMarket foreign key(productTemplateId) references TblProductTemplate(productTemplateId), 
	constraint FK_sendVehicleFactorySendsProductToMarket foreign key(sendVehicle) references TblVehicle(vehicleId)

	);