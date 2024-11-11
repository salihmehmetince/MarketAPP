create table TblDepartmentType(
	departmentTypeId int not null identity(1,1),
	departmentTypeName nvarchar(40) not null,
	departmentTypeSalaryFactor decimal(5,2) not null,
	constraint PK_departmentTypeId primary key(departmentTypeId),
	constraint CK_departmentTypeName check(len(departmentTypeName)>1)
);