create table TblFactoryInventory(
	factoryInventoryId int not null identity(1,1),
	factoryId int not null,
	productTemplateId int not null,
	totalAmount bigint not null,
	constraint PK_factoryInventoryId primary key(factoryInventoryId),
	constraint FK_factoryIdFactoryInventory foreign key(factoryId) references TblFactory(factoryId),
	constraint FK_productTemplateIdFactoryInventory foreign key(productTemplateId) references TblProductTemplate(productTemplateId)
);