create table TblCompanyHasMarket(
	companyHasMarketId int not null identity(1,1),
	companyId int not null,
	marketId int not null,
	ownershipStartDate date null,
	ownershipEndDate date null,
	constraint PK_companyHasMarketId primary key(companyHasMarketId),
	constraint FK_companyId foreign key(companyId) references TblCompany(companyId),
	constraint FK_marketId foreign key(marketId) references TblMarket(marketId)
);