create table TblCompany(
	companyId int not null identity(1,1),
	companyName nvarchar(30) not null,
	companyType int not null,
	companyCountry int not null,
	constraint PK_companyId primary key(companyId),
	constraint CK_companyName check(len(companyName)>1),
	constraint FK_companyType foreign key(companyType) references TblCompanyType(companyTypeId),
	constraint FK_companyCountry foreign key(companyCountry) references TblCountry(countryId)

);