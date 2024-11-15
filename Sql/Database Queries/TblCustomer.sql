create table TblCustomer(
	customerId int not null identity(1,1),
	customerName nvarchar(40) not null,
	customerSurname nvarchar(40) not null,
	customerEmail nvarchar(50) not null,
	customerTelephoneNumber varchar(30) not null,
	customerGender char(1) not null,
	customerAddress nvarchar(255) not null,
	constraint PK_customerId primary key(customerId),
	constraint CK_customerName check(len(customerName)>1),
	constraint CK_customerSurname check(len(customerSurname)>1),
	constraint CK_customerGender check(customerGender in ('M','F','N')),

);