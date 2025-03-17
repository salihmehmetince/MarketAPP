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
    internal class RankTypeManager
    {
        public List<TblRankType> BLRankTypeList()
        {
            using (var repository = new RankTypeRepository())
            {
                return repository.DALRankTypeList();
            }
        }

        public int BLRankTypeAdd(TblRankType rankType)
        {
            if (FieldCheck.checkBasicStringField(rankType.rankTypeName, 1, 40)
                ||rankType.rankTypeSalaryValue<0
                )
            {
                return -1;
            }

            using (var repository = new RankTypeRepository())
            {
                return repository.DALRankTypeAdd(rankType);
            }
        }
        public int BLRankTypeUpdate(TblRankType rankType)
        {
            if (rankType.rankTypeId<0
                ||FieldCheck.checkBasicStringField(rankType.rankTypeName, 1, 40)
                ||rankType.rankTypeSalaryValue<0
                )
            {
                return -1;
            }

            using (var repository = new RankTypeRepository())
            {
                return repository.DALRankTypeUpdate(rankType);
            }
        }
        public int BLRankTypeDelete(TblRankType rankType)
        {
            if(rankType.rankTypeId<0)
            {
                return -1;
            }
            using (var repository = new RankTypeRepository())
            {
                return repository.DALRankTypeDelete(rankType);
            }
        }
    }
}
