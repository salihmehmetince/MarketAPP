create table TblCompanyHasFactory(
	companyHasFactoryId int not null identity(1,1),
	companyId int not null,
	factoryId int not null,
	ownershipStartDate date null,
	ownershipEndDate date null,
	constraint PK_companyHasFactoryId primary key(companyHasFactoryId),
	constraint FK_companyId foreign key(companyId) references TblCompany(companyId),
	constraint FK_factoryId foreign key(factoryId) references TblFactory(factoryId)
);