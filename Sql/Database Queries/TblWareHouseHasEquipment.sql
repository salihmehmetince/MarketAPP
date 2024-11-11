create table TblWareHouseHasEquipment(
	warehouseHasequipmentId int not null identity(1,1),
	warehouseId int not null,
	equipmentId int not null,
	purchaseDate date not null,
	purchasePrice decimal(18,2) not null,
	constraint PK_warehouseHasequipmentId primary key(warehouseHasequipmentId),
	constraint FK_warehouseId foreign key(warehouseId) references TblWarehouse(warehouseId),
	constraint FK_equipmentId foreign key(equipmentId) references TblEquipment(equipmentId)
);