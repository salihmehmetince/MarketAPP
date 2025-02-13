using MarketAppProject.DataAccessLayer;
using MarketAppProject.EntityLayer;
using MarketAppProject.HelperFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.BusinessLogicLayer
{
    internal class CreditCardSaleDetailManager
    {
        public List<TblCreditCardSaleDetail> BLCreditCardSaleDetailList()
        {
            using (var repository = new CreditCardSaleDetailRepository())
            {
                return repository.DALCreditCardSaleDetailList();
            }
        }

        public int BLCreditCardSaleDetailAdd(TblCreditCardSaleDetail creditCardSaleDetail)
        {
            if (creditCardSaleDetail.creditCardSaleId<0
                ||creditCardSaleDetail.productTemplateId<0
                ||creditCardSaleDetail.quantity<0
                ||creditCardSaleDetail.productTotalPrice<0
                )
            {
                return -1;
            }
            else
            {
                if(creditCardSaleDetail.price.HasValue)
                {
                    if(creditCardSaleDetail.price<0)
                    {
                        return -1;
                    }
                }
            }

            using (var repository = new CreditCardSaleDetailRepository())
            {
                return repository.DALCreditCardSaleDetailAdd(creditCardSaleDetail);
            }
        }
        public int BLCreditCardSaleDetailUpdate(TblCreditCardSaleDetail creditCardSaleDetail)
        {
            if (creditCardSaleDetail.creditCardSaleDetailId<0
                ||creditCardSaleDetail.creditCardSaleId<0
                ||creditCardSaleDetail.productTemplateId<0
                ||!creditCardSaleDetail.price.HasValue
                || creditCardSaleDetail.price<0
                ||creditCardSaleDetail.quantity<0
                ||creditCardSaleDetail.productTotalPrice<0
                )
            {
                return -1;
            }
            else
            {
                if (creditCardSaleDetail.price.HasValue)
                {
                    if (creditCardSaleDetail.price < 0)
                    {
                        return -1;
                    }
                }
            }

            using (var repository = new CreditCardSaleDetailRepository())
            {
                return repository.DALCreditCardSaleDetailUpdate(creditCardSaleDetail);
            }
        }

        public int BLCreditCardSaleDetailDelete(TblCreditCardSaleDetail creditCardSaleDetail)
        {
            using (var repository = new CreditCardSaleDetailRepository())
            {
                return repository.DALCreditCardSaleDetailDelete(creditCardSaleDetail);
            }
        }
    }
}
