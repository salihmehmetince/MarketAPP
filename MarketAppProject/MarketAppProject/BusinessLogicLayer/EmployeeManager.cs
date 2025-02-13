using MarketAppProject.DataAccessLayer;
using MarketAppProject.EntityLayer;
using MarketAppProject.HelperFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.BusinessLogicLayer
{
    internal class EmployeeManager
    {
        public List<TblEmployee> BLEmployeeList()
        {
            using (var repository = new EmployeeRepository())
            {
                return repository.DALEmployeeList();
            }
        }

        public int BLEmployeeAdd(TblEmployee employee)
        {
            if (FieldCheck.checkBasicStringField(employee.employeeIdentityNumber, 5, 15)
                || FieldCheck.checkBasicStringField(employee.employeeName, 1, 40)
                || FieldCheck.checkBasicStringField(employee.employeeSurname, 1, 40)
                || FieldCheck.checkEmailField(employee.employeeEmail)
                || FieldCheck.checkPhoneField(employee.employeeTelephoneNumber)
                || FieldCheck.checkGenderField(employee.employeeGender)
                || FieldCheck.checkDateTimeField(employee.employeeBirthDate)
                || FieldCheck.checkAddressField(employee.employeeBirthPlace)
                || FieldCheck.checkAddressField(employee.employeeAddress)
                || employee.employeeRank < 0
                || employee.employeePosition < 0
                || employee.employeeDepartment < 0
                )
            {
                return -1;
            }
            else
            {
                if (employee.employeeSalary.HasValue)
                {
                    if (employee.employeeSalary < 0)
                    {
                        return -1;
                    }
                }
            }
            using (var repository = new EmployeeRepository())
            {
                return repository.DALEmployeeAdd(employee);
            }
        }
        public int BLEmployeeUpdate(TblEmployee employee)
        {
            if (employee.employeeId<0
                ||FieldCheck.checkBasicStringField(employee.employeeIdentityNumber,5,15)
                ||FieldCheck.checkBasicStringField(employee.employeeName,1,40)
                ||FieldCheck.checkBasicStringField(employee.employeeSurname,1,40)
                ||FieldCheck.checkEmailField(employee.employeeEmail)
                ||FieldCheck.checkPhoneField(employee.employeeTelephoneNumber)
                ||FieldCheck.checkGenderField(employee.employeeGender)
                ||FieldCheck.checkDateTimeField(employee.employeeBirthDate)
                ||FieldCheck.checkAddressField(employee.employeeBirthPlace)
                ||FieldCheck.checkAddressField(employee.employeeAddress)
                ||employee.employeeRank<0
                ||employee.employeePosition<0
                ||employee.employeeDepartment<0
                )
            {
                return -1;
            }
            else
            {
                if (employee.employeeSalary.HasValue)
                {
                    if (employee.employeeSalary < 0)
                    {
                        return -1;
                    }
                }
            }

            using (var repository = new EmployeeRepository())
            {
                return repository.DALEmployeeUpdate(employee);
            }
        }

        public int BLEmployeeDelete(TblEmployee employee)
        {
            using (var repository = new EmployeeRepository())
            {
                return repository.DALEmployeeDelete(employee);
            }
        }
    }
}
