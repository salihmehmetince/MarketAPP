create table TblVehicle(
	vehicleId int not null identity(1,1),
	vehiclePlateNumber nvarchar(20) null,
	vehicleSerialNumber nvarchar(20) not null,
	vehicleType int not null,
	vehicleBrand int not null,
	vehicleModel int not null,
	constraint PK_vehicleId primary key(vehicleId),
	constraint CK_vehiclePlateNumber check(len(vehiclePlateNumber)>2),
	constraint CK_vehicleSerialNumber check(len(vehicleSerialNumber)>2),
	constraint FK_vehicleType foreign key(vehicleType) references TblVehicleType(vehicleTypeId),
	constraint FK_vehicleBrand foreign key(vehicleBrand) references TblVehicleBrand(vehicleBrandId),
	constraint FK_vehicleModel foreign key(vehicleModel) references TblVehicleModel(vehicleModelId),
	constraint UQ_vehicleSerialNumber unique(vehicleSerialNumber)
);