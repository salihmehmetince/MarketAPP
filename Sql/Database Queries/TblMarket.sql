create table TblMarket(
	marketId int not null identity(1,1),
	marketName nvarchar(40) not null,
	marketAddress nvarchar(255) not null,
	marketTelephoneNumber varchar(30) not null,
	marketEmail nvarchar(50) not null,
	constraint PK_marketId primary key(marketId),
	constraint CK_marketName check(len(marketName)>1)
);