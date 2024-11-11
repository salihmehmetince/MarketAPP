create table TblWarehouseHasVehicle(
	warehouseHasVehicleId int not null identity(1,1),
	warehouseId int not null,
	vehicleId int not null,
	vehiclePurchaseMilAge bigint not null,
	vehiclePurchasePrice decimal(18,2) not null,
	vehiclePurchaseDate date not null,
	constraint PK_warehouseHasVehicleId primary key(warehouseHasVehicleId),
	constraint FK_warehouseId foreign key(warehouseId) references TblWarehouse(warehouseId),
	constraint FK_vehicleId foreign key(vehicleId) references TblVehicle(vehicleId),
);