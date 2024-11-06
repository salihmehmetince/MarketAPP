create table TblAdmin(
	adminId int not null identity(1,1),
	adminUsername nvarchar(50) not null,
	adminPassword nvarchar(30) not null,
	constraint PK_adminId primary key(adminId),
	constraint CK_adminUsername check(len(adminUsername)>3),
	constraint CK_adminPassword check(len(adminPassword)>7)
);