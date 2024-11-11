create table TblVehicleType(
	vehicleTypeId int not null identity(1,1),
	vehicleTypeName nvarchar(40) not null,
	constraint PK_vehicleTypeId primary key(vehicleTypeId),
	constraint CK_vehicleTypeName check(len(vehicleTypeName)>1)
);