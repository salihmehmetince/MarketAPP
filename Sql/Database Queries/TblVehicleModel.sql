create table TblVehicleModel(
	vehicleModelId int not null identity(1,1),
	vehicleModelName nvarchar(40) not null,
	constraint PK_vehicleModelId primary key(vehicleModelId),
	constraint CK_vehicleModelName check(len(vehicleModelName)>1)
);