create table TblCompanyHasMarket(
	companyHasMarketId int not null identity(1,1),
	companyId int not null,
	marketId int not null,
	ownershipStartDate date not null,
	ownershipEndDate date null,
	isActive bit not null,
	constraint PK_companyHasMarketId primary key(companyHasMarketId),
	constraint FK_companyHMId foreign key(companyId) references TblCompany(companyId),
	constraint FK_marketHMId foreign key(marketId) references TblMarket(marketId)
);