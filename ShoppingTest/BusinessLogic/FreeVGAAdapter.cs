using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingTest.BusinessLogic
{
    public class FreeVGAAdapter : IOffer
    {
        string mOfferWith = "";
        decimal mFreeProductCost = 0;
        public FreeVGAAdapter(decimal freeProductCost)
        {
            mFreeProductCost = freeProductCost;
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
            if (quantity <= 0)
                quantity = 0;
            return mFreeProductCost * quantity;

        }
    }
}
