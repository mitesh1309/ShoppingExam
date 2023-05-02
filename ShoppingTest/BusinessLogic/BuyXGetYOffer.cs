using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingTest.BusinessLogic
{
    public class BuyXGetYOffer : IOffer
    {
        string mOfferWith = "";
        int mBuyQuantity;
        int mPayQuantity;
        public BuyXGetYOffer(int buyQuantitiy, int payQuantity)
        {
            if (0 >= buyQuantitiy)
                buyQuantitiy = 0;
            if (0 >= payQuantity)
                payQuantity = 0;
            mBuyQuantity = buyQuantitiy;
            mPayQuantity = payQuantity;
        }
        public void setOfferWith(string offerWith)
        {
            mOfferWith = offerWith;
        }
        public string getOfferWith()
        {
            return mOfferWith;
        }
        public decimal computeDiscountForTheOffer(int quantity, decimal unitPrice)
        {
            decimal no_discount = 0;
            if (quantity <= mPayQuantity)
            {
                return no_discount;
            }
            if (mBuyQuantity <= 0)
            {
                return no_discount;
            }
            else
            {
                int quotient = quantity / mBuyQuantity;
                int reminder = quantity % mBuyQuantity;
                decimal actualCost = unitPrice * quantity;
                return actualCost - (quotient * mPayQuantity * unitPrice + reminder * unitPrice);
            }
        }
    }

}
