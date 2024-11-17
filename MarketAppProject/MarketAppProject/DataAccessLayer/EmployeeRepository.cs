using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class EmployeeRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public EmployeeRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblEmployee> DALEmployeeList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblEmployee.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the employees", e);
            }
        }

        public int DALEmployeeAdd(TblEmployee employee)
        {
            try
            {
                if(employee!=null)
                {
                    dBMarketAppEntitiesContext.TblEmployee.Add(employee);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return employee.employeeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the employee", e);
            }
        }

        public int DALEmployeeUpdate(TblEmployee employee)
        {
            try
            {
                TblEmployee existingEmployee = dBMarketAppEntitiesContext.TblEmployee.Find(employee.employeeId);
                if(existingEmployee!=null)
                {
                    existingEmployee.employeeName = employee.employeeName;
                    existingEmployee.employeeSurname = existingEmployee.employeeSurname;
                    existingEmployee.employeeIdentityNumber=existingEmployee.employeeIdentityNumber;
                    existingEmployee.employeeGender = employee.employeeGender;
                    existingEmployee.employeeTelephoneNumber = employee.employeeTelephoneNumber;
                    existingEmployee.employeeEmail = employee.employeeEmail;
                    existingEmployee.employeeRank = employee.employeeRank;
                    existingEmployee.employeePosition = employee.employeePosition;
                    existingEmployee.employeeDepartment = employee.employeeDepartment;
                    existingEmployee.employeeBirthDate = employee.employeeBirthDate;
                    existingEmployee.employeeBirthPlace = employee.employeeBirthPlace;
                    existingEmployee.employeeAddress = employee.employeeAddress;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingEmployee.employeeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the employee", e);
            }
        }

        public int DALEmployeeDelete(TblEmployee employee)
        {
            try
            {
                TblEmployee existingEmployee = dBMarketAppEntitiesContext.TblEmployee.Find(employee.employeeId);
                if (existingEmployee != null)
                {
                    dBMarketAppEntitiesContext.TblEmployee.Remove(existingEmployee);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingEmployee.employeeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the employee", e);
            }
        }
        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
