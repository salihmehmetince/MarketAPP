create table TblWarehouseInventory(
	warehouseInventoryId int not null identity(1,1),
	warehouseId int not null,
	productTemplateId int not null,
	totalAmount bigint not null,
	constraint PK_warehouseInventoryId primary key(warehouseInventoryId),
	constraint FK_warehouseIdWarehouseInventory foreign key(warehouseId) references TblWarehouse(warehouseId),
	constraint FK_productTemplateIdWarehouseInventory foreign key(productTemplateId) references TblProductTemplate(productTemplateId)
);