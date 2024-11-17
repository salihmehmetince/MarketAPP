using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class CompanyOwnerRepository:IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public CompanyOwnerRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblCompanyOwner> DALCompanyOwnerList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblCompanyOwner.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the company owners", e);
            }
        }

        public int DALCompanyOwnerAdd(TblCompanyOwner companyOwner)
        {
            try
            {
                if (companyOwner != null)
                {
                    dBMarketAppEntitiesContext.TblCompanyOwner.Add(companyOwner);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return companyOwner.companyOwnerId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the company owner", e);
            }
        }

        public int DALCompanyOwnerUpdate(TblCompanyOwner companyOwner)
        {
            try
            {
                TblCompanyOwner existingCompanyOwner = dBMarketAppEntitiesContext.TblCompanyOwner.Find(companyOwner.companyOwnerId);
                if (existingCompanyOwner != null)
                {
                    existingCompanyOwner.companyOwnerIdentityNumber = companyOwner.companyOwnerIdentityNumber;
                    existingCompanyOwner.companyOwnerName = companyOwner.companyOwnerName;
                    existingCompanyOwner.companyOwnerSurname = companyOwner.companyOwnerSurname;
                    existingCompanyOwner.companyOwnerEmail = companyOwner.companyOwnerEmail;
                    existingCompanyOwner.companyOwnerTelephoneNumber = companyOwner.companyOwnerTelephoneNumber;
                    existingCompanyOwner.companyOwnerBirthDate = companyOwner.companyOwnerBirthDate;
                    existingCompanyOwner.companyOwnerBirthPlace = companyOwner.companyOwnerBirthPlace;
                    existingCompanyOwner.companyOwnerGender=companyOwner.companyOwnerGender;
                    existingCompanyOwner.companyOwnerAddress = companyOwner.companyOwnerAddress;
                    existingCompanyOwner.companyOwnerProfession= companyOwner.companyOwnerProfession;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCompanyOwner.companyOwnerId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the company owner", e);
            }
        }

        public int DALDeleteCompanyOwner(TblCompanyOwner companyOwner)
        {
            try
            {
                TblCompanyOwner existingCompanyOwner = dBMarketAppEntitiesContext.TblCompanyOwner.Find(companyOwner.companyOwnerId);
                if (existingCompanyOwner != null)
                {
                    dBMarketAppEntitiesContext.TblCompanyOwner.Remove(existingCompanyOwner);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCompanyOwner.companyOwnerId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the company owner", e);
            }
        }


        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
