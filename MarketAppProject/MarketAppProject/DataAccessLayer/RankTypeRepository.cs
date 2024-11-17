using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class RankTypeRepository : IDisposable
    {

        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public RankTypeRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblRankType> DALRankTypeList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblRankType.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the rank types", e);
            }
        }

        public int DALRankTypeAdd(TblRankType rankType)
        {
            try
            {
                if(rankType != null)
                {
                    dBMarketAppEntitiesContext.TblRankType.Add(rankType);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return rankType.rankTypeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the rank type", e);
            }
        }

        public int DALRankTypeUpdate(TblRankType rankType)
        {
            try
            {
                TblRankType existingRankType = dBMarketAppEntitiesContext.TblRankType.Find(rankType.rankTypeId);
                if(existingRankType != null)
                {
                    existingRankType.rankTypeName=rankType.rankTypeName;
                    existingRankType.rankTypeSalaryValue=rankType.rankTypeSalaryValue;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingRankType.rankTypeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the rank type", e);
            }
        }

        public int DALRankTypeDelete(TblRankType rankType)
        {
            try
            {
                TblRankType existingRankType = dBMarketAppEntitiesContext.TblRankType.Find(rankType.rankTypeId);
                if (existingRankType != null)
                {
                    dBMarketAppEntitiesContext.TblRankType.Remove(existingRankType);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingRankType.rankTypeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the rank type", e);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
