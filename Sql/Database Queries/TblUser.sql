Create Table TblUser
(
	userId int not null identity(1,1),
	userName nvarchar(40) not null,
	userPassword nvarchar(40) not null,
	company int not null,
	constraint PK_userId primary key(userId),
	constraint FK_userCompany foreign key(company) references TblCompany(companyId)
);