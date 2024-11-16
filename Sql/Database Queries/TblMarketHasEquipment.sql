create table TblMarketHasEquipment(
	marketHasEquipmentId int not null identity(1,1),
	marketId int not null,
	equipmentId int not null,
	purchaseDate date not null,
	purchasePrice decimal(18,2) not null,
	constraint PK_marketHasEquipmentId primary key(marketHasEquipmentId),
	constraint FK_marketIdHEq foreign key(marketId) references TblMarket(marketId),
	constraint FK_equipmentIdHEq foreign key(equipmentId) references TblEquipment(equipmentId)
);