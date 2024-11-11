create table TblCompanyOwner(
	companyOwnerId int not null identity(1,1),
	companyOwnerIdentityNumber varchar(15) not null,
	companyOwnerName nvarchar(40) not null,
	companyOwnerSurname nvarchar(40) not null,
	companyOwnerEmail nvarchar(50) not null,
	companyOwnerTelephoneNumber varchar(30) not null,
	companyOwnerGender char(1) not null,
	companyOwnerBirthDate date not null,
	companyOwnerBirthPlace nvarchar(255) not null,
	companyOwnerAddress nvarchar(255) not null,
	companyOwnerProfession int not null,
	constraint PK_companyOwnerId primary key(companyOwnerId),
	constraint CK_companyOwnerIdentityNumber check(len(companyOwnerIdentityNumber)>5),
	constraint CK_companyOwnerName check(len(companyOwnerName)>1),
	constraint CK_companyOwnerSurname check(len(companyOwnerSurname)>1),
	constraint CK_companyOwnerGender check(companyOwnerGender in ('M','F','N')),
	constraint FK_companyOwnerProfession foreign key(companyOwnerProfession) references TblProfession(professionId)

	--constraint CK_companyOwnerEmailFormat check(companyOwnerEmail like '%@%'),
	--constraint CK_companyOwnerEmailLong check(len(companyOwnerEmail)>5),
	--constraint CK_companyOwnerTelephoneNumber check(len(companyOwnerTelephoneNumber)>5),
	--constraint CK_companyOwnerBirthPlace check(len(companyOwnerBirthPlace)>10),
	--constraint CK_companyOwnerAddress check(len(companyOwnerAddress)>10),

);