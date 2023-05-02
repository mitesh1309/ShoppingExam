using ShoppingTest.BusinessLogic;
using ShoppingTest.Entity;
using System;
using System.Collections.Generic;

namespace ShoppingTest
{
    public class PricingRules
    {
        public Dictionary<String, Product> productList;

        public List<IOffer> offerList;

        public Dictionary<String, Product> getProductList()
        {
            return productList;
        }

        public List<IOffer> getOfferList()
        {
            return offerList;
        }
        public PricingRules(Dictionary<String, Product> products, List<IOffer> offers)
        {
            this.productList = products;
            this.offerList = offers;
        }

    }

}
