create table TblVehicleBrand(
	vehicleBrandId int not null identity(1,1),
	vehicleBrandName nvarchar(40) not null,
	constraint PK_vehicleBrandId primary key(vehicleBrandId),
	constraint CK_vehicleBrandName check(len(vehicleBrandName)>1)
);