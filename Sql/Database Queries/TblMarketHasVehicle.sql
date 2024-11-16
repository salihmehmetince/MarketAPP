create table TblMarketHasVehicle(
	marketHasVehicleId int not null identity(1,1),
	marketId int not null,
	vehicleId int not null,
	vehiclePurchaseMilAge bigint not null,
	vehiclePurchasePrice decimal(18,2) not null,
	vehiclePurchaseDate date not null,
	constraint PK_marketHasVehicleId primary key(marketHasVehicleId),
	constraint FK_marketIdHV foreign key(marketId) references TblMarket(marketId),
	constraint FK_vehicleIdHV foreign key(vehicleId) references TblVehicle(vehicleId),
);