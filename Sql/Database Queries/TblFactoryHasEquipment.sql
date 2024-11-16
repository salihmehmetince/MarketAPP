create table TblFactoryHasEquipment(
	factoryHasequipmentId int not null identity(1,1),
	factoryId int not null,
	equipmentId int not null,
	purchaseDate date not null,
	purchasePrice decimal(18,2) not null,
	constraint PK_factoryHaseqipmentId primary key(factoryHasequipmentId),
	constraint FK_factoryHEId foreign key(factoryId) references TblFactory(factoryId),
	constraint FK_equipmentHEId foreign key(equipmentId) references TblEquipment(equipmentId)
);