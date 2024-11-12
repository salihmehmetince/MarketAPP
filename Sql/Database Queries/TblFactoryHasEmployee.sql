create table TblFactoryHasEmployee(
	factoryHasEmployeeId int not null identity(1,1),
	factoryId int not null,
	employeeId int not null,
	constraint PK_factoryHasEmployee primary key(factoryHasEmployeeId),
	constraint FK_factoryId foreign key (factoryId) references TblFactory(factoryId),
	constraint FK_employeeId foreign key (employeeId) references TblEmployee(employeeId)
);