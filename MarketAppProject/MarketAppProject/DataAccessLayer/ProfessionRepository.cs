using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketAppProject.EntityLayer;

namespace MarketAppProject.DataAccessLayer
{
    internal class ProfessionRepository:IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public ProfessionRepository()
        {
            dBMarketAppEntitiesContext=new DBMarketAppEntities();
        }

        public List<TblProfession> DALProfessionList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblProfession.ToList();
            }
            catch(Exception e)
            {
                throw new Exception("An error occured while listing the professions", e);
            }
        }

        public int DALProfessionAdd(TblProfession profession)
        {
            try
            {
                if (profession != null)
                {
                    dBMarketAppEntitiesContext.TblProfession.Add(profession);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return profession.professionId;
                }
                else
                {
                    return -1;
                }
            }
            catch(Exception e)
            {
                throw new Exception("An error occured while adding the profession", e);
            }
        }

        public int DALProfessionUpdate(TblProfession profession)
        {
            try
            {
                TblProfession existingProfession = dBMarketAppEntitiesContext.TblProfession.Find(profession.professionId);
                if (existingProfession != null)
                {
                    existingProfession.professionName = profession.professionName;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingProfession.professionId;
                }
                else
                {
                    return -1;
                }
            }
            catch(Exception e)
            {
                throw new Exception("An error occured while updateting the profession", e);
            }
        }

        public int DALProfessionDelete(TblProfession profession)
        {
            try
            {
                TblProfession existingProfession= dBMarketAppEntitiesContext.TblProfession.Find(profession.professionId);
                if(existingProfession!=null)
                {
                    dBMarketAppEntitiesContext.TblProfession.Remove(existingProfession);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingProfession.professionId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the profession", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
