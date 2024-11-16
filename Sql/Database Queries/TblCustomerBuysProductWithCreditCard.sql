create table TblCustomerBuysProductWithCreditCard(
	customerBuysProductWithCreditCardId int not null identity(1,1),
	customerId int not null,
	marketId int not null,
	totalPrice decimal(18,2) not null,
	saleDate date not null,
	saleCurrency int not null,
	cardNameFirstAndLastTwocharacters nchar(4) not null,
	cardNumberLastFourDigidts char(4) not null,
	cardLastUseYear smallint not null,
	constraint PK_customerBuysProductWithCreditCardId primary key(customerBuysProductWithCreditCardId),
	constraint FK_customerIdCustomerBuysProductWithCreditCard foreign key(customerId) references TblCustomer(customerId),
	constraint FK_marketIdCustomerBuysProductWithCreditCard foreign key(marketId) references TblMarket(marketId),
	constraint FK_saleCurrencyCustomerBuysProductWithCreditCard foreign key(saleCurrency) references TblAppCurrency(appCurrencyId)
);