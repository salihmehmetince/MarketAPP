create table TblRankType(
	rankTypeId int not null identity(1,1),
	rankTypeName nvarchar(40) not null,
	rankTypeSalaryValue decimal(18,2) not null,
	constraint PK_rankTypeId primary key(rankTypeId),
	constraint CK_rankTypeName check(len(rankTypeName)>1)
);