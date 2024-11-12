create table TblMarketHasEmployee(
	marketHasEmployeeId int not null identity(1,1),
	marketId int not null,
	employeeId int not null,
	constraint PK_marketHasEmployeeId primary key(marketHasEmployeeId),
	constraint FK_marketId foreign key (marketId) references TblMarket(marketId),
	constraint FK_employeeId foreign key (employeeId) references TblEmployee(employeeId)
);