create table TblMarketInventory(
	marketInventoryId int not null identity(1,1),
	marketId int not null,
	productTemplateId int not null,
	totalAmount bigint not null,
	constraint PK_marketInventoryId primary key(marketInventoryId),
	constraint FK_marketIdMarketInventory foreign key(marketId) references TblMarket(marketId),
	constraint FK_productTemplateIdMarketInventory foreign key(productTemplateId) references TblProductTemplate(productTemplateId)
);