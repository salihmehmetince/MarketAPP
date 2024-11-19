create table TblCompanyHasFactory(
	companyHasFactoryId int not null identity(1,1),
	companyId int not null,
	factoryId int not null,
	ownershipStartDate date not null,
	ownershipEndDate date null,
	isActive bit not null,
	constraint PK_companyHasFactoryId primary key(companyHasFactoryId),
	constraint FK_companyHFId foreign key(companyId) references TblCompany(companyId),
	constraint FK_factoryHFId foreign key(factoryId) references TblFactory(factoryId)
);