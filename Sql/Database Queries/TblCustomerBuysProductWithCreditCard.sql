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
	constraint FK_customerId foreign key(customerId) references TblCustomer(customerId),
	constraint FK_marketId foreign key(marketId) references TblMarket(marketId),
	constraint FK_saleCurrency foreign key(saleCurrency) references TblAppCurrency(appCurrencyId)
);