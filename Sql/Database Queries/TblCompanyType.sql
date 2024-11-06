create table TblCompanyType(
	companyTypeId int not null identity(1,1),
	companyType nvarchar(30) not null,
	constraint PK_companyTypeId primary key(companyTypeId),
	constraint CK_companyTypeName check(len(companyType)>2)
);