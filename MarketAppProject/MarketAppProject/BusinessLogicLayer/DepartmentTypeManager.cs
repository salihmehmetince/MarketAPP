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
    internal class DepartmentTypeManager
    {
        public List<TblDepartmentType> BLDepartmentTypeList()
        {
            using (var repository = new DepartmentTypeRepository())
            {
                return repository.DALDepartmentTypeList();
            }
        }

        public int BLDepartmentTypeAdd(TblDepartmentType departmentType)
        {
            if (FieldCheck.checkBasicStringField(departmentType.departmentTypeName,1,40)
                ||departmentType.departmentTypeSalaryFactor<0
                )
            {
                return -1;
            }

            using (var repository = new DepartmentTypeRepository())
            {
                return repository.DALDepartmentTypeAdd(departmentType);
            }
        }
        public int BLDepartmentTypeUpdate(TblDepartmentType departmentType)
        {
            if (departmentType.departmentTypeId<0
                ||FieldCheck.checkBasicStringField(departmentType.departmentTypeName,1,40)
                ||departmentType.departmentTypeSalaryFactor<0
                )
            {
                return -1;
            }

            using (var repository = new DepartmentTypeRepository())
            {
                return repository.DALDepartmentTypeUpdate(departmentType);
            }
        }

        public int BLDepartmentTypeDelete(TblDepartmentType departmentType)
        {
            using (var repository = new DepartmentTypeRepository())
            {
                return repository.DALDepartmentTypeDelete(departmentType);
            }
        }
    }
}
