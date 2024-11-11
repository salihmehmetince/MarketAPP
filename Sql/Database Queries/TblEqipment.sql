create table TblEquipment(
	equipmentId int not null identity(1,1),
	equipmentName nvarchar(40) not null,
	constraint PK_equipmentId primary key(equipmentId),
	constraint CK_equipmentName check(len(equipmentName)>1)
);