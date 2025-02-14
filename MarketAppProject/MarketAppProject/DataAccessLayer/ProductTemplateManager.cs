using MarketAppProject.EntityLayer;
using MarketAppProject.HelperFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class ProductTemplateManager
    {
        public List<TblProductTemplate> BLProductTemplateList()
        {
            using (var repository = new ProductTemplateRepository())
            {
                return repository.DALProductTemplateList();
            }
        }

        public int BLProductTemplateAdd(TblProductTemplate productTemplate)
        {
            if (FieldCheck.checkBasicStringField(productTemplate.productTemplateName, 1, 40)
                ||productTemplate.productTemplateProfitPercent<0
                ||productTemplate.productTemplateLifeTeamYear<0
                ||productTemplate.productTemplateCost<0
                || productTemplate.productTemplateKind<0
                || productTemplate.productTemplateType<0
                || productTemplate.productTemplateBrand<0
                || productTemplate.productTemplateUnit<0
                || productTemplate.productTemplateCurrency<0
                )
            {
                return -1;
            }

            using (var repository = new ProductTemplateRepository())
            {
                return repository.DALProductTemplateAdd(productTemplate);
            }
        }
        public int BLProductTemplateUpdate(TblProductTemplate productTemplate)
        {
            if (productTemplate.productTemplateId<0
                ||FieldCheck.checkBasicStringField(productTemplate.productTemplateName, 1, 40)
                ||productTemplate.productTemplateProfitPercent<0
                ||productTemplate.productTemplateLifeTeamYear<0
                ||productTemplate.productTemplateCost<0
                || productTemplate.productTemplateKind<0
                || productTemplate.productTemplateType<0
                || productTemplate.productTemplateBrand<0
                || productTemplate.productTemplateUnit<0
                || productTemplate.productTemplateCurrency<0
                )
            {
                return -1;
            }

            using (var repository = new ProductTemplateRepository())
            {
                return repository.DALProductTemplateUpdate(productTemplate);
            }
        }

        public int BLProductTemplateDelete(TblProductTemplate productTemplate)
        {
            using (var repository = new ProductTemplateRepository())
            {
                return repository.DALProductTemplateDelete(productTemplate);
            }
        }
    }
}
