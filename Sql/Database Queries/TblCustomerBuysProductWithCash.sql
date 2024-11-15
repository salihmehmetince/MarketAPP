create table TblCustomerBuysProductWithCash(
	customerBuysProductWithCashId int not null identity(1,1),
	customerId int not null,
	marketId int not null,
	totalPrice decimal(18,2) not null,
	saleDate date not null,
	saleCurrency int not null,
	customerCurrency int not null,
	currencySaleMomentValue decimal(18,6),
	customerPaidInCurrency decimal(18,2),
	constraint PK_customerBuysProductWithCashId primary key(customerBuysProductWithCashId),
	constraint FK_customerId foreign key(customerId) references TblCustomer(customerId),
	constraint FK_marketId foreign key(marketId) references TblMarket(marketId),
	constraint FK_saleCurrency foreign key(saleCurrency) references TblAppCurrency(appCurrencyId),
	constraint FK_customerCurrency foreign key(customerCurrency) references TblCurrency(currencyId)
);