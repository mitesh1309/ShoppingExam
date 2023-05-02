using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingTest.BusinessLogic
{
    public interface IOffer
    {
        void setOfferWith(String offerWith);
        String getOfferWith();
        decimal computeDiscountForTheOffer(int quantity, decimal unitPrice);
    }

}
