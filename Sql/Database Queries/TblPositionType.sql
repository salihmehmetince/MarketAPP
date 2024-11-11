create table TblPositionType(
	positionTypeId int not null identity(1,1),
	positionTypeName nvarchar(40) not null,
	positionTypeSalaryValue decimal(18,2) not null,
	constraint PK_positionTypeId primary key(positionTypeId),
	constraint CK_positionTypeName check(len(positionTypeName)>1)
);