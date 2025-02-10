using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class AdminRepository:IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public AdminRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblAdmin> DALAdminList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblAdmin.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the admin", e);
            }
        }

        public int DALAdminAdd(TblAdmin admin)
        {
            try
            {
                if (admin != null)
                {
                    dBMarketAppEntitiesContext.TblAdmin.Add(admin);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return admin.adminId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the admin", e);
            }
        }

        public int DALAdminUpdate(TblAdmin admin)
        {
            try
            {
                TblAdmin existingAdmin = dBMarketAppEntitiesContext.TblAdmin.Find(admin.adminId);
                if (existingAdmin != null)
                {
                    existingAdmin.adminPassword = admin.adminPassword;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingAdmin.adminId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the admin", e);
            }
        }

        public int DALAdminDelete(TblAdmin admin)
        {
            try
            {
                TblAdmin existingAdmin = dBMarketAppEntitiesContext.TblAdmin.Find(admin.adminId);
                if (existingAdmin != null)
                {
                    dBMarketAppEntitiesContext.TblAdmin.Remove(existingAdmin);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingAdmin.adminId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the admin", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
