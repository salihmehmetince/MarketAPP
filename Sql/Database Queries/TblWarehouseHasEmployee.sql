create table TblWarehouseHasEmployee(
	warehouseHasEmployeeId int not null identity(1,1),
	warehouseId int not null,
	employeeId int not null,
	startdate date not null,
	enddate date null,
	isActive bit not null,
	constraint PK_warehouseHasEmployeeId primary key(warehouseHasEmployeeId),
	constraint FK_warehouseIdHEmp foreign key (warehouseId) references TblWarehouse(warehouseId),
	constraint FK_employeeIdHEmp foreign key (employeeId) references TblEmployee(employeeId)
);