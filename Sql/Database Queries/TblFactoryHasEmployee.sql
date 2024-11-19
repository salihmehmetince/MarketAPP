create table TblFactoryHasEmployee(
	factoryHasEmployeeId int not null identity(1,1),
	factoryId int not null,
	employeeId int not null,
	startdate date not null,
	enddate date null,
	isActive bit not null,
	constraint PK_factoryHasEmployee primary key(factoryHasEmployeeId),
	constraint FK_factoryHEmId foreign key (factoryId) references TblFactory(factoryId),
	constraint FK_employeeHEmId foreign key (employeeId) references TblEmployee(employeeId)
);