using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class TblCreditCardSaleDetailRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public TblCreditCardSaleDetailRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblCreditCardSaleDetail> DALTblCreditCardSaleDetailList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblCreditCardSaleDetail.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the TblCreditCardSaleDetail", e);
            }
        }

        public int DALTblCreditCardSaleDetailAdd(TblCreditCardSaleDetail creditCardSaleDetail)
        {
            try
            {
                if (creditCardSaleDetail != null)
                {
                    dBMarketAppEntitiesContext.TblCreditCardSaleDetail.Add(creditCardSaleDetail);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return creditCardSaleDetail.creditCardSaleDetailId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the creditCardSaleDetail", e);
            }
        }

        public int DALTblCreditCardSaleDetailUpdate(TblCreditCardSaleDetail creditCardSaleDetail)
        {
            try
            {
                TblCreditCardSaleDetail existingCreditCardSaleDetail = dBMarketAppEntitiesContext.TblCreditCardSaleDetail.Find(creditCardSaleDetail.creditCardSaleDetailId);
                if (existingCreditCardSaleDetail != null)
                {
                    existingCreditCardSaleDetail.creditCardSaleId=creditCardSaleDetail.creditCardSaleId;
                    existingCreditCardSaleDetail.productTemplateId = creditCardSaleDetail.productTemplateId;
                    existingCreditCardSaleDetail.price = creditCardSaleDetail.price;
                    existingCreditCardSaleDetail.quantity = creditCardSaleDetail.quantity;
                    existingCreditCardSaleDetail.productTotalPrice = creditCardSaleDetail.productTotalPrice;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCreditCardSaleDetail.creditCardSaleDetailId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the creditCardSaleDetail", e);
            }
        }

        public int DALTblCreditCardSaleDetailDelete(TblCreditCardSaleDetail creditCardSaleDetail)
        {
            try
            {
                TblCreditCardSaleDetail existingTblCreditCardSaleDetail = dBMarketAppEntitiesContext.TblCreditCardSaleDetail.Find(creditCardSaleDetail.creditCardSaleDetailId);
                if (existingTblCreditCardSaleDetail != null)
                {
                    dBMarketAppEntitiesContext.TblCreditCardSaleDetail.Remove(existingTblCreditCardSaleDetail);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingTblCreditCardSaleDetail.creditCardSaleDetailId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the creditCardSaleDetail", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
