using MarketAppProject.DataAccessLayer;
using MarketAppProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.BusinessLogicLayer
{
    internal class CashSaleDetailManager
    {
        public List<TblCashSaleDetail> BLCashSaleDetailList()
        {
            using (var repository = new CashSaleDetailRepository())
            {
                return repository.DALCashSaleDetailList();
            }
        }

        public int BLCashSaleDetailAdd(TblCashSaleDetail cashSaleDetail)
        {
            if (cashSaleDetail.cashSaleId<1 
                || cashSaleDetail.productTemplateId<1 
                || cashSaleDetail.quantity<0 
                || cashSaleDetail.productTotalPrice<0)
            {
                return -1;
            }
            else
            {
                if(cashSaleDetail.price.HasValue)
                {
                    if (cashSaleDetail.price < 0) 
                    {
                        return -1;
                    }
                }
            }

            using (var repository = new CashSaleDetailRepository())
            {
                return repository.DALCashSaleDetailAdd(cashSaleDetail);
            }
        }

        public int BLCashSaleDetailUpdate(TblCashSaleDetail cashSaleDetail)
        {
            if (cashSaleDetail.cashSaleDetailId<0
                || cashSaleDetail.cashSaleId < 1 
                || cashSaleDetail.productTemplateId < 1 
                || cashSaleDetail.quantity < 0 
                || cashSaleDetail.productTotalPrice < 0)
            {
                return -1;
            }
            else
            {
                if (cashSaleDetail.price.HasValue)
                {
                    if (cashSaleDetail.price < 0)
                    {
                        return -1;
                    }
                }
            }

            using (var repository = new CashSaleDetailRepository())
            {
                return repository.DALCashSaleDetailUpdate(cashSaleDetail);
            }
        }

        public int BLCashSaleDetailDelete(TblCashSaleDetail cashSaleDetail)
        {
            using (var repository = new CashSaleDetailRepository())
            {
                return repository.DALCashSaleDetailDelete(cashSaleDetail);
            }
        }
    }
}
