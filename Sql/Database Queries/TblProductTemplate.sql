create table TblProductTemplate(
	productTemplateId int not null identity(1,1),
	productTemplateName nvarchar(40) not null,
	productTemplateProfitPercent smallint not null,
	productTemplateLifeTeamYear tinyint not null,
	productTemplateCost int not null,
	productTemplateKind int not null,
	productTemplateType int not null,
	productTemplateBrand int not null,
	productTemplateUnit int not null,
	constraint PK_productTemplateId primary key(productTemplateId),
	constraint CK_productTemplateName check(len(productTemplateName)>1),
	constraint FK_productTemplateKind foreign key(productTemplateKind) references TblProductKind(productKindId),
	constraint FK_productTemplateType foreign key(productTemplateType) references TblProductType(productTypeId),
	constraint FK_productTemplateBrand foreign key(productTemplateBrand) references TblProductBrand(productBrandId),
	constraint FK_productTemplateUnit foreign key(productTemplateUnit) references TblProductUnit(productUnitId)
);