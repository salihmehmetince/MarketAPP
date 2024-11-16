create table TblFactoryProductProduction(
	factoryProductProductionId int not null identity(1,1),
	factoryId int not null,
	productTemplateId int not null,
	productQuantity int not null,
	productionDate date not null,
	expirationDate int not null,
	constraint PK_factoryProductProductionId primary key(factoryProductProductionId),
	constraint FK_factoryIdProductProduction foreign key(factoryId) references TblFactory(factoryId),
	constraint FK_productTemplateIdProductProduction foreign key(productTemplateId) references TblProductTemplate(productTemplateId)
);