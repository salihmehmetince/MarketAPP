create table TblCreditCardSaleDetail(
	creditCardSaleDetailId int not null identity(1,1),
	creditCardSaleId int not null,
	productTemplateId int not null,
	price decimal(18,2),
	quantity bigint not null,
	productTotalPrice decimal(18,2) not null,
	constraint PK_creditCardSaleDetailId primary key(creditCardSaleDetailId),
	constraint FK_creditCardSaleId foreign key(creditCardSaleId) references TblCustomerBuysProductWithCreditCard(customerBuysProductWithCreditCardId),
	constraint FK_productTemplateId foreign key(productTemplateId) references TblProductTemplate(productTemplateId),
);