using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingTest.BusinessLogic
{
    public class BulkDiscount : IOffer
    {
        int mMinimumQuantity;
        decimal mDiscountedUnitCost;
        string mOfferWith = "";
        public BulkDiscount(int minimumQuantity, decimal discountedUnitCost)
        {
            if (0 >= minimumQuantity)
                minimumQuantity = 0;
            mMinimumQuantity = minimumQuantity;
            mDiscountedUnitCost = discountedUnitCost;
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
            if (quantity < mMinimumQuantity)
            {
                return 0;
            }
            else
            {
                return (unitPrice - mDiscountedUnitCost) * quantity;
            }
        }
    }
}
