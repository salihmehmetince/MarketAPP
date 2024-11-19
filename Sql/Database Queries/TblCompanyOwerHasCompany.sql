create table TblCompanyOwerHasCompany(
	CompanyOwerHasCompanyId int not null identity(1,1),
	companyOwner int not null,
	company int not null,
	companyOwnerPercent tinyint not null,
	startDate date not null,
	endDate date null,
	isActive bit not null,
	constraint PK_CompanyOwerHasCompanyId primary key(CompanyOwerHasCompanyId),
	constraint FK_companyOwner foreign key(companyOwner) references TblCompanyOwner(companyOwnerId),
	constraint FK_company foreign key(company) references TblCompany(companyId),
	constraint CK_companyOwnerPercent check(companyOwnerPercent >= 0 and companyOwnerPercent<=100)
);