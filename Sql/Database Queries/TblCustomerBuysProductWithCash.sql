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
	constraint FK_customerIdCustomerBuysProductWithCash foreign key(customerId) references TblCustomer(customerId),
	constraint FK_marketIdCustomerBuysProductWithCash foreign key(marketId) references TblMarket(marketId),
	constraint FK_saleCurrencyCustomerBuysProductWithCash foreign key(saleCurrency) references TblAppCurrency(appCurrencyId),
	constraint FK_customerCurrencyCustomerBuysProductWithCash foreign key(customerCurrency) references TblCurrency(currencyId)
);