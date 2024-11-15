create table TblCountry(
	countryId int not null identity(1,1),
	countryName nvarchar(40) not null,
	constraint PK_countryId primary key(countryId),
	constraint CK_countryName check(len(countryName)>2)
);