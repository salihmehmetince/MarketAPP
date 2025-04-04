create table TblCashSaleDetail(
	cashSaleDetailId int not null identity(1,1),
	cashSaleId int not null,
	productTemplateId int not null,
	price decimal(18,2),
	quantity bigint not null,
	productTotalPrice decimal(18,2) not null,
	constraint PK_cashSaleDetailId primary key(cashSaleDetailId),
	constraint FK_cashSaleIdCashSaleDetail foreign key(cashSaleId) references TblCustomerBuysProductWithCash(customerBuysProductWithCashId),
	constraint FK_productTemplateIdCashSaleDetail foreign key(productTemplateId) references TblProductTemplate(productTemplateId),
);