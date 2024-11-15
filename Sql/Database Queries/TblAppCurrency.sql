create table TblAppCurrency(
	appCurrencyId int not null identity(1,1),
	appCurrencyCode char(3) not null,
	isActive bit not null,
	constraint PK_appCurrencyId primary key(appCurrencyId),
);