using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class CashSaleDetailRepository : IDisposable
    {
        private readonly DBMarketAppEntities dBMarketAppEntitiesContext;

        public CashSaleDetailRepository()
        {
            dBMarketAppEntitiesContext = new DBMarketAppEntities();
        }

        public List<TblCashSaleDetail> DALCashSaleDetailList()
        {
            try
            {
                return dBMarketAppEntitiesContext.TblCashSaleDetail.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while listing the CashSaleDetail", e);
            }
        }

        public int DALCashSaleDetailAdd(TblCashSaleDetail cashSaleDetail)
        {
            try
            {
                if (cashSaleDetail != null)
                {
                    dBMarketAppEntitiesContext.TblCashSaleDetail.Add(cashSaleDetail);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return cashSaleDetail.cashSaleDetailId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while adding the cashSaleDetail", e);
            }
        }

        public int DALCashSaleDetailUpdate(TblCashSaleDetail cashSaleDetail)
        {
            try
            {
                TblCashSaleDetail existingCashSaleDetail = dBMarketAppEntitiesContext.TblCashSaleDetail.Find(cashSaleDetail.cashSaleDetailId);
                if (existingCashSaleDetail != null)
                {
                    existingCashSaleDetail.cashSaleId = cashSaleDetail.cashSaleId;
                    existingCashSaleDetail.productTemplateId = cashSaleDetail.productTemplateId;
                    existingCashSaleDetail.price = cashSaleDetail.price;
                    existingCashSaleDetail.quantity = cashSaleDetail.quantity;
                    existingCashSaleDetail.productTotalPrice = cashSaleDetail.productTotalPrice;
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCashSaleDetail.cashSaleDetailId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while updating the country", e);
            }
        }

        public int DALCashSaleDetailDelete(TblCashSaleDetail cashSaleDetail)
        {
            try
            {
                TblCashSaleDetail existingCashSaleDetail = dBMarketAppEntitiesContext.TblCashSaleDetail.Find(cashSaleDetail.cashSaleDetailId);
                if (existingCashSaleDetail != null)
                {
                    dBMarketAppEntitiesContext.TblCashSaleDetail.Remove(existingCashSaleDetail);
                    dBMarketAppEntitiesContext.SaveChanges();
                    return existingCashSaleDetail.cashSaleDetailId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while deleting the cashSaleDetail", e);
            }
        }

        public void Dispose()
        {
            dBMarketAppEntitiesContext.Dispose();
        }
    }
}
