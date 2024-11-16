create table TblFactoryHasVehicle(
	factoryHasVehicleId int not null identity(1,1),
	factoryId int not null,
	vehicleId int not null,
	vehiclePurchaseMilAge bigint not null,
	vehiclePurchasePrice decimal(18,2) not null,
	vehiclePurchaseDate date not null,
	constraint PK_factoryHasVehicleId primary key(factoryHasVehicleId),
	constraint FK_factoryHVId foreign key(factoryId) references TblFactory(factoryId),
	constraint FK_vehicleHVId foreign key(vehicleId) references TblVehicle(vehicleId),
);