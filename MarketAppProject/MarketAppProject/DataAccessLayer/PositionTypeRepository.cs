using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class PositionTypeRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public PositionTypeRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();    
        }

        public List<TblPositionType> DALPositionTypeList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblPositionType.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the position types", e);
            }
        }

        public int DALPositionTypeAdd(TblPositionType positionType)
        {
            try
            {
                if(positionType != null)
                {
                    dBMarketAppEntitiesContext.TblPositionType.Add(positionType);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return positionType.positionTypeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the position type", e);
            }
        }

        public int DALPositionTypeUpdate(TblPositionType positionType)
        {
            try
            {
                TblPositionType existingPositionType = dBMarketAppEntitiesContext.TblPositionType.Find(positionType.positionTypeId);
                if(existingPositionType!=null)
                {
                    existingPositionType.positionTypeName=positionType.positionTypeName;
                    existingPositionType.positionTypeSalaryValue = positionType.positionTypeSalaryValue;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingPositionType.positionTypeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the position type", e);
            }
        }

        public int DALPositionTypeDelete(TblPositionType positionType)
        {
            try
            {
                TblPositionType existingPositionType = dBMarketAppEntitiesContext.TblPositionType.Find(positionType.positionTypeId);
                if (existingPositionType != null)
                {
                    dBMarketAppEntitiesContext.TblPositionType.Remove(existingPositionType);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingPositionType.positionTypeId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the position type", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
