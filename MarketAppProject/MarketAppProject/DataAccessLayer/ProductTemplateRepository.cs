using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class ProductTemplateRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public ProductTemplateRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblProductTemplate> DALProductTemplateList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblProductTemplate.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while listing the product templates", e);
            }
        }

        public int DALProductTemplateAdd(TblProductTemplate productTemplate)
        {
            try
            {
                if(productTemplate != null)
                {
                    dBMarketAppEntitiesContext.TblProductTemplate.Add(productTemplate);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return productTemplate.productTemplateId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while adding the product template", e);
            }
        }

        public int DALProductTemplateUpdate(TblProductTemplate productTemplate)
        {
            try
            {
                TblProductTemplate existingProductTemplate = dBMarketAppEntitiesContext.TblProductTemplate.Find(productTemplate.productTemplateId);
                if(existingProductTemplate != null)
                {
                    existingProductTemplate.productTemplateKind = productTemplate.productTemplateKind;
                    existingProductTemplate.productTemplateBrand = productTemplate.productTemplateBrand;
                    existingProductTemplate.productTemplateType = productTemplate.productTemplateType;
                    existingProductTemplate.productTemplateUnit = productTemplate.productTemplateUnit;
                    existingProductTemplate.productTemplateName = productTemplate.productTemplateName;
                    existingProductTemplate.productTemplateCost = productTemplate.productTemplateCost;
                    existingProductTemplate.productTemplateProfitPercent = productTemplate.productTemplateProfitPercent;
                    existingProductTemplate.productTemplateLifeTeamYear = productTemplate.productTemplateLifeTeamYear;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingProductTemplate.productTemplateId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while updating the product template", e);
            }
        }

        public int DALProductTemplateDelete(TblProductTemplate productTemplate)
        {
            try
            {
                TblProductTemplate existingProductTemplate = dBMarketAppEntitiesContext.TblProductTemplate.Find(productTemplate.productTemplateId);
                if (existingProductTemplate != null)
                {
                    dBMarketAppEntitiesContext.TblProductTemplate.Remove(existingProductTemplate);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingProductTemplate.productTemplateId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while deleting the product template", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
