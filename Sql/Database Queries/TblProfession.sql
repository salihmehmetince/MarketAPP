create table TblProfession(
	professionId int not null identity(1,1),
	professionName nvarchar(40) not null,
	constraint PK_professionId primary key(professionId),
	constraint CK_professionName check(len(professionName)>1)
);