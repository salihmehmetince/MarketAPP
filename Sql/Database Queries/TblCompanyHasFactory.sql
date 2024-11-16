create table TblCompanyHasFactory(
	companyHasFactoryId int not null identity(1,1),
	companyId int not null,
	factoryId int not null,
	ownershipStartDate date null,
	ownershipEndDate date null,
	constraint PK_companyHasFactoryId primary key(companyHasFactoryId),
	constraint FK_companyHFId foreign key(companyId) references TblCompany(companyId),
	constraint FK_factoryHFId foreign key(factoryId) references TblFactory(factoryId)
);