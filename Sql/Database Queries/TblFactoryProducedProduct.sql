create table TblFactoryProducedProduct(
	factoryProducedProductId int not null identity(1,1),
	factoryId int not null,
	productTemplateId int not null,
	productiýnDate date not null,
	barkod char(13) not null,
	constraint PK_factoryProducedProductId primary key(factoryProducedProductId),
	constraint FK_factoryIdProducedProduct foreign key(factoryId) references TblFactory(factoryId),
	constraint FK_productTemplateIdProducedProduct foreign key(productTemplateId) references TblProductTemplate(productTemplateId)
);