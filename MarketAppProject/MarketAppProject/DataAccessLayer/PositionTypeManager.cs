using MarketAppProject.EntityLayer;
using MarketAppProject.HelperFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class PositionTypeManager
    {
        public List<TblPositionType> BLPositionTypeList()
        {
            using (var repository = new PositionTypeRepository())
            {
                return repository.DALPositionTypeList();
            }
        }

        public int BLPositionTypeAdd(TblPositionType positionType)
        {
            if (FieldCheck.checkBasicStringField(positionType.positionTypeName, 1, 40)
                ||positionType.positionTypeSalaryValue<0
                )
            {
                return -1;
            }

            using (var repository = new PositionTypeRepository())
            {
                return repository.DALPositionTypeAdd(positionType);
            }
        }
        public int BLPositionTypeUpdate(TblPositionType positionType)
        {
            if (positionType.positionTypeId<0
                ||FieldCheck.checkBasicStringField(positionType.positionTypeName, 1, 40)
                ||positionType.positionTypeSalaryValue<0
                )
            {
                return -1;
            }

            using (var repository = new PositionTypeRepository())
            {
                return repository.DALPositionTypeUpdate(positionType);
            }
        }

        public int BLPositionTypeDelete(TblPositionType positionType)
        {
            using (var repository = new PositionTypeRepository())
            {
                return repository.DALPositionTypeDelete(positionType);
            }
        }
    }
}
